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
using WindowsFormsApp1.Modales;
using WindowsFormsApp1.Utilidades;


namespace WindowsFormsApp1
{
    public partial class frmRSalidas : Form
    {
        private Usuario _Usuario;
        public frmRSalidas(Usuario oUsuario = null)
        {

            if (oUsuario == null)
            {
                MessageBox.Show("Error: Usuario no válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Cierra el formulario si el usuario no es válido
                return;
            }

            _Usuario = oUsuario;
            InitializeComponent();




            /*
            _Usuario = oUsuario;
            InitializeComponent();*/
        }

        private void frmRSalidas_Load(object sender, EventArgs e)
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
                    txtstock.Text = modal.Produc.StockProducto.ToString();
                }
                else
                {
                    txtCodigo.Select();
                }
            }
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyData == Keys.Enter)
            {
                Producto oProducto = new CN_Producto().listar().Where(p => p.CodigoProducto == txtCodigo.Text && p.EstadoProducto == true).FirstOrDefault();
                if (oProducto != null)
                {
                    txtCodigo.BackColor = Color.Honeydew;
                    txtid.Text = oProducto.Id_Producto.ToString();
                    txtProducto.Text = oProducto.NombreProducto;
                    txtstock.Text = oProducto.StockProducto.ToString();
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
            bool producto_existente = false;

            if (int.Parse(txtid.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un producto","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            if (Convert.ToInt32(txtstock.Text) < Convert.ToInt32(numericUpDown1.Value.ToString())) 
            {
                MessageBox.Show("La cantidad no puede ser mayor al stock", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            foreach (DataGridViewRow fila in dgvData.Rows)
            {
                if (fila.Cells["IdProducto"].Value.ToString() == txtid.Text)
                {
                    producto_existente = true;
                    break;
                }
            }

            if (!producto_existente)
            {
              
                bool respuesta = new CN_Salida().RestarStock(
                   //revisar si id o producto 
                   Convert.ToInt32(txtid.Text),
                   Convert.ToInt32(numericUpDown1.Value.ToString())
                );


                if (respuesta)
                {
                    dgvData.Rows.Add(new object[] {

                    txtid.Text,
                    txtProducto.Text,
                    numericUpDown1.Value.ToString(),
                    });

                    Limpiar();
                    txtProducto.Select();
                }
            }
        }
        private void Limpiar()
        {
            txtid.Text = "0";
            txtCodigo.Text = "";
            txtCodigo.BackColor = Color.White;
            txtProducto.Text = "";
            txtstock.Text = "";
            numericUpDown1.Value = 1;
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return; // Evita la fila de encabezados

            int columnaImagen = 3; // Última columna "Cantidad"

            if (e.ColumnIndex == columnaImagen)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All); // Pinta el fondo de la celda

                // Definir el tamaño de la imagen
                int iconWidth = 20;
                int iconHeight = 20;

                // Calcular la posición para centrar la imagen en la celda
                int x = e.CellBounds.Left + (e.CellBounds.Width - iconWidth) / 2;
                int y = e.CellBounds.Top + (e.CellBounds.Height - iconHeight) / 2;

                // Dibujar la imagen dentro de la celda
                e.Graphics.DrawImage(Properties.Resources.borrar, new Rectangle(x, y, iconWidth, iconHeight));

                e.Handled = true; // Indica que la celda ya fue pintada
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "BotonELIMINAR")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    bool respuesta = new CN_Salida().SumarStock(
                        Convert.ToInt32(dgvData.Rows[indice].Cells["IdProducto"].Value.ToString()),
                        Convert.ToInt32(dgvData.Rows[indice].Cells["Cantidad"].Value.ToString()));

                    if (respuesta)
                    {
                        dgvData.Rows.RemoveAt(indice);
                    }
                }
            }
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DataTable detalle_salida = new DataTable();

            detalle_salida.Columns.Add("Id_ProductoDetalleSalida", typeof(int));
            detalle_salida.Columns.Add("CantidadDetalleSalida", typeof(int));

            foreach (DataGridViewRow row in dgvData.Rows)
            {
                detalle_salida.Rows.Add(new object[] {
                    row.Cells["IdProducto"].Value.ToString(),
                    row.Cells["Cantidad"].Value.ToString(),
                });
            }

            int idcorrelativo = new CN_Salida().ObtenerCorrelativo();
            string numeroDocumento = string.Format("{0:00000}", idcorrelativo);

            Salida oVenta = new Salida()
            {

                oUsuarioS = new Usuario() { Id_Usuario = _Usuario.Id_Usuario },
                TipoDocumento = ((OpcionCombo)comboDocumento.SelectedItem).Texto,
                NumeroFactura = numeroDocumento,
            };

            string mensaje = string.Empty;
            bool respuesta = new CN_Salida().Registrar(oVenta, detalle_salida, out mensaje);

            if (respuesta)
            {
                var result = MessageBox.Show("Numero de venta generada:\n" + numeroDocumento + "\n\n¿Desea copiar al portapapeles?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                    Clipboard.SetText(numeroDocumento);

                dgvData.Rows.Clear();
            }
            else
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
