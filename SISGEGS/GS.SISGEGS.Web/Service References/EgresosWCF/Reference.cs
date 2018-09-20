﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GS.SISGEGS.Web.EgresosWCF {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EgresosWCF.IEgresosWCF")]
    public interface IEgresosWCF {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEgresosWCF/EgresosVarios_ListarCajaChica", ReplyAction="http://tempuri.org/IEgresosWCF/EgresosVarios_ListarCajaChicaResponse")]
        GS.SISGEGS.DM.gsEgresosVarios_ListarCajaChicaResult[] EgresosVarios_ListarCajaChica(int idEmpresa, int codigoUsuario, string idAgenda, System.DateTime fechaInicio, System.DateTime fechaFinal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEgresosWCF/EgresosVarios_ListarCajaChica", ReplyAction="http://tempuri.org/IEgresosWCF/EgresosVarios_ListarCajaChicaResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.gsEgresosVarios_ListarCajaChicaResult[]> EgresosVarios_ListarCajaChicaAsync(int idEmpresa, int codigoUsuario, string idAgenda, System.DateTime fechaInicio, System.DateTime fechaFinal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEgresosWCF/EgresosVarios_Buscar", ReplyAction="http://tempuri.org/IEgresosWCF/EgresosVarios_BuscarResponse")]
        GS.SISGEGS.Web.EgresosWCF.EgresosVarios_BuscarResponse EgresosVarios_Buscar(GS.SISGEGS.Web.EgresosWCF.EgresosVarios_BuscarRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEgresosWCF/EgresosVarios_Buscar", ReplyAction="http://tempuri.org/IEgresosWCF/EgresosVarios_BuscarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.Web.EgresosWCF.EgresosVarios_BuscarResponse> EgresosVarios_BuscarAsync(GS.SISGEGS.Web.EgresosWCF.EgresosVarios_BuscarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEgresosWCF/EgresosVarios_Registrar", ReplyAction="http://tempuri.org/IEgresosWCF/EgresosVarios_RegistrarResponse")]
        void EgresosVarios_Registrar(int idEmpresa, int codigoUsuario, GS.SISGEGS.DM.gsEgresosVarios_BuscarCabeceraResult objEVCabecera, GS.SISGEGS.DM.gsEgresosVarios_BuscarDetalleResult[] lstEVDetalles);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEgresosWCF/EgresosVarios_Registrar", ReplyAction="http://tempuri.org/IEgresosWCF/EgresosVarios_RegistrarResponse")]
        System.Threading.Tasks.Task EgresosVarios_RegistrarAsync(int idEmpresa, int codigoUsuario, GS.SISGEGS.DM.gsEgresosVarios_BuscarCabeceraResult objEVCabecera, GS.SISGEGS.DM.gsEgresosVarios_BuscarDetalleResult[] lstEVDetalles);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEgresosWCF/EgresosVarios_Eliminar", ReplyAction="http://tempuri.org/IEgresosWCF/EgresosVarios_EliminarResponse")]
        void EgresosVarios_Eliminar(int idEmpresa, int codigoUsuario, int idOperacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEgresosWCF/EgresosVarios_Eliminar", ReplyAction="http://tempuri.org/IEgresosWCF/EgresosVarios_EliminarResponse")]
        System.Threading.Tasks.Task EgresosVarios_EliminarAsync(int idEmpresa, int codigoUsuario, int idOperacion);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EgresosVarios_Buscar", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EgresosVarios_BuscarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int idEmpresa;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int codigoUsuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int idOperacion;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public System.Nullable<bool> bloqueado;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public string mensajeBloqueado;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public GS.SISGEGS.DM.gsEgresosVarios_BuscarDetalleResult[] lstEgresosVarios;
        
        public EgresosVarios_BuscarRequest() {
        }
        
        public EgresosVarios_BuscarRequest(int idEmpresa, int codigoUsuario, int idOperacion, System.Nullable<bool> bloqueado, string mensajeBloqueado, GS.SISGEGS.DM.gsEgresosVarios_BuscarDetalleResult[] lstEgresosVarios) {
            this.idEmpresa = idEmpresa;
            this.codigoUsuario = codigoUsuario;
            this.idOperacion = idOperacion;
            this.bloqueado = bloqueado;
            this.mensajeBloqueado = mensajeBloqueado;
            this.lstEgresosVarios = lstEgresosVarios;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="EgresosVarios_BuscarResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class EgresosVarios_BuscarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public GS.SISGEGS.DM.gsEgresosVarios_BuscarCabeceraResult EgresosVarios_BuscarResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public System.Nullable<bool> bloqueado;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string mensajeBloqueado;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public GS.SISGEGS.DM.gsEgresosVarios_BuscarDetalleResult[] lstEgresosVarios;
        
        public EgresosVarios_BuscarResponse() {
        }
        
        public EgresosVarios_BuscarResponse(GS.SISGEGS.DM.gsEgresosVarios_BuscarCabeceraResult EgresosVarios_BuscarResult, System.Nullable<bool> bloqueado, string mensajeBloqueado, GS.SISGEGS.DM.gsEgresosVarios_BuscarDetalleResult[] lstEgresosVarios) {
            this.EgresosVarios_BuscarResult = EgresosVarios_BuscarResult;
            this.bloqueado = bloqueado;
            this.mensajeBloqueado = mensajeBloqueado;
            this.lstEgresosVarios = lstEgresosVarios;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEgresosWCFChannel : GS.SISGEGS.Web.EgresosWCF.IEgresosWCF, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EgresosWCFClient : System.ServiceModel.ClientBase<GS.SISGEGS.Web.EgresosWCF.IEgresosWCF>, GS.SISGEGS.Web.EgresosWCF.IEgresosWCF {
        
        public EgresosWCFClient() {
        }
        
        public EgresosWCFClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EgresosWCFClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EgresosWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EgresosWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GS.SISGEGS.DM.gsEgresosVarios_ListarCajaChicaResult[] EgresosVarios_ListarCajaChica(int idEmpresa, int codigoUsuario, string idAgenda, System.DateTime fechaInicio, System.DateTime fechaFinal) {
            return base.Channel.EgresosVarios_ListarCajaChica(idEmpresa, codigoUsuario, idAgenda, fechaInicio, fechaFinal);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.gsEgresosVarios_ListarCajaChicaResult[]> EgresosVarios_ListarCajaChicaAsync(int idEmpresa, int codigoUsuario, string idAgenda, System.DateTime fechaInicio, System.DateTime fechaFinal) {
            return base.Channel.EgresosVarios_ListarCajaChicaAsync(idEmpresa, codigoUsuario, idAgenda, fechaInicio, fechaFinal);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GS.SISGEGS.Web.EgresosWCF.EgresosVarios_BuscarResponse GS.SISGEGS.Web.EgresosWCF.IEgresosWCF.EgresosVarios_Buscar(GS.SISGEGS.Web.EgresosWCF.EgresosVarios_BuscarRequest request) {
            return base.Channel.EgresosVarios_Buscar(request);
        }
        
        public GS.SISGEGS.DM.gsEgresosVarios_BuscarCabeceraResult EgresosVarios_Buscar(int idEmpresa, int codigoUsuario, int idOperacion, ref System.Nullable<bool> bloqueado, ref string mensajeBloqueado, ref GS.SISGEGS.DM.gsEgresosVarios_BuscarDetalleResult[] lstEgresosVarios) {
            GS.SISGEGS.Web.EgresosWCF.EgresosVarios_BuscarRequest inValue = new GS.SISGEGS.Web.EgresosWCF.EgresosVarios_BuscarRequest();
            inValue.idEmpresa = idEmpresa;
            inValue.codigoUsuario = codigoUsuario;
            inValue.idOperacion = idOperacion;
            inValue.bloqueado = bloqueado;
            inValue.mensajeBloqueado = mensajeBloqueado;
            inValue.lstEgresosVarios = lstEgresosVarios;
            GS.SISGEGS.Web.EgresosWCF.EgresosVarios_BuscarResponse retVal = ((GS.SISGEGS.Web.EgresosWCF.IEgresosWCF)(this)).EgresosVarios_Buscar(inValue);
            bloqueado = retVal.bloqueado;
            mensajeBloqueado = retVal.mensajeBloqueado;
            lstEgresosVarios = retVal.lstEgresosVarios;
            return retVal.EgresosVarios_BuscarResult;
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.Web.EgresosWCF.EgresosVarios_BuscarResponse> EgresosVarios_BuscarAsync(GS.SISGEGS.Web.EgresosWCF.EgresosVarios_BuscarRequest request) {
            return base.Channel.EgresosVarios_BuscarAsync(request);
        }
        
        public void EgresosVarios_Registrar(int idEmpresa, int codigoUsuario, GS.SISGEGS.DM.gsEgresosVarios_BuscarCabeceraResult objEVCabecera, GS.SISGEGS.DM.gsEgresosVarios_BuscarDetalleResult[] lstEVDetalles) {
            base.Channel.EgresosVarios_Registrar(idEmpresa, codigoUsuario, objEVCabecera, lstEVDetalles);
        }
        
        public System.Threading.Tasks.Task EgresosVarios_RegistrarAsync(int idEmpresa, int codigoUsuario, GS.SISGEGS.DM.gsEgresosVarios_BuscarCabeceraResult objEVCabecera, GS.SISGEGS.DM.gsEgresosVarios_BuscarDetalleResult[] lstEVDetalles) {
            return base.Channel.EgresosVarios_RegistrarAsync(idEmpresa, codigoUsuario, objEVCabecera, lstEVDetalles);
        }
        
        public void EgresosVarios_Eliminar(int idEmpresa, int codigoUsuario, int idOperacion) {
            base.Channel.EgresosVarios_Eliminar(idEmpresa, codigoUsuario, idOperacion);
        }
        
        public System.Threading.Tasks.Task EgresosVarios_EliminarAsync(int idEmpresa, int codigoUsuario, int idOperacion) {
            return base.Channel.EgresosVarios_EliminarAsync(idEmpresa, codigoUsuario, idOperacion);
        }
    }
}
