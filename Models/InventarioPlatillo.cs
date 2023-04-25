using System;
using System.Collections.Generic;

namespace RestauranteKarol.Models
{
    public partial class InventarioPlatillo
    {
        public int IdInventarioPlatillo { get; set; }
        public int Cantidad { get; set; }
        public int IdPlatillo { get; set; }
        public int IdProducto { get; set; }
    }
}
