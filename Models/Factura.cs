using System;
using System.Collections.Generic;

namespace RestauranteKarol.Models
{
    public partial class Factura
    {
        public Factura()
        {
            
        }

        public int IdFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public int Cantidad { get; set; }
        public int Valor { get; set; }
        public int Total { get; set; }
        public string FormaPago { get; set; } = null!;
        public string EstadoFactura { get; set; } = null!;
               
    }
}
