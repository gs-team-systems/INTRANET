﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GS.SISGEGS.UT.DashboardWCF {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DashboardWCF.IDashboardWCF")]
    public interface IDashboardWCF {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDashboardWCF/DocVenta_ReporteVenta_Mes", ReplyAction="http://tempuri.org/IDashboardWCF/DocVenta_ReporteVenta_MesResponse")]
        GS.SISGEGS.DM.gsDocVenta_ReporteVenta_MesResult[] DocVenta_ReporteVenta_Mes(int idEmpresa, int codigoUsuario, System.DateTime fechaInicio, System.DateTime fechaFinal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDashboardWCF/DocVenta_ReporteVenta_Mes", ReplyAction="http://tempuri.org/IDashboardWCF/DocVenta_ReporteVenta_MesResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.gsDocVenta_ReporteVenta_MesResult[]> DocVenta_ReporteVenta_MesAsync(int idEmpresa, int codigoUsuario, System.DateTime fechaInicio, System.DateTime fechaFinal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDashboardWCF/Empresa_ListarDashboard", ReplyAction="http://tempuri.org/IDashboardWCF/Empresa_ListarDashboardResponse")]
        GS.SISGEGS.DM.Empresa_ListarDashboardResult[] Empresa_ListarDashboard();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDashboardWCF/Empresa_ListarDashboard", ReplyAction="http://tempuri.org/IDashboardWCF/Empresa_ListarDashboardResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.Empresa_ListarDashboardResult[]> Empresa_ListarDashboardAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDashboardWCF/DocVenta_Top5Vendedor", ReplyAction="http://tempuri.org/IDashboardWCF/DocVenta_Top5VendedorResponse")]
        GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5VendedorResponse DocVenta_Top5Vendedor(GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5VendedorRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDashboardWCF/DocVenta_Top5Vendedor", ReplyAction="http://tempuri.org/IDashboardWCF/DocVenta_Top5VendedorResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5VendedorResponse> DocVenta_Top5VendedorAsync(GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5VendedorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDashboardWCF/DocVenta_Top5Cliente", ReplyAction="http://tempuri.org/IDashboardWCF/DocVenta_Top5ClienteResponse")]
        GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5ClienteResponse DocVenta_Top5Cliente(GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5ClienteRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDashboardWCF/DocVenta_Top5Cliente", ReplyAction="http://tempuri.org/IDashboardWCF/DocVenta_Top5ClienteResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5ClienteResponse> DocVenta_Top5ClienteAsync(GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5ClienteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDashboardWCF/DocVenta_Top5Producto", ReplyAction="http://tempuri.org/IDashboardWCF/DocVenta_Top5ProductoResponse")]
        GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5ProductoResponse DocVenta_Top5Producto(GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5ProductoRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDashboardWCF/DocVenta_Top5Producto", ReplyAction="http://tempuri.org/IDashboardWCF/DocVenta_Top5ProductoResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5ProductoResponse> DocVenta_Top5ProductoAsync(GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5ProductoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDashboardWCF/DocVentaDev_ResumenMensual", ReplyAction="http://tempuri.org/IDashboardWCF/DocVentaDev_ResumenMensualResponse")]
        GS.SISGEGS.UT.DashboardWCF.DocVentaDev_ResumenMensualResponse DocVentaDev_ResumenMensual(GS.SISGEGS.UT.DashboardWCF.DocVentaDev_ResumenMensualRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDashboardWCF/DocVentaDev_ResumenMensual", ReplyAction="http://tempuri.org/IDashboardWCF/DocVentaDev_ResumenMensualResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.UT.DashboardWCF.DocVentaDev_ResumenMensualResponse> DocVentaDev_ResumenMensualAsync(GS.SISGEGS.UT.DashboardWCF.DocVentaDev_ResumenMensualRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDashboardWCF/DocVentaDev_KPIMotivo", ReplyAction="http://tempuri.org/IDashboardWCF/DocVentaDev_KPIMotivoResponse")]
        GS.SISGEGS.UT.DashboardWCF.DocVentaDev_KPIMotivoResponse DocVentaDev_KPIMotivo(GS.SISGEGS.UT.DashboardWCF.DocVentaDev_KPIMotivoRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDashboardWCF/DocVentaDev_KPIMotivo", ReplyAction="http://tempuri.org/IDashboardWCF/DocVentaDev_KPIMotivoResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.UT.DashboardWCF.DocVentaDev_KPIMotivoResponse> DocVentaDev_KPIMotivoAsync(GS.SISGEGS.UT.DashboardWCF.DocVentaDev_KPIMotivoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DocVenta_Top5Vendedor", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DocVenta_Top5VendedorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int idEmpresa;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int codigoUsuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public System.DateTime fechaInicio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public System.DateTime fechaFinal;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Venta;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Renta;
        
        public DocVenta_Top5VendedorRequest() {
        }
        
        public DocVenta_Top5VendedorRequest(int idEmpresa, int codigoUsuario, System.DateTime fechaInicio, System.DateTime fechaFinal, GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Venta, GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Renta) {
            this.idEmpresa = idEmpresa;
            this.codigoUsuario = codigoUsuario;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.lstTop5Venta = lstTop5Venta;
            this.lstTop5Renta = lstTop5Renta;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DocVenta_Top5VendedorResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DocVenta_Top5VendedorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Venta;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Renta;
        
        public DocVenta_Top5VendedorResponse() {
        }
        
        public DocVenta_Top5VendedorResponse(GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Venta, GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Renta) {
            this.lstTop5Venta = lstTop5Venta;
            this.lstTop5Renta = lstTop5Renta;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DocVenta_Top5Cliente", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DocVenta_Top5ClienteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int idEmpresa;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int codigoUsuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public System.DateTime fechaInicio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public System.DateTime fechaFinal;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Venta;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Renta;
        
        public DocVenta_Top5ClienteRequest() {
        }
        
        public DocVenta_Top5ClienteRequest(int idEmpresa, int codigoUsuario, System.DateTime fechaInicio, System.DateTime fechaFinal, GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Venta, GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Renta) {
            this.idEmpresa = idEmpresa;
            this.codigoUsuario = codigoUsuario;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.lstTop5Venta = lstTop5Venta;
            this.lstTop5Renta = lstTop5Renta;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DocVenta_Top5ClienteResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DocVenta_Top5ClienteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Venta;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Renta;
        
        public DocVenta_Top5ClienteResponse() {
        }
        
        public DocVenta_Top5ClienteResponse(GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Venta, GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Renta) {
            this.lstTop5Venta = lstTop5Venta;
            this.lstTop5Renta = lstTop5Renta;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DocVenta_Top5Producto", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DocVenta_Top5ProductoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int idEmpresa;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int codigoUsuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public System.DateTime fechaInicio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public System.DateTime fechaFinal;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Venta;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Renta;
        
        public DocVenta_Top5ProductoRequest() {
        }
        
        public DocVenta_Top5ProductoRequest(int idEmpresa, int codigoUsuario, System.DateTime fechaInicio, System.DateTime fechaFinal, GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Venta, GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Renta) {
            this.idEmpresa = idEmpresa;
            this.codigoUsuario = codigoUsuario;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.lstTop5Venta = lstTop5Venta;
            this.lstTop5Renta = lstTop5Renta;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DocVenta_Top5ProductoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DocVenta_Top5ProductoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Venta;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Renta;
        
        public DocVenta_Top5ProductoResponse() {
        }
        
        public DocVenta_Top5ProductoResponse(GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Venta, GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Renta) {
            this.lstTop5Venta = lstTop5Venta;
            this.lstTop5Renta = lstTop5Renta;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DocVentaDev_ResumenMensual", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DocVentaDev_ResumenMensualRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int idEmpresa;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int codigoUsuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public System.DateTime fechaInicio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public System.DateTime fechaFinal;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public GS.SISGEGS.BE.NotaCreditoKPIBE[] lstKPI;
        
        public DocVentaDev_ResumenMensualRequest() {
        }
        
        public DocVentaDev_ResumenMensualRequest(int idEmpresa, int codigoUsuario, System.DateTime fechaInicio, System.DateTime fechaFinal, GS.SISGEGS.BE.NotaCreditoKPIBE[] lstKPI) {
            this.idEmpresa = idEmpresa;
            this.codigoUsuario = codigoUsuario;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.lstKPI = lstKPI;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DocVentaDev_ResumenMensualResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DocVentaDev_ResumenMensualResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public GS.SISGEGS.BE.NotaCreditoKPIBE[] lstKPI;
        
        public DocVentaDev_ResumenMensualResponse() {
        }
        
        public DocVentaDev_ResumenMensualResponse(GS.SISGEGS.BE.NotaCreditoKPIBE[] lstKPI) {
            this.lstKPI = lstKPI;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DocVentaDev_KPIMotivo", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DocVentaDev_KPIMotivoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int idEmpresa;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int codigoUsuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public System.DateTime fechaInicio;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public System.DateTime fechaFinal;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public GS.SISGEGS.BE.DocVentaDev_KPIMotivoBE[] lstMotivo;
        
        public DocVentaDev_KPIMotivoRequest() {
        }
        
        public DocVentaDev_KPIMotivoRequest(int idEmpresa, int codigoUsuario, System.DateTime fechaInicio, System.DateTime fechaFinal, GS.SISGEGS.BE.DocVentaDev_KPIMotivoBE[] lstMotivo) {
            this.idEmpresa = idEmpresa;
            this.codigoUsuario = codigoUsuario;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.lstMotivo = lstMotivo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="DocVentaDev_KPIMotivoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class DocVentaDev_KPIMotivoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public GS.SISGEGS.BE.DocVentaDev_KPIMotivoBE[] lstMotivo;
        
        public DocVentaDev_KPIMotivoResponse() {
        }
        
        public DocVentaDev_KPIMotivoResponse(GS.SISGEGS.BE.DocVentaDev_KPIMotivoBE[] lstMotivo) {
            this.lstMotivo = lstMotivo;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDashboardWCFChannel : GS.SISGEGS.UT.DashboardWCF.IDashboardWCF, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DashboardWCFClient : System.ServiceModel.ClientBase<GS.SISGEGS.UT.DashboardWCF.IDashboardWCF>, GS.SISGEGS.UT.DashboardWCF.IDashboardWCF {
        
        public DashboardWCFClient() {
        }
        
        public DashboardWCFClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DashboardWCFClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DashboardWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DashboardWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GS.SISGEGS.DM.gsDocVenta_ReporteVenta_MesResult[] DocVenta_ReporteVenta_Mes(int idEmpresa, int codigoUsuario, System.DateTime fechaInicio, System.DateTime fechaFinal) {
            return base.Channel.DocVenta_ReporteVenta_Mes(idEmpresa, codigoUsuario, fechaInicio, fechaFinal);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.gsDocVenta_ReporteVenta_MesResult[]> DocVenta_ReporteVenta_MesAsync(int idEmpresa, int codigoUsuario, System.DateTime fechaInicio, System.DateTime fechaFinal) {
            return base.Channel.DocVenta_ReporteVenta_MesAsync(idEmpresa, codigoUsuario, fechaInicio, fechaFinal);
        }
        
        public GS.SISGEGS.DM.Empresa_ListarDashboardResult[] Empresa_ListarDashboard() {
            return base.Channel.Empresa_ListarDashboard();
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.Empresa_ListarDashboardResult[]> Empresa_ListarDashboardAsync() {
            return base.Channel.Empresa_ListarDashboardAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5VendedorResponse GS.SISGEGS.UT.DashboardWCF.IDashboardWCF.DocVenta_Top5Vendedor(GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5VendedorRequest request) {
            return base.Channel.DocVenta_Top5Vendedor(request);
        }
        
        public void DocVenta_Top5Vendedor(int idEmpresa, int codigoUsuario, System.DateTime fechaInicio, System.DateTime fechaFinal, ref GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Venta, ref GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Renta) {
            GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5VendedorRequest inValue = new GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5VendedorRequest();
            inValue.idEmpresa = idEmpresa;
            inValue.codigoUsuario = codigoUsuario;
            inValue.fechaInicio = fechaInicio;
            inValue.fechaFinal = fechaFinal;
            inValue.lstTop5Venta = lstTop5Venta;
            inValue.lstTop5Renta = lstTop5Renta;
            GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5VendedorResponse retVal = ((GS.SISGEGS.UT.DashboardWCF.IDashboardWCF)(this)).DocVenta_Top5Vendedor(inValue);
            lstTop5Venta = retVal.lstTop5Venta;
            lstTop5Renta = retVal.lstTop5Renta;
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5VendedorResponse> DocVenta_Top5VendedorAsync(GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5VendedorRequest request) {
            return base.Channel.DocVenta_Top5VendedorAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5ClienteResponse GS.SISGEGS.UT.DashboardWCF.IDashboardWCF.DocVenta_Top5Cliente(GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5ClienteRequest request) {
            return base.Channel.DocVenta_Top5Cliente(request);
        }
        
        public void DocVenta_Top5Cliente(int idEmpresa, int codigoUsuario, System.DateTime fechaInicio, System.DateTime fechaFinal, ref GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Venta, ref GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Renta) {
            GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5ClienteRequest inValue = new GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5ClienteRequest();
            inValue.idEmpresa = idEmpresa;
            inValue.codigoUsuario = codigoUsuario;
            inValue.fechaInicio = fechaInicio;
            inValue.fechaFinal = fechaFinal;
            inValue.lstTop5Venta = lstTop5Venta;
            inValue.lstTop5Renta = lstTop5Renta;
            GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5ClienteResponse retVal = ((GS.SISGEGS.UT.DashboardWCF.IDashboardWCF)(this)).DocVenta_Top5Cliente(inValue);
            lstTop5Venta = retVal.lstTop5Venta;
            lstTop5Renta = retVal.lstTop5Renta;
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5ClienteResponse> DocVenta_Top5ClienteAsync(GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5ClienteRequest request) {
            return base.Channel.DocVenta_Top5ClienteAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5ProductoResponse GS.SISGEGS.UT.DashboardWCF.IDashboardWCF.DocVenta_Top5Producto(GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5ProductoRequest request) {
            return base.Channel.DocVenta_Top5Producto(request);
        }
        
        public void DocVenta_Top5Producto(int idEmpresa, int codigoUsuario, System.DateTime fechaInicio, System.DateTime fechaFinal, ref GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Venta, ref GS.SISGEGS.BE.VendedorTop5BE[] lstTop5Renta) {
            GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5ProductoRequest inValue = new GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5ProductoRequest();
            inValue.idEmpresa = idEmpresa;
            inValue.codigoUsuario = codigoUsuario;
            inValue.fechaInicio = fechaInicio;
            inValue.fechaFinal = fechaFinal;
            inValue.lstTop5Venta = lstTop5Venta;
            inValue.lstTop5Renta = lstTop5Renta;
            GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5ProductoResponse retVal = ((GS.SISGEGS.UT.DashboardWCF.IDashboardWCF)(this)).DocVenta_Top5Producto(inValue);
            lstTop5Venta = retVal.lstTop5Venta;
            lstTop5Renta = retVal.lstTop5Renta;
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5ProductoResponse> DocVenta_Top5ProductoAsync(GS.SISGEGS.UT.DashboardWCF.DocVenta_Top5ProductoRequest request) {
            return base.Channel.DocVenta_Top5ProductoAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GS.SISGEGS.UT.DashboardWCF.DocVentaDev_ResumenMensualResponse GS.SISGEGS.UT.DashboardWCF.IDashboardWCF.DocVentaDev_ResumenMensual(GS.SISGEGS.UT.DashboardWCF.DocVentaDev_ResumenMensualRequest request) {
            return base.Channel.DocVentaDev_ResumenMensual(request);
        }
        
        public void DocVentaDev_ResumenMensual(int idEmpresa, int codigoUsuario, System.DateTime fechaInicio, System.DateTime fechaFinal, ref GS.SISGEGS.BE.NotaCreditoKPIBE[] lstKPI) {
            GS.SISGEGS.UT.DashboardWCF.DocVentaDev_ResumenMensualRequest inValue = new GS.SISGEGS.UT.DashboardWCF.DocVentaDev_ResumenMensualRequest();
            inValue.idEmpresa = idEmpresa;
            inValue.codigoUsuario = codigoUsuario;
            inValue.fechaInicio = fechaInicio;
            inValue.fechaFinal = fechaFinal;
            inValue.lstKPI = lstKPI;
            GS.SISGEGS.UT.DashboardWCF.DocVentaDev_ResumenMensualResponse retVal = ((GS.SISGEGS.UT.DashboardWCF.IDashboardWCF)(this)).DocVentaDev_ResumenMensual(inValue);
            lstKPI = retVal.lstKPI;
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.UT.DashboardWCF.DocVentaDev_ResumenMensualResponse> DocVentaDev_ResumenMensualAsync(GS.SISGEGS.UT.DashboardWCF.DocVentaDev_ResumenMensualRequest request) {
            return base.Channel.DocVentaDev_ResumenMensualAsync(request);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GS.SISGEGS.UT.DashboardWCF.DocVentaDev_KPIMotivoResponse GS.SISGEGS.UT.DashboardWCF.IDashboardWCF.DocVentaDev_KPIMotivo(GS.SISGEGS.UT.DashboardWCF.DocVentaDev_KPIMotivoRequest request) {
            return base.Channel.DocVentaDev_KPIMotivo(request);
        }
        
        public void DocVentaDev_KPIMotivo(int idEmpresa, int codigoUsuario, System.DateTime fechaInicio, System.DateTime fechaFinal, ref GS.SISGEGS.BE.DocVentaDev_KPIMotivoBE[] lstMotivo) {
            GS.SISGEGS.UT.DashboardWCF.DocVentaDev_KPIMotivoRequest inValue = new GS.SISGEGS.UT.DashboardWCF.DocVentaDev_KPIMotivoRequest();
            inValue.idEmpresa = idEmpresa;
            inValue.codigoUsuario = codigoUsuario;
            inValue.fechaInicio = fechaInicio;
            inValue.fechaFinal = fechaFinal;
            inValue.lstMotivo = lstMotivo;
            GS.SISGEGS.UT.DashboardWCF.DocVentaDev_KPIMotivoResponse retVal = ((GS.SISGEGS.UT.DashboardWCF.IDashboardWCF)(this)).DocVentaDev_KPIMotivo(inValue);
            lstMotivo = retVal.lstMotivo;
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.UT.DashboardWCF.DocVentaDev_KPIMotivoResponse> DocVentaDev_KPIMotivoAsync(GS.SISGEGS.UT.DashboardWCF.DocVentaDev_KPIMotivoRequest request) {
            return base.Channel.DocVentaDev_KPIMotivoAsync(request);
        }
    }
}