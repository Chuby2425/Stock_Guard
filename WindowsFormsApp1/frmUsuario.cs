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
using Capa_entidad;
using Capa_negocio;
using System.Windows.Media;
using System.Windows.Markup;


namespace WindowsFormsApp1
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        //metodo de carga
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            // Configuración del ComboBox para el estado
            Combo_State.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            Combo_State.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No Activo" });
            Combo_State.DisplayMember = "Texto";
            Combo_State.ValueMember = "Valor";
            Combo_State.SelectedIndex = 0;


            // Configuración del ComboBox para el rol
            List<Rol> listaRol = new CN_Rol().listar();
            foreach (Rol item in listaRol)
            {
                Combo_Rol.Items.Add(new OpcionCombo() { Valor = item.Id_Rol, Texto = item.DescripcionRol });
            }
            Combo_Rol.DisplayMember = "Texto";
            Combo_Rol.ValueMember = "Valor";
            Combo_Rol.SelectedIndex = 0;

            foreach(DataGridViewColumn columna in dgvData.Columns)
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
            List<Usuario> listaUsuario = new CN_Usuario().listar();
            foreach (Usuario item in listaUsuario)
            {
                dgvData.Rows.Add(new object[] {"",item.Id_Usuario,item.NombreUsuario,item.ContrasennaUsuario,item.CorreoUsuario,
                item.oRolU.Id_Rol,
                item.oRolU.DescripcionRol,
                item.EstadoUsuario == true ? 1 : 0,
                item.EstadoUsuario == true ? "Activo" : "No Activo"
                });
            }

            Combo_Rol.DisplayMember = "Texto";
            Combo_Rol.ValueMember = "Valor";
            Combo_Rol.SelectedIndex = 0;

        }

        private void lbl_Mail_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Rol_Click(object sender, EventArgs e)
        {

        }

        private void Combo_Rol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            Usuario objusuario = new Usuario()
            {
                Id_Usuario = Convert.ToInt32(txt_Id.Text),
                NombreUsuario = txt_Name.Text,
                ContrasennaUsuario = txt_Password.Text,
                CorreoUsuario = txt_Mail.Text,
                oRolU = new Rol() { Id_Rol = Convert.ToInt32(((OpcionCombo)Combo_Rol.SelectedItem).Valor)},
                EstadoUsuario = Convert.ToInt32(((OpcionCombo)Combo_State.SelectedItem).Valor) == 1? true: false,
            }; 

            if(objusuario.Id_Usuario == 0)
            {
                int idusuariogenerado = new CN_Usuario().Registrar(objusuario, out mensaje);

                if (idusuariogenerado != 0)
                {
                    dgvData.Rows.Add(new object[] {"",idusuariogenerado,txt_Name.Text,txt_Password.Text,txt_Mail.Text,
                ((OpcionCombo)Combo_Rol.SelectedItem).Valor.ToString(),
                ((OpcionCombo)Combo_Rol.SelectedItem).Texto.ToString(),
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
                bool resultado = new CN_Usuario().Editar(objusuario, out mensaje);
                if (resultado)
                {
                    DataGridViewRow row = dgvData.Rows[Convert.ToInt32(txt_Indice.Text)];
                    row.Cells["Id"].Value = txt_Id.Text;
                    row.Cells["NombreUsuario"].Value = txt_Name.Text;
                    row.Cells["ContrasennaUsuario"].Value = txt_Password.Text;
                    row.Cells["CorreoUsuario"].Value = txt_Mail.Text;
                    row.Cells["Id_Rol"].Value = ((OpcionCombo)Combo_Rol.SelectedItem).Valor.ToString();
                    row.Cells["EstadoRol"].Value = ((OpcionCombo)Combo_Rol.SelectedItem).Texto.ToString();
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

        //Meotodo de limpieza
        private void Limpiar()
        {
            txt_Indice.Text = "-1";
            txt_Id.Text = "0";
            txt_Name.Text = "";
            txt_Mail.Text = "";
            txt_Password.Text = "";
            txt_Cpassword.Text = "";
            Combo_Rol.SelectedIndex = 0;
            Combo_State.SelectedIndex = 0;

            txt_Name.Select();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        //con esto lo que hacemos es mostrar la imagen que tenemos la lista el check 
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

        private void AjustarTamanoColumnas()
        {
        }
        //con esto lo que hacemos es que mostramos lo que seleciono con el boton de DataGridView a los text box
        private void dgvData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.Columns[e.ColumnIndex].Name == "btn_Select")
            {
                int indice = e.RowIndex;
                if (indice >=0)
                {
                    txt_Indice.Text = indice.ToString();
                    txt_Id.Text = dgvData.Rows[indice].Cells["Id"].Value.ToString();
                    txt_Name.Text = dgvData.Rows[indice].Cells["NombreUsuario"].Value.ToString();
                    txt_Password.Text = dgvData.Rows[indice].Cells["ContrasennaUsuario"].Value.ToString();
                    txt_Mail.Text = dgvData.Rows[indice].Cells["CorreoUsuario"].Value.ToString();
                    txt_Cpassword.Text = dgvData.Rows[indice].Cells["ContrasennaUsuario"].Value.ToString();

                    foreach(OpcionCombo oc in Combo_Rol.Items)
                    {
                        if(Convert.ToInt32(oc.Valor) == Convert.ToInt32(dgvData.Rows[indice].Cells["Id_Rol"].Value))
                        {
                            int indice_combo = Combo_Rol.Items.IndexOf(oc);
                            Combo_Rol.SelectedIndex = indice_combo;

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
            if (MessageBox.Show("¿Desea eliminar el usuasrio?","Mensaje",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    string mensaje = string.Empty;
                    Usuario objusuario = new Usuario()
                    {
                        Id_Usuario = Convert.ToInt32(txt_Id.Text)
                    };

                    bool resouesta = new CN_Usuario().Eliminar(objusuario, out mensaje);

                    if (resouesta)
                    {
                        dgvData.Rows.RemoveAt(Convert.ToInt32(txt_Indice.Text));
                    }
                    else
                    {
                        MessageBox.Show(mensaje,"Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}