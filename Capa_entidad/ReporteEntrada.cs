﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_entidad
{
    public class ReporteEntrada
    {
        public string FechaRegistro { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string UsuarioRegistro { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string Categoria { get; set; }
        public string Cantidad { get; set; }
    }
}
