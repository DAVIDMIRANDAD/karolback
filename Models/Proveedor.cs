using System;
using System.Collections.Generic;

namespace RestauranteKarol.Models
{
    public partial class Proveedor
    {
        public Proveedor()
        {
          
        }

        public int IdProveedor { get; set; }
        public string NomProveedor { get; set; } = null!;
        public string Nit { get; set; } = null!;
        public string CorreoProveedor { get; set; } = null!;
        public string TelProveedor { get; set; } = null!;
        public string DirProveedor { get; set; } = null!;
        public int IdProducto { get; set; }   
    }
}
