using Capa_entidad;
using Capa_negocio;
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
    public partial class frmReporteSalidas : Form
    {
        public frmReporteSalidas()
        {
            InitializeComponent();
        }

        private void frmReporteSalidas_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                Combo_Producto.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
            }
            Combo_Producto.DisplayMember = "Texto";
            Combo_Producto.ValueMember = "Valor";
            Combo_Producto.SelectedIndex = 0;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            List<ReporteSalida> lista = new List<ReporteSalida>();


            lista = new CN_reportes().Venta(dtm_Inicio.Value.ToString(), dtm_Fin.Value.ToString());

            dgvData.Rows.Clear();

            foreach (ReporteSalida rv in lista)
            {
                dgvData.Rows.Add(new object[] {
                      rv.FechaRegistro,
                      rv.TipoDocumento,
                      rv.NumeroDocumento,
                      rv.UsuarioRegistrado,
                      rv.CodigoProducto,
                      rv.NombreProducto,
                      rv.Categoria,
                      rv.Cantidad,
                });
            }
        }

      
    }
}
