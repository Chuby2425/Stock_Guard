using Capa_entidad;
using Capa_negocio;
using ClosedXML.Excel;
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
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void lbl_Tittle_Click(object sender, EventArgs e)
        {

        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            // Configuración del ComboBox para el estado
            Combo_State.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            Combo_State.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            Combo_State.DisplayMember = "Texto";
            Combo_State.ValueMember = "Valor";
            Combo_State.SelectedIndex = 0;


            // Configuración del ComboBox para el rol
            List<Categoria> listaCategoria = new CN_Categoria().listar();
            foreach (Categoria item in listaCategoria)
            {
                Combo_Categoria.Items.Add(new OpcionCombo() { Valor = item.Id_Categoria, Texto = item.DescripcionCategoria });
            }
            Combo_Categoria.DisplayMember = "Texto";
            Combo_Categoria.ValueMember = "Valor";
            Combo_Categoria.SelectedIndex = 0;

            foreach (DataGridViewColumn columna in dgvData.Columns)
            {
                if (columna.Visible == true && columna.Name != "btn_Select")
                {
                    Combo_Search.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText });
                }
            }
            Combo_Search.DisplayMember = "Texto";
            Combo_Search.ValueMember = "Valor";
            Combo_Search.SelectedIndex = 0;


            //Con esto se muestran los usuarios en la tabla
            List<Producto> lista = new CN_Producto().listar();
            foreach (Producto item in lista)
            {
                dgvData.Rows.Add(new object[] {
                    "",
                    item.Id_Producto,
                    item.CodigoProducto,
                    item.NombreProducto,
                    item.DescripcionProducto,
                    item.oCategoria.Id_Categoria,
                    item.oCategoria.DescripcionCategoria,
                    item.StockProducto,
                    item.EstadoProducto == true ? 1 : 0,
                    item.EstadoProducto == true ? "Activo" : "No Activo"
                });
            }
        }

        private void btn__Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Producto obj = new Producto()
            { 
                Id_Producto = Convert.ToInt32(txt_Id.Text),
                CodigoProducto = txt_Codigo.Text,
                NombreProducto = txt_Nombre.Text,
                DescripcionProducto = txt_Descripcion.Text,
                oCategoria = new Categoria() { Id_Categoria = Convert.ToInt32(((OpcionCombo)Combo_Categoria.SelectedItem).Valor) },
                EstadoProducto = Convert.ToInt32(((OpcionCombo)Combo_State.SelectedItem).Valor) == 1 ? true : false,
            };

            if (obj.Id_Producto == 0)
            {
                int idgenerado = new CN_Producto().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {
                    dgvData.Rows.Add(new object[]
                    {
                        "",
                        idgenerado,
                        txt_Codigo.Text,
                        txt_Nombre.Text,
                        txt_Descripcion.Text,
                        ((OpcionCombo)Combo_Categoria.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)Combo_Categoria.SelectedItem).Texto.ToString(),
                        "0",
                        ((OpcionCombo)Combo_State.SelectedItem).Valor.ToString(),
                        ((OpcionCombo)Combo_State.SelectedItem).Texto.ToString(),
                });

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
            else
            {
                bool resultado = new CN_Producto().Editar(obj, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txt_Indice.Text)];
                    row.Cells["Id"].Value = txt_Id.Text;
                    row.Cells["Codigo"].Value = txt_Codigo.Text;
                    row.Cells["Nombre"].Value = txt_Nombre.Text;
                    row.Cells["Descripcion"].Value = txt_Descripcion.Text;
                    row.Cells["IdCategoria"].Value = ((OpcionCombo)Combo_Categoria.SelectedItem).Valor.ToString();
                    row.Cells["Categoria"].Value = ((OpcionCombo)Combo_Categoria.SelectedItem).Texto.ToString();
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)Combo_State.SelectedItem).Valor.ToString();
                    row.Cells["EstadoUsuario"].Value = ((OpcionCombo)Combo_State.SelectedItem).Texto.ToString();

                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }


        private void Limpiar()
        {
            txt_Indice.Text = "-1";
            txt_Id.Text = "0";
            txt_Codigo.Text = "";
            txt_Nombre.Text = "";
            txt_Descripcion.Text = "";
            Combo_Categoria.SelectedIndex = 0;
            Combo_State.SelectedIndex = 0;

            txt_Codigo.Select();
        }

        private void dgvData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 0)
            {
                if (e.RowIndex < 0)
                    return;

                if (e.ColumnIndex == 0) // Columna del checkmark
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    // Definir el tamaño de la imagen
                    int iconWidth = 20;  // Ancho de la imagen
                    int iconHeight = 20; // Altura de la imagen

                    // Calcular la posición para centrar la imagen
                    int x = e.CellBounds.Left + (e.CellBounds.Width - iconWidth) / 2;
                    int y = e.CellBounds.Top + (e.CellBounds.Height - iconHeight) / 2;

                    // Dibujar la imagen dentro de la celda
                    e.Graphics.DrawImage(Properties.Resources.check, new Rectangle(x, y, iconWidth, iconHeight));
                    e.Handled = true;

                }
            }
        }

        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btn_Select")
            {
                int indice = e.RowIndex;
                if (indice >= 0)
                {
                    txt_Indice.Text = indice.ToString();
                    txt_Id.Text = dgvData.Rows[indice].Cells["Id"].Value.ToString();
                    txt_Codigo.Text = dgvData.Rows[indice].Cells["Codigo"].Value.ToString();
                    txt_Nombre.Text = dgvData.Rows[indice].Cells["Nombre"].Value.ToString();
                    txt_Descripcion.Text = dgvData.Rows[indice].Cells["Descripcion"].Value.ToString();

                    foreach (OpcionCombo oc in Combo_Categoria.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["IdCategoria"].Value))
                        {
                            int indice_combo = Combo_Categoria.Items.IndexOf(oc);
                            Combo_Categoria.SelectedIndex = indice_combo;

                        }
                    }

                    foreach (OpcionCombo oc in Combo_State.Items)
                    {
                        if (Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["EstadoValor"].Value))
                        {
                            int indice_combo = Combo_State.Items.IndexOf(oc);
                            Combo_State.SelectedIndex = indice_combo;
                            break;
                        }
                    }
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_Id.Text) != 0)
            {
                if (MessageBox.Show("¿Desea eliminar el Producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Producto obj = new Producto()
                    {
                        Id_Producto = Convert.ToInt32(txt_Id.Text)
                    };

                    bool resouesta = new CN_Producto().Eliminar(obj, out mensaje);

                    if (resouesta)
                    {
                        dgvData.Rows.RemoveAt(Convert.ToInt32(txt_Indice.Text));
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
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

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        //Con esto se hace lo de descarga del documento 
        private void btn_download_Click(object sender, EventArgs e)
        {
            if (dgvData.Rows.Count < 1)
            {
                MessageBox.Show("No existen datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn columna in dgvData.Columns)
                {
                    if (columna.HeaderText != "" && columna.Visible)
                        dt.Columns.Add(columna.HeaderText, typeof(string));
                }

                foreach (DataGridViewRow row in dgvData.Rows)
                {
                    if (row.Visible)
                        dt.Rows.Add(new object[]
                        {
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                        });
                }
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.FileName = string.Format("ReporteProducto_{0}.xlsx",DateTime.Now.ToString("ddMMyyyyHHmmss"));
                saveFile.Filter = "Excel Files | *.xlsx";

                if (saveFile.ShowDialog() == DialogResult.OK) 
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(saveFile.FileName);
                        MessageBox.Show(" Reporte generado ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show(" Error al generar reporte ", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }
    }
}
