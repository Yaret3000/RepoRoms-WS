//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RepoRomsWS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rom
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string sinopsis { get; set; }
        public byte[] cover { get; set; }
        public System.DateTime fecha { get; set; }
        public string video { get; set; }
        public int consolaId { get; set; }
    
        public virtual Consola Consola { get; set; }
    }
}
