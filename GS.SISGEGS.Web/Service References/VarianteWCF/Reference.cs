﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GS.SISGEGS.Web.VarianteWCF {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VarianteWCF.IVarianteWCF")]
    public interface IVarianteWCF {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVarianteWCF/Variante_Buscar", ReplyAction="http://tempuri.org/IVarianteWCF/Variante_BuscarResponse")]
        GS.SISGEGS.DM.Variante_BuscarResult Variante_Buscar(int idEmpresa, string codigoVariante);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVarianteWCF/Variante_Buscar", ReplyAction="http://tempuri.org/IVarianteWCF/Variante_BuscarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.Variante_BuscarResult> Variante_BuscarAsync(int idEmpresa, string codigoVariante);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVarianteWCFChannel : GS.SISGEGS.Web.VarianteWCF.IVarianteWCF, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VarianteWCFClient : System.ServiceModel.ClientBase<GS.SISGEGS.Web.VarianteWCF.IVarianteWCF>, GS.SISGEGS.Web.VarianteWCF.IVarianteWCF {
        
        public VarianteWCFClient() {
        }
        
        public VarianteWCFClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VarianteWCFClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VarianteWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VarianteWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GS.SISGEGS.DM.Variante_BuscarResult Variante_Buscar(int idEmpresa, string codigoVariante) {
            return base.Channel.Variante_Buscar(idEmpresa, codigoVariante);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.Variante_BuscarResult> Variante_BuscarAsync(int idEmpresa, string codigoVariante) {
            return base.Channel.Variante_BuscarAsync(idEmpresa, codigoVariante);
        }
    }
}
