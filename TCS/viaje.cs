//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCS
{
    using System;
    using System.Collections.Generic;
    
    public partial class viaje
    {
        public int ViajeID { get; set; }
        public Nullable<int> UnidadID { get; set; }
        public Nullable<int> RutaID { get; set; }
        public Nullable<int> PersonaID { get; set; }
        public Nullable<System.DateTime> FechaPartida { get; set; }
        public Nullable<System.DateTime> FechaRegreso { get; set; }
        public string Descripcion { get; set; }
        public string Orden { get; set; }
    
        public virtual persona persona { get; set; }
        public virtual ruta ruta { get; set; }
        public virtual unidad unidad { get; set; }
    }
}
