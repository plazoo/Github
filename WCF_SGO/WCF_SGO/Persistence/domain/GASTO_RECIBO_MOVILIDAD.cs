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
    
    public partial class GASTO_RECIBO_MOVILIDAD
    {
        public int IdGastoPRPDetRM { get; set; }
        public string IdLocal { get; set; }
        public string IdCodigoInternoRM { get; set; }
        public Nullable<int> IdGasto_PRPRM { get; set; }
        public Nullable<int> IdTipoDocumentoRM { get; set; }
        public Nullable<int> IdTipoOperacionRM { get; set; }
        public Nullable<int> IdCatalogoCuentaContableRM { get; set; }
        public Nullable<int> IdGastoCentroCostoRM { get; set; }
        public Nullable<System.DateTime> DocumentoFechaRM { get; set; }
        public string DocumentoSerieRM { get; set; }
        public string DocumentoNumeroRM { get; set; }
        public string RUCRM { get; set; }
        public string ProveedorRM { get; set; }
        public string DescripcionRM { get; set; }
        public string IdMonedaRM { get; set; }
        public Nullable<decimal> BaseImponibleRM { get; set; }
        public Nullable<decimal> ImpuestoIGVRM { get; set; }
        public Nullable<decimal> InafectosRM { get; set; }
        public Nullable<decimal> MontoRedondeoRM { get; set; }
        public Nullable<decimal> MontoTotalRM { get; set; }
        public Nullable<int> IdEstado { get; set; }
        public Nullable<System.DateTime> FechaRegistra { get; set; }
        public Nullable<int> UsuarioRegistra { get; set; }
        public Nullable<System.DateTime> FechaActualiza { get; set; }
        public Nullable<int> UsuarioActualiza { get; set; }
        public Nullable<int> inMovilidadNacional { get; set; }
    }
}
