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
    
    public partial class Paciente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Paciente()
        {
            this.Muestras = new HashSet<Muestra>();
        }
    
        public int Id { get; set; }
        public string Rut { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public Nullable<System.DateTime> FechaNacimiento { get; set; }
        public string Sexo { get; set; }
        public Nullable<int> EdadDia { get; set; }
        public Nullable<int> EdadMes { get; set; }
        public Nullable<int> EdadAnno { get; set; }
        public string Correo { get; set; }
        public string Observacion { get; set; }
        public string Direccion { get; set; }
        public int NacionalidadId { get; set; }
        public int PrevisionId { get; set; }
        public string ComunaId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Muestra> Muestras { get; set; }
    }
}