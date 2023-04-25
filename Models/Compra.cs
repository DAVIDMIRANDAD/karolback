using System;
using System.Collections.Generic;

namespace RestauranteKarol.Models
{
    public partial class Compra
    {
        public int IdCompras { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaDespacho { get; set; }
        public string TipoCompra { get; set; } = null!;
    }
}
