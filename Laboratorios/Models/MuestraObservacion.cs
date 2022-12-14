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
    
    public partial class MuestraObservacion
    {
        public int Id { get; set; }
        public int MuestraId { get; set; }
        public int TipoObservacionId { get; set; }
        public int UsuarioId { get; set; }
        public System.DateTime Fecha { get; set; }
        public Nullable<int> UsuarioIdCierre { get; set; }
        public Nullable<System.DateTime> FechaCierre { get; set; }
        public string Observacion { get; set; }
        public int EstadoIncidenteId { get; set; }
    
        public virtual TipoObservacion TipoObservacion { get; set; }
        public virtual Muestra Muestra { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario UsuarioCierre { get; set; }
        public virtual EstadoIncidente EstadosIncidentes { get; set; }
    }
}
