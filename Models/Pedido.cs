using System;
using System.Collections.Generic;

namespace RestauranteKarol.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            
        }

        public int IdPedido { get; set; }
        public string TipoPedido { get; set; } = null!;
        public DateTime FechaPedido { get; set; }
        public DateTime FechaDespacho { get; set; }
        public string TipoEntrega { get; set; } = null!;
        public int ValorEntrega { get; set; }
        public int IdPersona { get; set; }
    }
}
