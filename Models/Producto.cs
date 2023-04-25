using System;
using System.Collections.Generic;

namespace RestauranteKarol.Models
{
    public partial class Producto
    {
        public Producto()
        {
           
            
        }

        public int IdProducto { get; set; }
        public string NomProducto { get; set; } = null!;
        public string Categoria { get; set; } = null!;
        public DateTime? FechaFabricacion { get; set; }
        public DateTime? FechaVencimiento { get; set; }

        
        
    }
}
