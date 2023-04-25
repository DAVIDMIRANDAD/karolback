using System;
using System.Collections.Generic;

namespace RestauranteKarol.Models
{
    public partial class Egreso
    {
        public int IdEgreso { get; set; }
        public string TipoEgreso { get; set; } = null!;
        public string DescripEgreso { get; set; } = null!;
        public DateTime FechaPago { get; set; }
    }
}
