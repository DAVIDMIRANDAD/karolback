using System;
using System.Collections.Generic;

namespace RestauranteKarol.Models
{
    public partial class Persona
    {
        public Persona()
        {
       
        }

        public int IdPersona { get; set; }
        public long NumDoc { get; set; }
        public string NomPersona { get; set; } = null!;
        public string ApePersona { get; set; } = null!;
        public long TelPersona { get; set; }
        public string CorreoPersona { get; set; } = null!;
        public string Direccion { get; set; } = null!;

  
    }
}
