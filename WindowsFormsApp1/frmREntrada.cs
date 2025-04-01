using Capa_entidad;
using Capa_negocio;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Modales;
using WindowsFormsApp1.Utilidades;

namespace WindowsFormsApp1
{
    public partial class frmREntrada : Form
    {


        private Usuario _Usuario;
        public frmREntrada(Usuario oUsuario = null)
        {
            _Usuario = oUsuario;
            InitializeComponent();
        }


        private void frmREntrada_Load(object sender, EventArgs e)
        {
            // Configuración del ComboBox tipo de documento 
            comboDocumento.Items.Add(new OpcionCombo() { Valor = "Boleta", Texto = "Boleta" });
            comboDocumento.Items.Add(new OpcionCombo() { Valor = "Factura", Texto = "Factura" });
            comboDocumento.DisplayMember = "Texto";
            comboDocumento.ValueMember = "Valor";
            comboDocumento.SelectedIndex = 0;


            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtid.Text = "0";
        }

        private void comboDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            using (var modal = new MdProductos())
            {
                var result = modal.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txtid.Text = modal.Produc.Id_Producto.ToString();
                    txtCodigo.Text = modal.Produc.CodigoProducto;
                    txtProducto.Text = modal.Produc.NombreProducto;
                }
                else
                {
                    txtCodigo.Select();
                }
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            //revisar en minuto 5:54
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new CN_Producto().listar().Where(p => p.CodigoProducto == txtCodigo.Text && p.EstadoProducto == true).FirstOrDefault();
                if(oProducto != null)
                {
                    txtCodigo.BackColor = Color.Honeydew;
                    txtid.Text = oProducto.Id_Producto.ToString();
                    txtProducto.Text = oProducto.NombreProducto;
                }
                else
                {
                    txtCodigo.BackColor = Color.MistyRose;
                    txtid.Text = "0";
                    txtProducto.Text = "";
                }
            }
        }



        private void btn_add_Click(object sender, EventArgs e)
        {
            bool producto_existe = false;


            if (int.Parse(txtid.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            foreach (DataGridViewRow fila in dgvData.Rows) 
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtid.Text)
                {
                    producto_existe = true;
                    break;
                }
            }
            if (!producto_existe) 
            {
                dgvData.Rows.Add(new object[]
                {
                    txtid.Text,
                    txtProducto.Text,
                    txtcantidad.Value.ToString(),
                });
                Limpiar();
                txtCodigo.Select();
            }
        }
        private void Limpiar()
        {
            txtid.Text = "0";
            txtCodigo.Text = "";
            txtCodigo.BackColor = Color.White;
            txtProducto.Text = "";
            txtcantidad.Value = 1;
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return; // Evita que se dibuje en los encabezados.

            // Asegúrate de que estás pintando la columna correcta
            int columnaBorrar = 3; // Cambia esto según el índice correcto en tu DataGridView

            if (e.ColumnIndex == columnaBorrar) // Columna del checkmark (ícono borrar)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                // Definir el tamaño de la imagen
                int iconWidth = 25;  // Ancho de la imagen
                int iconHeight = 25; // Altura de la imagen

                // Calcular la posición para centrar la imagen
                int x = e.CellBounds.Left + (e.CellBounds.Width - iconWidth) / 3;
                int y = e.CellBounds.Top + (e.CellBounds.Height - iconHeight) / 3;

                // Dibujar la imagen dentro de la celda
                e.Graphics.DrawImage(Properties.Resources.borrar, new System.Drawing.Rectangle(x, y, iconWidth, iconHeight));

                e.Handled = true;
            }

        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "BotonELIMINAR")
            {
                int indice = e.RowIndex;
                if(indice >= 0)
                {
                    dgvData.Rows.RemoveAt(indice);
                }
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1) 
            {
                MessageBox.Show("Debe ingresar productos","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            DataTable Detalle_Entrada = new DataTable();

            Detalle_Entrada.Columns.Add("Id_ProductoDetalleEntrada", typeof(int));
            Detalle_Entrada.Columns.Add("CantidadDetalleEntrada", typeof(int));

            foreach (DataGridViewRow row in dgvData.Rows) 
            {
                Detalle_Entrada.Rows.Add
                (
                    new object[]
                    {
                        row.Cells["IdProducto"].Value.ToString(),
                        row.Cells["Cantidad"].Value.ToString()
                    }
                );
            }
            /*int idcorrelativo = new CN_Entrada().ObtenerCorrelativo();
            string NumeroFactura = string.Format("{0:00000}",idcorrelativo);*/
            int idcorrelativo = new CN_Entrada().ObtenerCorrelativo();
            string NumeroFactura = idcorrelativo.ToString().PadLeft(5, '0');


            Entrada oentrada = new Entrada()
            {
                oUsuarioE = new Usuario() { Id_Usuario = _Usuario.Id_Usuario },
                TipoDocumento = ((OpcionCombo)comboDocumento.SelectedItem).Texto,
                NumeroFactura = NumeroFactura,
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Entrada().Registrar(oentrada,Detalle_Entrada,out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de entrada gnenerada\n" + NumeroFactura + "\n\n¿Desea copiar al porta papeles?","Mensaje",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(NumeroFactura);
                
                dgvData.Rows.Clear();
            }
            else
            {
                MessageBox.Show(mensaje, "Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
