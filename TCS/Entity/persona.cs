//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TCS.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public persona()
        {
            this.personarols = new HashSet<personarol>();
            this.viajes = new HashSet<viaje>();
        }
    
        public int PersonaID { get; set; }
        public string NombrePersona { get; set; }
        public string Licencia { get; set; }
        public Nullable<int> UsuarioID { get; set; }
    
        public virtual usuario usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<personarol> personarols { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<viaje> viajes { get; set; }
    }
}
