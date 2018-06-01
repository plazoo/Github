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
    
    public partial class LIQUIDACION_COMPRA_CAB
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LIQUIDACION_COMPRA_CAB()
        {
            this.LIQUIDACION_COMPRA_DET = new HashSet<LIQUIDACION_COMPRA_DET>();
        }
    
        public int IdLiquidacion { get; set; }
        public int IdLocal { get; set; }
        public string TipoLiquidacion { get; set; }
        public int CodigoLiquidacion { get; set; }
        public int IdCliente { get; set; }
        public Nullable<int> IdContactoCliente { get; set; }
        public int IdTipoCafe { get; set; }
        public int Cosecha { get; set; }
        public System.DateTime FechaLiquidacion { get; set; }
        public string IdGuiaIngreso { get; set; }
        public string DescGuiaIngreso { get; set; }
        public string IdContratoCompra { get; set; }
        public string DescContratoCompra { get; set; }
        public decimal TotalSacoGi { get; set; }
        public decimal TotalKgNetoGi { get; set; }
        public decimal TotalSacoCc { get; set; }
        public decimal TotalKgNetoCc { get; set; }
        public decimal DiferenciaSaco { get; set; }
        public decimal DiferenciaKg { get; set; }
        public decimal Precio { get; set; }
        public Nullable<decimal> KgBase { get; set; }
        public int IdEstado { get; set; }
        public string UsuarioRegistra { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public string UsuarioModifica { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public string FacturaSerie { get; set; }
        public string FacturaNumero { get; set; }
        public string FacturaFecha { get; set; }
        public string SerieDocumento { get; set; }
        public string NroDocumento { get; set; }
        public Nullable<System.DateTime> FechaAsignacionPrecio { get; set; }
        public string UsuarioAsignacionPrecio { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIQUIDACION_COMPRA_DET> LIQUIDACION_COMPRA_DET { get; set; }
    }
}
