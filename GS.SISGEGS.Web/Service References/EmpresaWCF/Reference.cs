﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GS.SISGEGS.Web.EmpresaWCF {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EmpresaWCF.IEmpresaWCF")]
    public interface IEmpresaWCF {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpresaWCF/Empresa_ComboBox", ReplyAction="http://tempuri.org/IEmpresaWCF/Empresa_ComboBoxResponse")]
        GS.SISGEGS.DM.Empresa_ComboBoxResult[] Empresa_ComboBox();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpresaWCF/Empresa_ComboBox", ReplyAction="http://tempuri.org/IEmpresaWCF/Empresa_ComboBoxResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.Empresa_ComboBoxResult[]> Empresa_ComboBoxAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpresaWCF/Empresa_BuscarDetalle", ReplyAction="http://tempuri.org/IEmpresaWCF/Empresa_BuscarDetalleResponse")]
        GS.SISGEGS.DM.Empresa_BuscarDetalleResult[] Empresa_BuscarDetalle(int idEmmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpresaWCF/Empresa_BuscarDetalle", ReplyAction="http://tempuri.org/IEmpresaWCF/Empresa_BuscarDetalleResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.Empresa_BuscarDetalleResult[]> Empresa_BuscarDetalleAsync(int idEmmpresa);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpresaWCF/Empresa_Listar", ReplyAction="http://tempuri.org/IEmpresaWCF/Empresa_ListarResponse")]
        GS.SISGEGS.DM.Empresa_ListarResult[] Empresa_Listar(int idEmmpresa, string detalle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpresaWCF/Empresa_Listar", ReplyAction="http://tempuri.org/IEmpresaWCF/Empresa_ListarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.Empresa_ListarResult[]> Empresa_ListarAsync(int idEmmpresa, string detalle);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpresaWCF/Empresa_Registrar", ReplyAction="http://tempuri.org/IEmpresaWCF/Empresa_RegistrarResponse")]
        void Empresa_Registrar(int id_empresa, decimal provision, int comision);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmpresaWCF/Empresa_Registrar", ReplyAction="http://tempuri.org/IEmpresaWCF/Empresa_RegistrarResponse")]
        System.Threading.Tasks.Task Empresa_RegistrarAsync(int id_empresa, decimal provision, int comision);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmpresaWCFChannel : GS.SISGEGS.Web.EmpresaWCF.IEmpresaWCF, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmpresaWCFClient : System.ServiceModel.ClientBase<GS.SISGEGS.Web.EmpresaWCF.IEmpresaWCF>, GS.SISGEGS.Web.EmpresaWCF.IEmpresaWCF {
        
        public EmpresaWCFClient() {
        }
        
        public EmpresaWCFClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmpresaWCFClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmpresaWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmpresaWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GS.SISGEGS.DM.Empresa_ComboBoxResult[] Empresa_ComboBox() {
            return base.Channel.Empresa_ComboBox();
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.Empresa_ComboBoxResult[]> Empresa_ComboBoxAsync() {
            return base.Channel.Empresa_ComboBoxAsync();
        }
        
        public GS.SISGEGS.DM.Empresa_BuscarDetalleResult[] Empresa_BuscarDetalle(int idEmmpresa) {
            return base.Channel.Empresa_BuscarDetalle(idEmmpresa);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.Empresa_BuscarDetalleResult[]> Empresa_BuscarDetalleAsync(int idEmmpresa) {
            return base.Channel.Empresa_BuscarDetalleAsync(idEmmpresa);
        }
        
        public GS.SISGEGS.DM.Empresa_ListarResult[] Empresa_Listar(int idEmmpresa, string detalle) {
            return base.Channel.Empresa_Listar(idEmmpresa, detalle);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.Empresa_ListarResult[]> Empresa_ListarAsync(int idEmmpresa, string detalle) {
            return base.Channel.Empresa_ListarAsync(idEmmpresa, detalle);
        }
        
        public void Empresa_Registrar(int id_empresa, decimal provision, int comision) {
            base.Channel.Empresa_Registrar(id_empresa, provision, comision);
        }
        
        public System.Threading.Tasks.Task Empresa_RegistrarAsync(int id_empresa, decimal provision, int comision) {
            return base.Channel.Empresa_RegistrarAsync(id_empresa, provision, comision);
        }
    }
}
