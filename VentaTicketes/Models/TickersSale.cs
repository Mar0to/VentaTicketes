//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VentaTicketes.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TickersSale
    {
        public int idRuta { get; set; }
        public int idLugarRuta { get; set; }
        public int idHorario { get; set; }
        public int campo { get; set; }
        public int idTiquete { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
    
        public virtual TicketsHorarios TicketsHorarios { get; set; }
        public virtual TicketsLugares TicketsLugares { get; set; }
        public virtual TicketsRuta TicketsRuta { get; set; }
    }
}