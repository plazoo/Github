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
    
    public partial class LIQUIDACION_COMPRA_DET
    {
        public int IdLiquidacionDetalle { get; set; }
        public int IdLiquidacion { get; set; }
        public int IdDocumento { get; set; }
        public string TipoDocumento { get; set; }
        public int IdEstado { get; set; }
    }
}
