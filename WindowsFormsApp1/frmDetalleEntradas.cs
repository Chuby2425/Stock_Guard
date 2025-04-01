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
    public partial class frmDetalleEntradas : Form
    {
        public frmDetalleEntradas()
        {
            InitializeComponent();
        }

        private void lbl_Search_Click(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Entrada oEntrada = new CN_Entrada().obtenerEntrada(txt_Search.Text);

            if (oEntrada.Id_Entrada != 0) 
            {
                txt_NumeroDocumento.Text = oEntrada.NumeroFactura;

                txtFecha.Text = oEntrada.FechaEntrada.ToString("yyyy-MM-dd");
                txtTipo_Documento.Text = oEntrada.TipoDocumento;
                txt_Usuario.Text = oEntrada.oUsuarioE.NombreUsuario;

                dgvData.Rows.Clear();
                foreach(Detalle_Entrada dc in oEntrada.oDetalleEntradaE)
                {
                    dgvData.Rows.Add(new object[] {"", dc.oProductoDE.NombreProducto, dc.CantidadDetalleEntrada });
                }
               

            }
        }

        private void frmDetalleEntradas_Load(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txtFecha.Text = "";
            txtTipo_Documento.Text = "";
            txt_Usuario.Text = "";
            dgvData.Rows.Clear();
        }
    }
}
