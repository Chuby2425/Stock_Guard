using Capa_entidad;
using Capa_negocio;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.InkML;
using DocumentFormat.OpenXml.Office.CustomUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Utilidades;

namespace WindowsFormsApp1
{
    public partial class frmReporteEntrada : Form
    {
        public frmReporteEntrada()
        {
            InitializeComponent();
        }

        private void frmReporteEntrada_Load(object sender, EventArgs e)
        {
            List<Producto> lista = new CN_Producto().listar();

            Combo_Producto.Items.Add(new OpcionCombo() { Valor = 0, Texto = "TODOS" });
            foreach (Producto item in lista)
            {
                Combo_Producto.Items.Add(new OpcionCombo() { Valor = item.Id_Producto, Texto = item.NombreProducto });
            }
            Combo_Producto.DisplayMember = "Texto";
            Combo_Producto.ValueMember = "Valor";
            Combo_Producto.SelectedIndex = 0;
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            int idproducto = Convert.ToInt32(((OpcionCombo)Combo_Producto.SelectedItem).Valor.ToString());

            List<ReporteEntrada> lista = new List<ReporteEntrada>();

            lista = new CN_reportes().Compra(
                dtm_Inicio.Value.ToString(),
                dtm_Fin.Value.ToString(),
                idproducto
            );


            dgvData.Rows.Clear();

            foreach (ReporteEntrada rc in lista)
            {
                dgvData.Rows.Add(new object[] {
                      rc.FechaRegistro,
                      rc.TipoDocumento,
                      rc.NumeroDocumento,
                      rc.UsuarioRegistro,
                      rc.CodigoProducto,
                      rc.NombreProducto,
                      rc.Categoria,
                      rc.Cantidad,
                  });
            }
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1)
            {

                MessageBox.Show("No hay registros para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {

                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in dgvData.Columns)
                {
                    dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Visible)
                        dt.Rows.Add(new object[] {
                            row.Cells[0].Value.ToString(),
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),

                        });
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("ReporteCompras_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files | *.xlsx";

                if (savefile.ShowDialog() == DialogResult.OK)
                {

                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
            }
        }
    }
} 