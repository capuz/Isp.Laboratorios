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
    
    public partial class MotivoRechazoPorLaboratorio
    {
        public int Id { get; set; }
        public int MotivoRechazoId { get; set; }
        public int LaboratorioId { get; set; }
        public Nullable<int> Orden { get; set; }
    
        public virtual Laboratorio Laboratorio { get; set; }
        public virtual MotivoRechazo MotivoRechazo { get; set; }
    }
}
