using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_negocio;
using Capa_entidad;
using System.Diagnostics.Eventing.Reader;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtb_pasword_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Ingresar_Click(object sender, EventArgs e)
        {
            //esto es para testear 
            List<Usuario> TEST = new CN_Usuario().listar();

            Usuario oUsuario = new CN_Usuario().listar().Where(u => u.NombreUsuario == txtb_id.Text &&
                u.ContrasennaUsuario == txt_pasword.Text).FirstOrDefault();



            if (oUsuario != null)
            {

               PaginaPrincipal form = new PaginaPrincipal(oUsuario);
                //con esto mostramos y cerramos el formulario de pagina de inicio 
                form.Show();
                this.Hide();
                form.FormClosing += frm_closing;

            }
            else
            {
                MessageBox.Show("El usuario no es correcto","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        /* esto es donde se creo el evento pata poder hacer que se vuelva a mostrar
           cuando se cierra la ventana de login*/

        private void frm_closing(object sender, FormClosingEventArgs e) {


            /* con esto lo que hacemos es que se limpie el texto cada ves que salimos
             del login */
            txtb_id.Text = "";
            txt_pasword.Text = "";
            this.Show();
        }
        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
