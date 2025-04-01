using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class Producto
    {
        public int Id_Producto { get; set; } /// Esta es la Primary key

        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public Categoria oCategoria { get; set; }
        public int StockProducto { get; set; }
        public bool EstadoProducto { get; set; }
        public string CodigoProducto { get; set; }
        public Usuario oUsuario { get; set; }

    }
}
//revisar bien el orden 