using System;
using System.Collections.Generic;

namespace RestauranteKarol.Models
{
    public partial class Platillo
    {
        public Platillo()
        {
           
        }

        public int IdPlatillo { get; set; }
        public string NomPlatillo { get; set; } = null!;
        public string TipoPlatillo { get; set; } = null!;
        public string DescripPlat { get; set; } = null!;

    }
}
