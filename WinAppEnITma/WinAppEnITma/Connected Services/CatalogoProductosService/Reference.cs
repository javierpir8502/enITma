﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinAppEnITma.CatalogoProductosService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CatalogoProducto", Namespace="http://schemas.datacontract.org/2004/07/ENT")]
    [System.SerializableAttribute()]
    public partial class CatalogoProducto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescripcionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaCreacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdProductoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdUsuarioField;
        
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
        public string Descripcion {
            get {
                return this.DescripcionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescripcionField, value) != true)) {
                    this.DescripcionField = value;
                    this.RaisePropertyChanged("Descripcion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaCreacion {
            get {
                return this.FechaCreacionField;
            }
            set {
                if ((this.FechaCreacionField.Equals(value) != true)) {
                    this.FechaCreacionField = value;
                    this.RaisePropertyChanged("FechaCreacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdProducto {
            get {
                return this.IdProductoField;
            }
            set {
                if ((this.IdProductoField.Equals(value) != true)) {
                    this.IdProductoField = value;
                    this.RaisePropertyChanged("IdProducto");
                }
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
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CatalogoProductosService.ICatalogoProductoService")]
    public interface ICatalogoProductoService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogoProductoService/AgregarCatalogoProducto", ReplyAction="http://tempuri.org/ICatalogoProductoService/AgregarCatalogoProductoResponse")]
        void AgregarCatalogoProducto(string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogoProductoService/AgregarCatalogoProducto", ReplyAction="http://tempuri.org/ICatalogoProductoService/AgregarCatalogoProductoResponse")]
        System.Threading.Tasks.Task AgregarCatalogoProductoAsync(string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogoProductoService/ObtenerCatalogoProductos", ReplyAction="http://tempuri.org/ICatalogoProductoService/ObtenerCatalogoProductosResponse")]
        WinAppEnITma.CatalogoProductosService.CatalogoProducto[] ObtenerCatalogoProductos();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICatalogoProductoService/ObtenerCatalogoProductos", ReplyAction="http://tempuri.org/ICatalogoProductoService/ObtenerCatalogoProductosResponse")]
        System.Threading.Tasks.Task<WinAppEnITma.CatalogoProductosService.CatalogoProducto[]> ObtenerCatalogoProductosAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICatalogoProductoServiceChannel : WinAppEnITma.CatalogoProductosService.ICatalogoProductoService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CatalogoProductoServiceClient : System.ServiceModel.ClientBase<WinAppEnITma.CatalogoProductosService.ICatalogoProductoService>, WinAppEnITma.CatalogoProductosService.ICatalogoProductoService {
        
        public CatalogoProductoServiceClient() {
        }
        
        public CatalogoProductoServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CatalogoProductoServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CatalogoProductoServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CatalogoProductoServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AgregarCatalogoProducto(string descripcion) {
            base.Channel.AgregarCatalogoProducto(descripcion);
        }
        
        public System.Threading.Tasks.Task AgregarCatalogoProductoAsync(string descripcion) {
            return base.Channel.AgregarCatalogoProductoAsync(descripcion);
        }
        
        public WinAppEnITma.CatalogoProductosService.CatalogoProducto[] ObtenerCatalogoProductos() {
            return base.Channel.ObtenerCatalogoProductos();
        }
        
        public System.Threading.Tasks.Task<WinAppEnITma.CatalogoProductosService.CatalogoProducto[]> ObtenerCatalogoProductosAsync() {
            return base.Channel.ObtenerCatalogoProductosAsync();
        }
    }
}
