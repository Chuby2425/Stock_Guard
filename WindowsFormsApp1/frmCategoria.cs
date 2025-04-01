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
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            // Configuración del ComboBox para el estado
            Combo_State.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            Combo_State.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            Combo_State.DisplayMember = "Texto";
            Combo_State.ValueMember = "Valor";
            Combo_State.SelectedIndex = 0;


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
            List<Categoria> lista = new CN_Categoria().listar();
            foreach (Categoria item in lista)
            {
                dgvData.Rows.Add(new object[] {"",item.Id_Categoria,
                item.DescripcionCategoria,
                item.EstadoCategoria == true ? 1 : 0,
                item.EstadoCategoria == true ? "Activo" : "No Activo"
                });
            }
        }

        //Meotodo de limpieza
        private void Limpiar()
        {
            txt_Indice.Text = "-1";
            txt_Id.Text = "0";
            txt_Descripcion.Text = "";
            Combo_State.SelectedIndex = 0;

            txt_Descripcion.Select();
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
                    e.Graphics.DrawImage(Properties.Resources.check_mark, new Rectangle(x, y, iconWidth, iconHeight));
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
                    txt_Descripcion.Text = dgvData.Rows[indice].Cells["Descripcion"].Value.ToString();

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
                if (MessageBox.Show("¿Desea eliminar la categoria?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Categoria obj = new Categoria()
                    {
                        Id_Categoria = Convert.ToInt32(txt_Id.Text)
                    };

                    bool resouesta = new CN_Categoria().Eliminar(obj, out mensaje);

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
    

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Categoria obj = new Categoria()
            {
                Id_Categoria = Convert.ToInt32(txt_Id.Text),
                DescripcionCategoria= txt_Descripcion.Text,
                EstadoCategoria = Convert.ToInt32(((OpcionCombo)Combo_State.SelectedItem).Valor) == 1 ? true : false,
            };

            if  (obj.Id_Categoria== 0)
            {
                int idgenerado = new CN_Categoria().Registrar(obj, out mensaje);

                if (idgenerado != 0)
                {
                    dgvData.Rows.Add(new object[] {"",idgenerado,txt_Descripcion.Text,
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
                bool resultado = new CN_Categoria().Editar(obj, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txt_Indice.Text)];
                    row.Cells["Id"].Value = txt_Id.Text;
                    row.Cells["Descripcion"].Value = txt_Descripcion.Text;
                    row.Cells["EstadoValor"].Value = ((OpcionCombo)Combo_State.SelectedItem).Valor.ToString();
                    row.Cells["Estado"].Value = ((OpcionCombo)Combo_State.SelectedItem).Texto.ToString();
                    
                    Limpiar();
                }
                else
                {
                    MessageBox.Show(mensaje);
                }
            }
        }
    }
}

