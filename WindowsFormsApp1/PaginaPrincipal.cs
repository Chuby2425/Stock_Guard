using Capa_entidad;
using Capa_negocio;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PaginaPrincipal : Form
    {


        private static Usuario usuarioactual;
        private static IconMenuItem MenuActivo = null;
        private static Form FormularioActivo = null;
        public PaginaPrincipal(Usuario objusuario)
        {
            usuarioactual = objusuario;
            InitializeComponent();
        }

        private void Menu_Title_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void iconSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {
            List<Permisos> listaPermiso = new CN_Permiso().listar(usuarioactual.Id_Usuario);

            foreach (IconMenuItem iconMenu in LeftBar_Button.Items)
            {
                bool encontrado = listaPermiso.Any(m => m.NombreMenuPermiso == iconMenu.Name);

                if (encontrado == false)
                {
                    iconMenu.Visible = false;
                }
            }
            //Revisar porque no me muestra ventas 

            lblUsuario.Text = usuarioactual.NombreUsuario;
        }

        private void label1_Click(object sender, EventArgs e)
        {




        }

        //Con esto l oque hacemos es abrir el formulario sobre el contenedor se controla los colores de backcolor
        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            if (MenuActivo != null)
            {
                MenuActivo.BackColor = Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(43)))), ((int)(((byte)(58)))));
            }
            menu.BackColor = Color.SteelBlue;
            MenuActivo = menu;

            if (FormularioActivo != null)
            {
                FormularioActivo.Close();
            }
            FormularioActivo = formulario;
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            formulario.BackColor = Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(219)))), ((int)(((byte)(247)))));

            Contenedor.Controls.Add(formulario);
            formulario.Show();


        }

        private void iconMenuItem6_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new frmUsuario());
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new Acercade());
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_Mantenimiento_Click(object sender, EventArgs e)
        {

        }

        private void btn_Categoria_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantenimientos, new frmCategoria());
        }

        private void btn_Producto_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuMantenimientos, new frmProducto());
        }

        private void MenuVentas_Click(object sender, EventArgs e)
        {

        }

        private void btn_RVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuVentas, new frmRSalidas(usuarioactual));
        }

        private void btn_RCompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuCompras, new frmREntrada(usuarioactual));
        }

        private void btn_Detcompras_Click(object sender, EventArgs e)
        {
            AbrirFormulario(MenuCompras, new frmDetalleEntradas());
        }

        private void btn_DetVentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuVentas, new frmDetalleSalidas());
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {

        }

        private void reporteDeComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuReportes, new frmReporteEntrada());

        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(menuReportes, new frmReporteSalidas());
        }

        private void menuReportes_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
