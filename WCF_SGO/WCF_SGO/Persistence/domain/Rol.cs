//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Persistence.domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rol
    {
        public int IdRol { get; set; }
        public string vDescripcion { get; set; }
        public int nEstado { get; set; }
        public Nullable<int> IdRolPadre { get; set; }
        public Nullable<int> IdSistema { get; set; }
    }
}
