using Capa_datos;
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

namespace WindowsFormsApp1.Modales
{
    public partial class MdProductos : Form
    {
        public Producto Produc {  get; set; }
        public MdProductos()
        {
            InitializeComponent();
        }

        private void MdProductosForm1_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true )
                {
                    Combo_Search.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            Combo_Search.DisplayMember = "Texto";
            Combo_Search.ValueMember = "Valor";
            Combo_Search.SelectedIndex = 0;

            List<Producto> lista = new CN_Producto().listar();
            foreach (Producto item in lista)
            {
                dgvData.Rows.Add(new object[] {

                    item.Id_Producto,
                    item.CodigoProducto,
                    item.NombreProducto,
                    item.oCategoria.DescripcionCategoria,
                    item.StockProducto,
                });
            }
        }

        private void dgvData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;
            if(iRow >= 0 && iColum > 0)
            {
                Produc = new Producto()
                {
                    Id_Producto = Convert.ToInt32(dgvData.Rows[iRow].Cells["Id"].Value.ToString()),
                    CodigoProducto = dgvData.Rows[iRow].Cells["Codigo"].Value.ToString(),
                    NombreProducto = dgvData.Rows[iRow].Cells["Nombre"].Value.ToString(),
                    StockProducto = Convert.ToInt32(dgvData.Rows[iRow].Cells["Stock"].Value.ToString()),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            } 
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string columnaflitro = ((OpcionCombo)Combo_Search.SelectedItem).Valor.ToString();

            if (dgvData.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Cells[columnaflitro].Value.ToString().Trim().ToUpper().Contains(txt_Search.Text.Trim().ToUpper()))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_Search.Text = "";
            foreach (DataGridViewRow row in dgvData.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
