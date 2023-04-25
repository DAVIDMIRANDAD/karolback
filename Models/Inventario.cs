using System;
using System.Collections.Generic;

namespace RestauranteKarol.Models
{
    public partial class Inventario
    {
        public int IdInventario { get; set; }
        public DateTime FechaIngreso { get; set; }
        public int Existencias { get; set; }
    }
}
