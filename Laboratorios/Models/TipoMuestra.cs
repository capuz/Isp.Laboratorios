//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Isp.Laboratorios.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TipoMuestra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoMuestra()
        {
            this.Muestras = new HashSet<Muestra>();
            this.TiposMuestraPorPrestaciones = new HashSet<TipoMuestraPorPrestacion>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Activo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Muestra> Muestras { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoMuestraPorPrestacion> TiposMuestraPorPrestaciones { get; set; }
    }
}