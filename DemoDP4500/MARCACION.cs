//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoDP4500
{
    using System;
    using System.Collections.Generic;
    
    public partial class MARCACION
    {
        public int idMarcacion { get; set; }
        public System.TimeSpan horaMarcacion { get; set; }
        public System.DateTime diaMarcacion { get; set; }
        public int idRegistro { get; set; }
        public int tipoMarcacion { get; set; }
    
        public virtual REGISTRO REGISTRO { get; set; }
        public virtual TIPOMARCACION TIPOMARCACION1 { get; set; }
    }
}
