﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleAppTest.ServiceCVenta {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Result", Namespace="http://schemas.datacontract.org/2004/07/Common")]
    [System.SerializableAttribute()]
    public partial class Result : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ExitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FolderNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WeftField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Exit {
            get {
                return this.ExitField;
            }
            set {
                if ((this.ExitField.Equals(value) != true)) {
                    this.ExitField = value;
                    this.RaisePropertyChanged("Exit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FolderName {
            get {
                return this.FolderNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FolderNameField, value) != true)) {
                    this.FolderNameField = value;
                    this.RaisePropertyChanged("FolderName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message {
            get {
                return this.MessageField;
            }
            set {
                if ((object.ReferenceEquals(this.MessageField, value) != true)) {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Weft {
            get {
                return this.WeftField;
            }
            set {
                if ((object.ReferenceEquals(this.WeftField, value) != true)) {
                    this.WeftField = value;
                    this.RaisePropertyChanged("Weft");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ComprobanteCliente", Namespace="http://schemas.datacontract.org/2004/07/Persistence.domain")]
    [System.SerializableAttribute()]
    public partial class ComprobanteCliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CorrelativoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FechaOperacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdComprobanteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> ImporteSubtotalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> ImporteTotalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> ImpuestoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string InvoiceStateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreArhivoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RAZONSOCIAL_PRODELSURField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RUC_PRODELSURField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TipoMonedaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Correlativo {
            get {
                return this.CorrelativoField;
            }
            set {
                if ((object.ReferenceEquals(this.CorrelativoField, value) != true)) {
                    this.CorrelativoField = value;
                    this.RaisePropertyChanged("Correlativo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FechaOperacion {
            get {
                return this.FechaOperacionField;
            }
            set {
                if ((object.ReferenceEquals(this.FechaOperacionField, value) != true)) {
                    this.FechaOperacionField = value;
                    this.RaisePropertyChanged("FechaOperacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdComprobante {
            get {
                return this.IdComprobanteField;
            }
            set {
                if ((this.IdComprobanteField.Equals(value) != true)) {
                    this.IdComprobanteField = value;
                    this.RaisePropertyChanged("IdComprobante");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> ImporteSubtotal {
            get {
                return this.ImporteSubtotalField;
            }
            set {
                if ((this.ImporteSubtotalField.Equals(value) != true)) {
                    this.ImporteSubtotalField = value;
                    this.RaisePropertyChanged("ImporteSubtotal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> ImporteTotal {
            get {
                return this.ImporteTotalField;
            }
            set {
                if ((this.ImporteTotalField.Equals(value) != true)) {
                    this.ImporteTotalField = value;
                    this.RaisePropertyChanged("ImporteTotal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> Impuesto {
            get {
                return this.ImpuestoField;
            }
            set {
                if ((this.ImpuestoField.Equals(value) != true)) {
                    this.ImpuestoField = value;
                    this.RaisePropertyChanged("Impuesto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string InvoiceState {
            get {
                return this.InvoiceStateField;
            }
            set {
                if ((object.ReferenceEquals(this.InvoiceStateField, value) != true)) {
                    this.InvoiceStateField = value;
                    this.RaisePropertyChanged("InvoiceState");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreArhivo {
            get {
                return this.NombreArhivoField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreArhivoField, value) != true)) {
                    this.NombreArhivoField = value;
                    this.RaisePropertyChanged("NombreArhivo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RAZONSOCIAL_PRODELSUR {
            get {
                return this.RAZONSOCIAL_PRODELSURField;
            }
            set {
                if ((object.ReferenceEquals(this.RAZONSOCIAL_PRODELSURField, value) != true)) {
                    this.RAZONSOCIAL_PRODELSURField = value;
                    this.RaisePropertyChanged("RAZONSOCIAL_PRODELSUR");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string RUC_PRODELSUR {
            get {
                return this.RUC_PRODELSURField;
            }
            set {
                if ((object.ReferenceEquals(this.RUC_PRODELSURField, value) != true)) {
                    this.RUC_PRODELSURField = value;
                    this.RaisePropertyChanged("RUC_PRODELSUR");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TipoMoneda {
            get {
                return this.TipoMonedaField;
            }
            set {
                if ((object.ReferenceEquals(this.TipoMonedaField, value) != true)) {
                    this.TipoMonedaField = value;
                    this.RaisePropertyChanged("TipoMoneda");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Usuario", Namespace="http://schemas.datacontract.org/2004/07/Persistence.domain")]
    [System.SerializableAttribute()]
    public partial class Usuario : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> bCambioPasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> dFecha_ModField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int nEstadoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> nIdUsuario_ModField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string vApeMatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string vApePatField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string vCodTrabajadorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string vCorreoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string vIdJefaturaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string vNombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string vPasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string vUsuarioField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdUsuario {
            get {
                return this.IdUsuarioField;
            }
            set {
                if ((this.IdUsuarioField.Equals(value) != true)) {
                    this.IdUsuarioField = value;
                    this.RaisePropertyChanged("IdUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> bCambioPassword {
            get {
                return this.bCambioPasswordField;
            }
            set {
                if ((this.bCambioPasswordField.Equals(value) != true)) {
                    this.bCambioPasswordField = value;
                    this.RaisePropertyChanged("bCambioPassword");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> dFecha_Mod {
            get {
                return this.dFecha_ModField;
            }
            set {
                if ((this.dFecha_ModField.Equals(value) != true)) {
                    this.dFecha_ModField = value;
                    this.RaisePropertyChanged("dFecha_Mod");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int nEstado {
            get {
                return this.nEstadoField;
            }
            set {
                if ((this.nEstadoField.Equals(value) != true)) {
                    this.nEstadoField = value;
                    this.RaisePropertyChanged("nEstado");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> nIdUsuario_Mod {
            get {
                return this.nIdUsuario_ModField;
            }
            set {
                if ((this.nIdUsuario_ModField.Equals(value) != true)) {
                    this.nIdUsuario_ModField = value;
                    this.RaisePropertyChanged("nIdUsuario_Mod");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string vApeMat {
            get {
                return this.vApeMatField;
            }
            set {
                if ((object.ReferenceEquals(this.vApeMatField, value) != true)) {
                    this.vApeMatField = value;
                    this.RaisePropertyChanged("vApeMat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string vApePat {
            get {
                return this.vApePatField;
            }
            set {
                if ((object.ReferenceEquals(this.vApePatField, value) != true)) {
                    this.vApePatField = value;
                    this.RaisePropertyChanged("vApePat");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string vCodTrabajador {
            get {
                return this.vCodTrabajadorField;
            }
            set {
                if ((object.ReferenceEquals(this.vCodTrabajadorField, value) != true)) {
                    this.vCodTrabajadorField = value;
                    this.RaisePropertyChanged("vCodTrabajador");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string vCorreo {
            get {
                return this.vCorreoField;
            }
            set {
                if ((object.ReferenceEquals(this.vCorreoField, value) != true)) {
                    this.vCorreoField = value;
                    this.RaisePropertyChanged("vCorreo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string vIdJefatura {
            get {
                return this.vIdJefaturaField;
            }
            set {
                if ((object.ReferenceEquals(this.vIdJefaturaField, value) != true)) {
                    this.vIdJefaturaField = value;
                    this.RaisePropertyChanged("vIdJefatura");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string vNombre {
            get {
                return this.vNombreField;
            }
            set {
                if ((object.ReferenceEquals(this.vNombreField, value) != true)) {
                    this.vNombreField = value;
                    this.RaisePropertyChanged("vNombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string vPassword {
            get {
                return this.vPasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.vPasswordField, value) != true)) {
                    this.vPasswordField = value;
                    this.RaisePropertyChanged("vPassword");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string vUsuario {
            get {
                return this.vUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.vUsuarioField, value) != true)) {
                    this.vUsuarioField = value;
                    this.RaisePropertyChanged("vUsuario");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceCVenta.IServiceCVenta")]
    public interface IServiceCVenta {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCVenta/GetComprobante", ReplyAction="http://tempuri.org/IServiceCVenta/GetComprobanteResponse")]
        ConsoleAppTest.ServiceCVenta.Result GetComprobante(int idComprobante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCVenta/GetComprobante", ReplyAction="http://tempuri.org/IServiceCVenta/GetComprobanteResponse")]
        System.Threading.Tasks.Task<ConsoleAppTest.ServiceCVenta.Result> GetComprobanteAsync(int idComprobante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCVenta/GetLisComprobanteCliente", ReplyAction="http://tempuri.org/IServiceCVenta/GetLisComprobanteClienteResponse")]
        ConsoleAppTest.ServiceCVenta.ComprobanteCliente[] GetLisComprobanteCliente(string nroDocumentoCliente, string tipoComprobante, string correlativo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCVenta/GetLisComprobanteCliente", ReplyAction="http://tempuri.org/IServiceCVenta/GetLisComprobanteClienteResponse")]
        System.Threading.Tasks.Task<ConsoleAppTest.ServiceCVenta.ComprobanteCliente[]> GetLisComprobanteClienteAsync(string nroDocumentoCliente, string tipoComprobante, string correlativo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCVenta/GetValidarUsuario", ReplyAction="http://tempuri.org/IServiceCVenta/GetValidarUsuarioResponse")]
        ConsoleAppTest.ServiceCVenta.Usuario GetValidarUsuario(string usuario, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceCVenta/GetValidarUsuario", ReplyAction="http://tempuri.org/IServiceCVenta/GetValidarUsuarioResponse")]
        System.Threading.Tasks.Task<ConsoleAppTest.ServiceCVenta.Usuario> GetValidarUsuarioAsync(string usuario, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceCVentaChannel : ConsoleAppTest.ServiceCVenta.IServiceCVenta, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceCVentaClient : System.ServiceModel.ClientBase<ConsoleAppTest.ServiceCVenta.IServiceCVenta>, ConsoleAppTest.ServiceCVenta.IServiceCVenta {
        
        public ServiceCVentaClient() {
        }
        
        public ServiceCVentaClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceCVentaClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCVentaClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceCVentaClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ConsoleAppTest.ServiceCVenta.Result GetComprobante(int idComprobante) {
            return base.Channel.GetComprobante(idComprobante);
        }
        
        public System.Threading.Tasks.Task<ConsoleAppTest.ServiceCVenta.Result> GetComprobanteAsync(int idComprobante) {
            return base.Channel.GetComprobanteAsync(idComprobante);
        }
        
        public ConsoleAppTest.ServiceCVenta.ComprobanteCliente[] GetLisComprobanteCliente(string nroDocumentoCliente, string tipoComprobante, string correlativo) {
            return base.Channel.GetLisComprobanteCliente(nroDocumentoCliente, tipoComprobante, correlativo);
        }
        
        public System.Threading.Tasks.Task<ConsoleAppTest.ServiceCVenta.ComprobanteCliente[]> GetLisComprobanteClienteAsync(string nroDocumentoCliente, string tipoComprobante, string correlativo) {
            return base.Channel.GetLisComprobanteClienteAsync(nroDocumentoCliente, tipoComprobante, correlativo);
        }
        
        public ConsoleAppTest.ServiceCVenta.Usuario GetValidarUsuario(string usuario, string password) {
            return base.Channel.GetValidarUsuario(usuario, password);
        }
        
        public System.Threading.Tasks.Task<ConsoleAppTest.ServiceCVenta.Usuario> GetValidarUsuarioAsync(string usuario, string password) {
            return base.Channel.GetValidarUsuarioAsync(usuario, password);
        }
    }
}
