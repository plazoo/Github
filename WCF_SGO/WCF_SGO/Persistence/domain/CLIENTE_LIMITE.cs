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
    
    public partial class CLIENTE_LIMITE
    {
        public int IdLimite { get; set; }
        public int IdCliente { get; set; }
        public decimal PorcentajeExtra { get; set; }
        public decimal LimiteCompra { get; set; }
        public int IdEstado { get; set; }
        public string UsuarioRegistro { get; set; }
        public System.DateTime FechaRegistro { get; set; }
    }
}
