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
    
    public partial class rutapunto
    {
        public int RutaPuntoID { get; set; }
        public Nullable<int> RutaID { get; set; }
        public Nullable<int> PuntoID { get; set; }
    
        public virtual ruta ruta { get; set; }
    }
}
