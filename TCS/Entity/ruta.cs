//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCS.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class ruta
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ruta()
        {
            this.rutapunto = new HashSet<rutapunto>();
            this.viaje = new HashSet<viaje>();
        }
    
        public int RutaID { get; set; }
        public string NombreRuta { get; set; }
        public Nullable<int> IDPuntoOrigen { get; set; }
        public Nullable<int> IDPuntoDestino { get; set; }
    
        public virtual punto punto { get; set; }
        public virtual punto punto1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rutapunto> rutapunto { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<viaje> viaje { get; set; }
    }
}
