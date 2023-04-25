using System;
using System.Collections.Generic;

namespace RestauranteKarol.Models
{
    public partial class PlatilloXfactura
    {
        public int IdPlatilloFactura { get; set; }
        public int IdPlatillo { get; set; }
        public int IdFactura { get; set; }
    }
}
