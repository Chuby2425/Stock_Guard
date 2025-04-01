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

namespace WindowsFormsApp1
{
    public partial class frmDetalleSalidas : Form
    {
        public frmDetalleSalidas()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
             Salida oSalida = new CN_Salida().ObtenerVenta(txt_Search.Text);

             if (oSalida.Id_Salida != 0)
             {

                 txt_NumeroDocumento.Text = oSalida.NumeroFactura;

                 txtFecha.Text = oSalida.FechaSalida.ToString("yyyy-MM-dd");
                 txtTipo_Documento.Text = oSalida.TipoDocumento;
                 txt_Usuario.Text = oSalida.oUsuarioS.NombreUsuario;


                 dgvData.Rows.Clear();
                 foreach (Detalle_Salida dv in oSalida.oDetalleSalidaS)
                 {
                     dgvData.Rows.Add(new object[] { "",dv.CantidadDetalleSalida, dv.oProductoDs.NombreProducto });
                 }
            } 
        }

        private void frmDetalleSalidas_Load(object sender, EventArgs e)
        {

        }
    }
}
