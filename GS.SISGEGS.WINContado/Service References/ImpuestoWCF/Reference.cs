﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GS.SISGEGS.WINContado.ImpuestoWCF {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="gsImpuesto_ListarPorItemResult", Namespace="http://schemas.datacontract.org/2004/07/GS.SISGEGS.DM")]
    [System.SerializableAttribute()]
    public partial class gsImpuesto_ListarPorItemResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AbreviacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EsPorcentajeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ID_CuentaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ID_ImpuestoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ID_ItemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> ValorField;
        
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
        public string Abreviacion {
            get {
                return this.AbreviacionField;
            }
            set {
                if ((object.ReferenceEquals(this.AbreviacionField, value) != true)) {
                    this.AbreviacionField = value;
                    this.RaisePropertyChanged("Abreviacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool EsPorcentaje {
            get {
                return this.EsPorcentajeField;
            }
            set {
                if ((this.EsPorcentajeField.Equals(value) != true)) {
                    this.EsPorcentajeField = value;
                    this.RaisePropertyChanged("EsPorcentaje");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ID_Cuenta {
            get {
                return this.ID_CuentaField;
            }
            set {
                if ((object.ReferenceEquals(this.ID_CuentaField, value) != true)) {
                    this.ID_CuentaField = value;
                    this.RaisePropertyChanged("ID_Cuenta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal ID_Impuesto {
            get {
                return this.ID_ImpuestoField;
            }
            set {
                if ((this.ID_ImpuestoField.Equals(value) != true)) {
                    this.ID_ImpuestoField = value;
                    this.RaisePropertyChanged("ID_Impuesto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal ID_Item {
            get {
                return this.ID_ItemField;
            }
            set {
                if ((this.ID_ItemField.Equals(value) != true)) {
                    this.ID_ItemField = value;
                    this.RaisePropertyChanged("ID_Item");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> Valor {
            get {
                return this.ValorField;
            }
            set {
                if ((this.ValorField.Equals(value) != true)) {
                    this.ValorField = value;
                    this.RaisePropertyChanged("Valor");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="gsImpuesto_BuscarPorPedidoResult", Namespace="http://schemas.datacontract.org/2004/07/GS.SISGEGS.DM")]
    [System.SerializableAttribute()]
    public partial class gsImpuesto_BuscarPorPedidoResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AbreviacionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal BaseImponibleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool EsPorcentajeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ID_ImpuestoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private decimal ImporteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> ValorField;
        
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
        public string Abreviacion {
            get {
                return this.AbreviacionField;
            }
            set {
                if ((object.ReferenceEquals(this.AbreviacionField, value) != true)) {
                    this.AbreviacionField = value;
                    this.RaisePropertyChanged("Abreviacion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal BaseImponible {
            get {
                return this.BaseImponibleField;
            }
            set {
                if ((this.BaseImponibleField.Equals(value) != true)) {
                    this.BaseImponibleField = value;
                    this.RaisePropertyChanged("BaseImponible");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool EsPorcentaje {
            get {
                return this.EsPorcentajeField;
            }
            set {
                if ((this.EsPorcentajeField.Equals(value) != true)) {
                    this.EsPorcentajeField = value;
                    this.RaisePropertyChanged("EsPorcentaje");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal ID_Impuesto {
            get {
                return this.ID_ImpuestoField;
            }
            set {
                if ((this.ID_ImpuestoField.Equals(value) != true)) {
                    this.ID_ImpuestoField = value;
                    this.RaisePropertyChanged("ID_Impuesto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Importe {
            get {
                return this.ImporteField;
            }
            set {
                if ((this.ImporteField.Equals(value) != true)) {
                    this.ImporteField = value;
                    this.RaisePropertyChanged("Importe");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nombre {
            get {
                return this.NombreField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreField, value) != true)) {
                    this.NombreField = value;
                    this.RaisePropertyChanged("Nombre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> Valor {
            get {
                return this.ValorField;
            }
            set {
                if ((this.ValorField.Equals(value) != true)) {
                    this.ValorField = value;
                    this.RaisePropertyChanged("Valor");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ImpuestoWCF.IImpuestoWCF")]
    public interface IImpuestoWCF {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImpuestoWCF/Impuesto_ListarPorItem", ReplyAction="http://tempuri.org/IImpuestoWCF/Impuesto_ListarPorItemResponse")]
        GS.SISGEGS.WINContado.ImpuestoWCF.gsImpuesto_ListarPorItemResult[] Impuesto_ListarPorItem(int idEmpresa, int codigoUsuario, string idItem, System.DateTime fecha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImpuestoWCF/Impuesto_ListarPorItem", ReplyAction="http://tempuri.org/IImpuestoWCF/Impuesto_ListarPorItemResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.WINContado.ImpuestoWCF.gsImpuesto_ListarPorItemResult[]> Impuesto_ListarPorItemAsync(int idEmpresa, int codigoUsuario, string idItem, System.DateTime fecha);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImpuestoWCF/Impuesto_BuscarPorPedido", ReplyAction="http://tempuri.org/IImpuestoWCF/Impuesto_BuscarPorPedidoResponse")]
        GS.SISGEGS.WINContado.ImpuestoWCF.gsImpuesto_BuscarPorPedidoResult[] Impuesto_BuscarPorPedido(int idEmpresa, int codigoUsuario, int idPedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IImpuestoWCF/Impuesto_BuscarPorPedido", ReplyAction="http://tempuri.org/IImpuestoWCF/Impuesto_BuscarPorPedidoResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.WINContado.ImpuestoWCF.gsImpuesto_BuscarPorPedidoResult[]> Impuesto_BuscarPorPedidoAsync(int idEmpresa, int codigoUsuario, int idPedido);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IImpuestoWCFChannel : GS.SISGEGS.WINContado.ImpuestoWCF.IImpuestoWCF, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ImpuestoWCFClient : System.ServiceModel.ClientBase<GS.SISGEGS.WINContado.ImpuestoWCF.IImpuestoWCF>, GS.SISGEGS.WINContado.ImpuestoWCF.IImpuestoWCF {
        
        public ImpuestoWCFClient() {
        }
        
        public ImpuestoWCFClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ImpuestoWCFClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImpuestoWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ImpuestoWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GS.SISGEGS.WINContado.ImpuestoWCF.gsImpuesto_ListarPorItemResult[] Impuesto_ListarPorItem(int idEmpresa, int codigoUsuario, string idItem, System.DateTime fecha) {
            return base.Channel.Impuesto_ListarPorItem(idEmpresa, codigoUsuario, idItem, fecha);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.WINContado.ImpuestoWCF.gsImpuesto_ListarPorItemResult[]> Impuesto_ListarPorItemAsync(int idEmpresa, int codigoUsuario, string idItem, System.DateTime fecha) {
            return base.Channel.Impuesto_ListarPorItemAsync(idEmpresa, codigoUsuario, idItem, fecha);
        }
        
        public GS.SISGEGS.WINContado.ImpuestoWCF.gsImpuesto_BuscarPorPedidoResult[] Impuesto_BuscarPorPedido(int idEmpresa, int codigoUsuario, int idPedido) {
            return base.Channel.Impuesto_BuscarPorPedido(idEmpresa, codigoUsuario, idPedido);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.WINContado.ImpuestoWCF.gsImpuesto_BuscarPorPedidoResult[]> Impuesto_BuscarPorPedidoAsync(int idEmpresa, int codigoUsuario, int idPedido) {
            return base.Channel.Impuesto_BuscarPorPedidoAsync(idEmpresa, codigoUsuario, idPedido);
        }
    }
}
