﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GS.SISGEGS.Web.MenuWCF {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MenuWCF.IMenuWCF")]
    public interface IMenuWCF {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuWCF/MenuPerfil_Listar", ReplyAction="http://tempuri.org/IMenuWCF/MenuPerfil_ListarResponse")]
        GS.SISGEGS.DM.MenuPerfil_ListarResult[] MenuPerfil_Listar(int idEmpresa, int idMenu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuWCF/MenuPerfil_Listar", ReplyAction="http://tempuri.org/IMenuWCF/MenuPerfil_ListarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.MenuPerfil_ListarResult[]> MenuPerfil_ListarAsync(int idEmpresa, int idMenu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuWCF/Menu_Listar", ReplyAction="http://tempuri.org/IMenuWCF/Menu_ListarResponse")]
        GS.SISGEGS.DM.Menu_ListarResult[] Menu_Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuWCF/Menu_Listar", ReplyAction="http://tempuri.org/IMenuWCF/Menu_ListarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.Menu_ListarResult[]> Menu_ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuWCF/Menu_Registrar", ReplyAction="http://tempuri.org/IMenuWCF/Menu_RegistrarResponse")]
        void Menu_Registrar(GS.SISGEGS.DM.Menu objMenu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuWCF/Menu_Registrar", ReplyAction="http://tempuri.org/IMenuWCF/Menu_RegistrarResponse")]
        System.Threading.Tasks.Task Menu_RegistrarAsync(GS.SISGEGS.DM.Menu objMenu);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuWCF/Menu_Modificar", ReplyAction="http://tempuri.org/IMenuWCF/Menu_ModificarResponse")]
        void Menu_Modificar(GS.SISGEGS.DM.Menu objMenu, int idEmpresa, string lstPerfil);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMenuWCF/Menu_Modificar", ReplyAction="http://tempuri.org/IMenuWCF/Menu_ModificarResponse")]
        System.Threading.Tasks.Task Menu_ModificarAsync(GS.SISGEGS.DM.Menu objMenu, int idEmpresa, string lstPerfil);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMenuWCFChannel : GS.SISGEGS.Web.MenuWCF.IMenuWCF, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MenuWCFClient : System.ServiceModel.ClientBase<GS.SISGEGS.Web.MenuWCF.IMenuWCF>, GS.SISGEGS.Web.MenuWCF.IMenuWCF {
        
        public MenuWCFClient() {
        }
        
        public MenuWCFClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MenuWCFClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MenuWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MenuWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GS.SISGEGS.DM.MenuPerfil_ListarResult[] MenuPerfil_Listar(int idEmpresa, int idMenu) {
            return base.Channel.MenuPerfil_Listar(idEmpresa, idMenu);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.MenuPerfil_ListarResult[]> MenuPerfil_ListarAsync(int idEmpresa, int idMenu) {
            return base.Channel.MenuPerfil_ListarAsync(idEmpresa, idMenu);
        }
        
        public GS.SISGEGS.DM.Menu_ListarResult[] Menu_Listar() {
            return base.Channel.Menu_Listar();
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.Menu_ListarResult[]> Menu_ListarAsync() {
            return base.Channel.Menu_ListarAsync();
        }
        
        public void Menu_Registrar(GS.SISGEGS.DM.Menu objMenu) {
            base.Channel.Menu_Registrar(objMenu);
        }
        
        public System.Threading.Tasks.Task Menu_RegistrarAsync(GS.SISGEGS.DM.Menu objMenu) {
            return base.Channel.Menu_RegistrarAsync(objMenu);
        }
        
        public void Menu_Modificar(GS.SISGEGS.DM.Menu objMenu, int idEmpresa, string lstPerfil) {
            base.Channel.Menu_Modificar(objMenu, idEmpresa, lstPerfil);
        }
        
        public System.Threading.Tasks.Task Menu_ModificarAsync(GS.SISGEGS.DM.Menu objMenu, int idEmpresa, string lstPerfil) {
            return base.Channel.Menu_ModificarAsync(objMenu, idEmpresa, lstPerfil);
        }
    }
}
