﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GS.SISGEGS.Web.OrdenVentaWCF {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="OrdenVentaWCF.IOrdenVentaWCF")]
    public interface IOrdenVentaWCF {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Listar", ReplyAction="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_ListarResponse")]
        GS.SISGEGS.DM.gsOV_ListarResult[] OrdenVenta_Listar(int idEmpresa, int codigoUsuario, string ID_Agenda, System.DateTime fechaDesde, System.DateTime fechaHasta, string ID_Vendedor, bool modificarPedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Listar", ReplyAction="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_ListarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.gsOV_ListarResult[]> OrdenVenta_ListarAsync(int idEmpresa, int codigoUsuario, string ID_Agenda, System.DateTime fechaDesde, System.DateTime fechaHasta, string ID_Vendedor, bool modificarPedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Eliminar", ReplyAction="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_EliminarResponse")]
        void OrdenVenta_Eliminar(int idEmpresa, int codigoUsuario, int idOperacion, string Comentario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Eliminar", ReplyAction="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_EliminarResponse")]
        System.Threading.Tasks.Task OrdenVenta_EliminarAsync(int idEmpresa, int codigoUsuario, int idOperacion, string Comentario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Registrar", ReplyAction="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_RegistrarResponse")]
        void OrdenVenta_Registrar(int idEmpresa, int codigoUsuario, GS.SISGEGS.DM.gsOV_BuscarCabeceraResult objOrdenVentaCabBE, GS.SISGEGS.DM.gsOV_BuscarDetalleResult[] lstProductos, GS.SISGEGS.BE.GlosaBE[] lstImpuestos, System.Nullable<decimal> idOperacion, decimal limiteCredito, System.DateTime fechaVencimiento, GS.SISGEGS.DM.gsPedidos_FechasLetrasSelectResult[] ListaFechas, string Letras, int KardexFlete, GS.SISGEGS.DM.gsOV_BuscarDetalleResult objetoFlete, int DiasCredito);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Registrar", ReplyAction="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_RegistrarResponse")]
        System.Threading.Tasks.Task OrdenVenta_RegistrarAsync(int idEmpresa, int codigoUsuario, GS.SISGEGS.DM.gsOV_BuscarCabeceraResult objOrdenVentaCabBE, GS.SISGEGS.DM.gsOV_BuscarDetalleResult[] lstProductos, GS.SISGEGS.BE.GlosaBE[] lstImpuestos, System.Nullable<decimal> idOperacion, decimal limiteCredito, System.DateTime fechaVencimiento, GS.SISGEGS.DM.gsPedidos_FechasLetrasSelectResult[] ListaFechas, string Letras, int KardexFlete, GS.SISGEGS.DM.gsOV_BuscarDetalleResult objetoFlete, int DiasCredito);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Buscar", ReplyAction="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_BuscarResponse")]
        GS.SISGEGS.Web.OrdenVentaWCF.OrdenVenta_BuscarResponse OrdenVenta_Buscar(GS.SISGEGS.Web.OrdenVentaWCF.OrdenVenta_BuscarRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Buscar", ReplyAction="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_BuscarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.Web.OrdenVentaWCF.OrdenVenta_BuscarResponse> OrdenVenta_BuscarAsync(GS.SISGEGS.Web.OrdenVentaWCF.OrdenVenta_BuscarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_ListarTipo", ReplyAction="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_ListarTipoResponse")]
        GS.SISGEGS.DM.VBG03630Result[] OrdenVenta_ListarTipo(int idEmpresa, int codigoUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_ListarTipo", ReplyAction="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_ListarTipoResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.VBG03630Result[]> OrdenVenta_ListarTipoAsync(int idEmpresa, int codigoUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/OV_TransGratuitas_Aprobar", ReplyAction="http://tempuri.org/IOrdenVentaWCF/OV_TransGratuitas_AprobarResponse")]
        GS.SISGEGS.Web.OrdenVentaWCF.OV_TransGratuitas_AprobarResponse OV_TransGratuitas_Aprobar(GS.SISGEGS.Web.OrdenVentaWCF.OV_TransGratuitas_AprobarRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/OV_TransGratuitas_Aprobar", ReplyAction="http://tempuri.org/IOrdenVentaWCF/OV_TransGratuitas_AprobarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.Web.OrdenVentaWCF.OV_TransGratuitas_AprobarResponse> OV_TransGratuitas_AprobarAsync(GS.SISGEGS.Web.OrdenVentaWCF.OV_TransGratuitas_AprobarRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Listar_Sectorista", ReplyAction="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Listar_SectoristaResponse")]
        GS.SISGEGS.DM.gsOV_Listar_SectoristaResult[] OrdenVenta_Listar_Sectorista(int idEmpresa, int codigoUsuario, string ID_Agenda, System.DateTime fechaDesde, System.DateTime fechaHasta, string ID_Vendedor, bool modificarPedido, string id_Sectorista, int Estado, int FormaPago);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Listar_Sectorista", ReplyAction="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Listar_SectoristaResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.gsOV_Listar_SectoristaResult[]> OrdenVenta_Listar_SectoristaAsync(int idEmpresa, int codigoUsuario, string ID_Agenda, System.DateTime fechaDesde, System.DateTime fechaHasta, string ID_Vendedor, bool modificarPedido, string id_Sectorista, int Estado, int FormaPago);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Deasaprobar", ReplyAction="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_DeasaprobarResponse")]
        void OrdenVenta_Deasaprobar(int idEmpresa, int codigoUsuario, int idOperacion, string Comentario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Deasaprobar", ReplyAction="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_DeasaprobarResponse")]
        System.Threading.Tasks.Task OrdenVenta_DeasaprobarAsync(int idEmpresa, int codigoUsuario, int idOperacion, string Comentario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Registrar_Contado", ReplyAction="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Registrar_ContadoResponse")]
        void OrdenVenta_Registrar_Contado(int idEmpresa, int codigoUsuario, GS.SISGEGS.DM.gsOV_BuscarCabeceraResult objOrdenVentaCabBE, GS.SISGEGS.DM.gsOV_BuscarDetalleResult[] lstProductos, GS.SISGEGS.BE.GlosaBE[] lstImpuestos, System.Nullable<decimal> idOperacion, decimal limiteCredito, System.DateTime fechaVencimiento, GS.SISGEGS.DM.gsPedidos_FechasLetrasSelectResult[] ListaFechas, string Letras, int KardexFlete, GS.SISGEGS.DM.gsOV_BuscarDetalleResult objetoFlete, int DiasCredito);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Registrar_Contado", ReplyAction="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Registrar_ContadoResponse")]
        System.Threading.Tasks.Task OrdenVenta_Registrar_ContadoAsync(int idEmpresa, int codigoUsuario, GS.SISGEGS.DM.gsOV_BuscarCabeceraResult objOrdenVentaCabBE, GS.SISGEGS.DM.gsOV_BuscarDetalleResult[] lstProductos, GS.SISGEGS.BE.GlosaBE[] lstImpuestos, System.Nullable<decimal> idOperacion, decimal limiteCredito, System.DateTime fechaVencimiento, GS.SISGEGS.DM.gsPedidos_FechasLetrasSelectResult[] ListaFechas, string Letras, int KardexFlete, GS.SISGEGS.DM.gsOV_BuscarDetalleResult objetoFlete, int DiasCredito);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Buscar_Guia", ReplyAction="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Buscar_GuiaResponse")]
        GS.SISGEGS.Web.OrdenVentaWCF.OrdenVenta_Buscar_GuiaResponse OrdenVenta_Buscar_Guia(GS.SISGEGS.Web.OrdenVentaWCF.OrdenVenta_Buscar_GuiaRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Buscar_Guia", ReplyAction="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Buscar_GuiaResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.Web.OrdenVentaWCF.OrdenVenta_Buscar_GuiaResponse> OrdenVenta_Buscar_GuiaAsync(GS.SISGEGS.Web.OrdenVentaWCF.OrdenVenta_Buscar_GuiaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/PedidoLetras_Detalle", ReplyAction="http://tempuri.org/IOrdenVentaWCF/PedidoLetras_DetalleResponse")]
        GS.SISGEGS.DM.gsPedidos_FechasLetrasSelectResult[] PedidoLetras_Detalle(int idEmpresa, int codigoUsuario, int OpOV, int OpDOC, string Tabla);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/PedidoLetras_Detalle", ReplyAction="http://tempuri.org/IOrdenVentaWCF/PedidoLetras_DetalleResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.gsPedidos_FechasLetrasSelectResult[]> PedidoLetras_DetalleAsync(int idEmpresa, int codigoUsuario, int OpOV, int OpDOC, string Tabla);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/Pedido_Apto_Modificacion", ReplyAction="http://tempuri.org/IOrdenVentaWCF/Pedido_Apto_ModificacionResponse")]
        GS.SISGEGS.DM.gsPedido_EliminarOP_WMSResult Pedido_Apto_Modificacion(int idEmpresa, int codigoUsuario, int idPedido, int Op);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/Pedido_Apto_Modificacion", ReplyAction="http://tempuri.org/IOrdenVentaWCF/Pedido_Apto_ModificacionResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.gsPedido_EliminarOP_WMSResult> Pedido_Apto_ModificacionAsync(int idEmpresa, int codigoUsuario, int idPedido, int Op);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Registrar_Fechas", ReplyAction="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Registrar_FechasResponse")]
        void OrdenVenta_Registrar_Fechas(int idEmpresa, int codigoUsuario, System.Data.DataTable TablaDocs, GS.SISGEGS.DM.gsPedidos_FechasLetrasSelectResult[] ListaFechas);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Registrar_Fechas", ReplyAction="http://tempuri.org/IOrdenVentaWCF/OrdenVenta_Registrar_FechasResponse")]
        System.Threading.Tasks.Task OrdenVenta_Registrar_FechasAsync(int idEmpresa, int codigoUsuario, System.Data.DataTable TablaDocs, GS.SISGEGS.DM.gsPedidos_FechasLetrasSelectResult[] ListaFechas);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="OrdenVenta_Buscar", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class OrdenVenta_BuscarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int idEmpresa;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int codigoUsuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int idPedido;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public GS.SISGEGS.DM.gsOV_BuscarDetalleResult[] objOrdenVentaDet;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public GS.SISGEGS.DM.gsOV_BuscarImpuestoResult[] objOrdenVentaImp;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public System.Nullable<bool> bloqueado;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        public string mensajeBloqueado;
        
        public OrdenVenta_BuscarRequest() {
        }
        
        public OrdenVenta_BuscarRequest(int idEmpresa, int codigoUsuario, int idPedido, GS.SISGEGS.DM.gsOV_BuscarDetalleResult[] objOrdenVentaDet, GS.SISGEGS.DM.gsOV_BuscarImpuestoResult[] objOrdenVentaImp, System.Nullable<bool> bloqueado, string mensajeBloqueado) {
            this.idEmpresa = idEmpresa;
            this.codigoUsuario = codigoUsuario;
            this.idPedido = idPedido;
            this.objOrdenVentaDet = objOrdenVentaDet;
            this.objOrdenVentaImp = objOrdenVentaImp;
            this.bloqueado = bloqueado;
            this.mensajeBloqueado = mensajeBloqueado;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="OrdenVenta_BuscarResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class OrdenVenta_BuscarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public GS.SISGEGS.DM.gsOV_BuscarCabeceraResult OrdenVenta_BuscarResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public GS.SISGEGS.DM.gsOV_BuscarDetalleResult[] objOrdenVentaDet;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public GS.SISGEGS.DM.gsOV_BuscarImpuestoResult[] objOrdenVentaImp;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public System.Nullable<bool> bloqueado;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public string mensajeBloqueado;
        
        public OrdenVenta_BuscarResponse() {
        }
        
        public OrdenVenta_BuscarResponse(GS.SISGEGS.DM.gsOV_BuscarCabeceraResult OrdenVenta_BuscarResult, GS.SISGEGS.DM.gsOV_BuscarDetalleResult[] objOrdenVentaDet, GS.SISGEGS.DM.gsOV_BuscarImpuestoResult[] objOrdenVentaImp, System.Nullable<bool> bloqueado, string mensajeBloqueado) {
            this.OrdenVenta_BuscarResult = OrdenVenta_BuscarResult;
            this.objOrdenVentaDet = objOrdenVentaDet;
            this.objOrdenVentaImp = objOrdenVentaImp;
            this.bloqueado = bloqueado;
            this.mensajeBloqueado = mensajeBloqueado;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="OV_TransGratuitas_Aprobar", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class OV_TransGratuitas_AprobarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int idEmpresa;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int codigoUsuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int Op;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public string mensajeError;
        
        public OV_TransGratuitas_AprobarRequest() {
        }
        
        public OV_TransGratuitas_AprobarRequest(int idEmpresa, int codigoUsuario, int Op, string mensajeError) {
            this.idEmpresa = idEmpresa;
            this.codigoUsuario = codigoUsuario;
            this.Op = Op;
            this.mensajeError = mensajeError;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="OV_TransGratuitas_AprobarResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class OV_TransGratuitas_AprobarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string mensajeError;
        
        public OV_TransGratuitas_AprobarResponse() {
        }
        
        public OV_TransGratuitas_AprobarResponse(string mensajeError) {
            this.mensajeError = mensajeError;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="OrdenVenta_Buscar_Guia", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class OrdenVenta_Buscar_GuiaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int idEmpresa;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int codigoUsuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int idPedido;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public GS.SISGEGS.DM.gsOV_BuscarDetalleResult[] objOrdenVentaDet;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public GS.SISGEGS.DM.gsOV_BuscarImpuestoResult[] objOrdenVentaImp;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public System.Nullable<bool> bloqueado;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=6)]
        public string mensajeBloqueado;
        
        public OrdenVenta_Buscar_GuiaRequest() {
        }
        
        public OrdenVenta_Buscar_GuiaRequest(int idEmpresa, int codigoUsuario, int idPedido, GS.SISGEGS.DM.gsOV_BuscarDetalleResult[] objOrdenVentaDet, GS.SISGEGS.DM.gsOV_BuscarImpuestoResult[] objOrdenVentaImp, System.Nullable<bool> bloqueado, string mensajeBloqueado) {
            this.idEmpresa = idEmpresa;
            this.codigoUsuario = codigoUsuario;
            this.idPedido = idPedido;
            this.objOrdenVentaDet = objOrdenVentaDet;
            this.objOrdenVentaImp = objOrdenVentaImp;
            this.bloqueado = bloqueado;
            this.mensajeBloqueado = mensajeBloqueado;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="OrdenVenta_Buscar_GuiaResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class OrdenVenta_Buscar_GuiaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public GS.SISGEGS.DM.gsOV_BuscarCabeceraResult OrdenVenta_Buscar_GuiaResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public GS.SISGEGS.DM.gsOV_BuscarDetalleResult[] objOrdenVentaDet;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public GS.SISGEGS.DM.gsOV_BuscarImpuestoResult[] objOrdenVentaImp;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public System.Nullable<bool> bloqueado;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public string mensajeBloqueado;
        
        public OrdenVenta_Buscar_GuiaResponse() {
        }
        
        public OrdenVenta_Buscar_GuiaResponse(GS.SISGEGS.DM.gsOV_BuscarCabeceraResult OrdenVenta_Buscar_GuiaResult, GS.SISGEGS.DM.gsOV_BuscarDetalleResult[] objOrdenVentaDet, GS.SISGEGS.DM.gsOV_BuscarImpuestoResult[] objOrdenVentaImp, System.Nullable<bool> bloqueado, string mensajeBloqueado) {
            this.OrdenVenta_Buscar_GuiaResult = OrdenVenta_Buscar_GuiaResult;
            this.objOrdenVentaDet = objOrdenVentaDet;
            this.objOrdenVentaImp = objOrdenVentaImp;
            this.bloqueado = bloqueado;
            this.mensajeBloqueado = mensajeBloqueado;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IOrdenVentaWCFChannel : GS.SISGEGS.Web.OrdenVentaWCF.IOrdenVentaWCF, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrdenVentaWCFClient : System.ServiceModel.ClientBase<GS.SISGEGS.Web.OrdenVentaWCF.IOrdenVentaWCF>, GS.SISGEGS.Web.OrdenVentaWCF.IOrdenVentaWCF {
        
        public OrdenVentaWCFClient() {
        }
        
        public OrdenVentaWCFClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public OrdenVentaWCFClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrdenVentaWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public OrdenVentaWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GS.SISGEGS.DM.gsOV_ListarResult[] OrdenVenta_Listar(int idEmpresa, int codigoUsuario, string ID_Agenda, System.DateTime fechaDesde, System.DateTime fechaHasta, string ID_Vendedor, bool modificarPedido) {
            return base.Channel.OrdenVenta_Listar(idEmpresa, codigoUsuario, ID_Agenda, fechaDesde, fechaHasta, ID_Vendedor, modificarPedido);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.gsOV_ListarResult[]> OrdenVenta_ListarAsync(int idEmpresa, int codigoUsuario, string ID_Agenda, System.DateTime fechaDesde, System.DateTime fechaHasta, string ID_Vendedor, bool modificarPedido) {
            return base.Channel.OrdenVenta_ListarAsync(idEmpresa, codigoUsuario, ID_Agenda, fechaDesde, fechaHasta, ID_Vendedor, modificarPedido);
        }
        
        public void OrdenVenta_Eliminar(int idEmpresa, int codigoUsuario, int idOperacion, string Comentario) {
            base.Channel.OrdenVenta_Eliminar(idEmpresa, codigoUsuario, idOperacion, Comentario);
        }
        
        public System.Threading.Tasks.Task OrdenVenta_EliminarAsync(int idEmpresa, int codigoUsuario, int idOperacion, string Comentario) {
            return base.Channel.OrdenVenta_EliminarAsync(idEmpresa, codigoUsuario, idOperacion, Comentario);
        }
        
        public void OrdenVenta_Registrar(int idEmpresa, int codigoUsuario, GS.SISGEGS.DM.gsOV_BuscarCabeceraResult objOrdenVentaCabBE, GS.SISGEGS.DM.gsOV_BuscarDetalleResult[] lstProductos, GS.SISGEGS.BE.GlosaBE[] lstImpuestos, System.Nullable<decimal> idOperacion, decimal limiteCredito, System.DateTime fechaVencimiento, GS.SISGEGS.DM.gsPedidos_FechasLetrasSelectResult[] ListaFechas, string Letras, int KardexFlete, GS.SISGEGS.DM.gsOV_BuscarDetalleResult objetoFlete, int DiasCredito) {
            base.Channel.OrdenVenta_Registrar(idEmpresa, codigoUsuario, objOrdenVentaCabBE, lstProductos, lstImpuestos, idOperacion, limiteCredito, fechaVencimiento, ListaFechas, Letras, KardexFlete, objetoFlete, DiasCredito);
        }
        
        public System.Threading.Tasks.Task OrdenVenta_RegistrarAsync(int idEmpresa, int codigoUsuario, GS.SISGEGS.DM.gsOV_BuscarCabeceraResult objOrdenVentaCabBE, GS.SISGEGS.DM.gsOV_BuscarDetalleResult[] lstProductos, GS.SISGEGS.BE.GlosaBE[] lstImpuestos, System.Nullable<decimal> idOperacion, decimal limiteCredito, System.DateTime fechaVencimiento, GS.SISGEGS.DM.gsPedidos_FechasLetrasSelectResult[] ListaFechas, string Letras, int KardexFlete, GS.SISGEGS.DM.gsOV_BuscarDetalleResult objetoFlete, int DiasCredito) {
            return base.Channel.OrdenVenta_RegistrarAsync(idEmpresa, codigoUsuario, objOrdenVentaCabBE, lstProductos, lstImpuestos, idOperacion, limiteCredito, fechaVencimiento, ListaFechas, Letras, KardexFlete, objetoFlete, DiasCredito);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GS.SISGEGS.Web.OrdenVentaWCF.OrdenVenta_BuscarResponse GS.SISGEGS.Web.OrdenVentaWCF.IOrdenVentaWCF.OrdenVenta_Buscar(GS.SISGEGS.Web.OrdenVentaWCF.OrdenVenta_BuscarRequest request) {
            return base.Channel.OrdenVenta_Buscar(request);
        }
        
        public GS.SISGEGS.DM.gsOV_BuscarCabeceraResult OrdenVenta_Buscar(int idEmpresa, int codigoUsuario, int idPedido, ref GS.SISGEGS.DM.gsOV_BuscarDetalleResult[] objOrdenVentaDet, ref GS.SISGEGS.DM.gsOV_BuscarImpuestoResult[] objOrdenVentaImp, ref System.Nullable<bool> bloqueado, ref string mensajeBloqueado) {
            GS.SISGEGS.Web.OrdenVentaWCF.OrdenVenta_BuscarRequest inValue = new GS.SISGEGS.Web.OrdenVentaWCF.OrdenVenta_BuscarRequest();
            inValue.idEmpresa = idEmpresa;
            inValue.codigoUsuario = codigoUsuario;
            inValue.idPedido = idPedido;
            inValue.objOrdenVentaDet = objOrdenVentaDet;
            inValue.objOrdenVentaImp = objOrdenVentaImp;
            inValue.bloqueado = bloqueado;
            inValue.mensajeBloqueado = mensajeBloqueado;
            GS.SISGEGS.Web.OrdenVentaWCF.OrdenVenta_BuscarResponse retVal = ((GS.SISGEGS.Web.OrdenVentaWCF.IOrdenVentaWCF)(this)).OrdenVenta_Buscar(inValue);
            objOrdenVentaDet = retVal.objOrdenVentaDet;
            objOrdenVentaImp = retVal.objOrdenVentaImp;
            bloqueado = retVal.bloqueado;
            mensajeBloqueado = retVal.mensajeBloqueado;
            return retVal.OrdenVenta_BuscarResult;
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.Web.OrdenVentaWCF.OrdenVenta_BuscarResponse> OrdenVenta_BuscarAsync(GS.SISGEGS.Web.OrdenVentaWCF.OrdenVenta_BuscarRequest request) {
            return base.Channel.OrdenVenta_BuscarAsync(request);
        }
        
        public GS.SISGEGS.DM.VBG03630Result[] OrdenVenta_ListarTipo(int idEmpresa, int codigoUsuario) {
            return base.Channel.OrdenVenta_ListarTipo(idEmpresa, codigoUsuario);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.VBG03630Result[]> OrdenVenta_ListarTipoAsync(int idEmpresa, int codigoUsuario) {
            return base.Channel.OrdenVenta_ListarTipoAsync(idEmpresa, codigoUsuario);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GS.SISGEGS.Web.OrdenVentaWCF.OV_TransGratuitas_AprobarResponse GS.SISGEGS.Web.OrdenVentaWCF.IOrdenVentaWCF.OV_TransGratuitas_Aprobar(GS.SISGEGS.Web.OrdenVentaWCF.OV_TransGratuitas_AprobarRequest request) {
            return base.Channel.OV_TransGratuitas_Aprobar(request);
        }
        
        public void OV_TransGratuitas_Aprobar(int idEmpresa, int codigoUsuario, int Op, ref string mensajeError) {
            GS.SISGEGS.Web.OrdenVentaWCF.OV_TransGratuitas_AprobarRequest inValue = new GS.SISGEGS.Web.OrdenVentaWCF.OV_TransGratuitas_AprobarRequest();
            inValue.idEmpresa = idEmpresa;
            inValue.codigoUsuario = codigoUsuario;
            inValue.Op = Op;
            inValue.mensajeError = mensajeError;
            GS.SISGEGS.Web.OrdenVentaWCF.OV_TransGratuitas_AprobarResponse retVal = ((GS.SISGEGS.Web.OrdenVentaWCF.IOrdenVentaWCF)(this)).OV_TransGratuitas_Aprobar(inValue);
            mensajeError = retVal.mensajeError;
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.Web.OrdenVentaWCF.OV_TransGratuitas_AprobarResponse> OV_TransGratuitas_AprobarAsync(GS.SISGEGS.Web.OrdenVentaWCF.OV_TransGratuitas_AprobarRequest request) {
            return base.Channel.OV_TransGratuitas_AprobarAsync(request);
        }
        
        public GS.SISGEGS.DM.gsOV_Listar_SectoristaResult[] OrdenVenta_Listar_Sectorista(int idEmpresa, int codigoUsuario, string ID_Agenda, System.DateTime fechaDesde, System.DateTime fechaHasta, string ID_Vendedor, bool modificarPedido, string id_Sectorista, int Estado, int FormaPago) {
            return base.Channel.OrdenVenta_Listar_Sectorista(idEmpresa, codigoUsuario, ID_Agenda, fechaDesde, fechaHasta, ID_Vendedor, modificarPedido, id_Sectorista, Estado, FormaPago);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.gsOV_Listar_SectoristaResult[]> OrdenVenta_Listar_SectoristaAsync(int idEmpresa, int codigoUsuario, string ID_Agenda, System.DateTime fechaDesde, System.DateTime fechaHasta, string ID_Vendedor, bool modificarPedido, string id_Sectorista, int Estado, int FormaPago) {
            return base.Channel.OrdenVenta_Listar_SectoristaAsync(idEmpresa, codigoUsuario, ID_Agenda, fechaDesde, fechaHasta, ID_Vendedor, modificarPedido, id_Sectorista, Estado, FormaPago);
        }
        
        public void OrdenVenta_Deasaprobar(int idEmpresa, int codigoUsuario, int idOperacion, string Comentario) {
            base.Channel.OrdenVenta_Deasaprobar(idEmpresa, codigoUsuario, idOperacion, Comentario);
        }
        
        public System.Threading.Tasks.Task OrdenVenta_DeasaprobarAsync(int idEmpresa, int codigoUsuario, int idOperacion, string Comentario) {
            return base.Channel.OrdenVenta_DeasaprobarAsync(idEmpresa, codigoUsuario, idOperacion, Comentario);
        }
        
        public void OrdenVenta_Registrar_Contado(int idEmpresa, int codigoUsuario, GS.SISGEGS.DM.gsOV_BuscarCabeceraResult objOrdenVentaCabBE, GS.SISGEGS.DM.gsOV_BuscarDetalleResult[] lstProductos, GS.SISGEGS.BE.GlosaBE[] lstImpuestos, System.Nullable<decimal> idOperacion, decimal limiteCredito, System.DateTime fechaVencimiento, GS.SISGEGS.DM.gsPedidos_FechasLetrasSelectResult[] ListaFechas, string Letras, int KardexFlete, GS.SISGEGS.DM.gsOV_BuscarDetalleResult objetoFlete, int DiasCredito) {
            base.Channel.OrdenVenta_Registrar_Contado(idEmpresa, codigoUsuario, objOrdenVentaCabBE, lstProductos, lstImpuestos, idOperacion, limiteCredito, fechaVencimiento, ListaFechas, Letras, KardexFlete, objetoFlete, DiasCredito);
        }
        
        public System.Threading.Tasks.Task OrdenVenta_Registrar_ContadoAsync(int idEmpresa, int codigoUsuario, GS.SISGEGS.DM.gsOV_BuscarCabeceraResult objOrdenVentaCabBE, GS.SISGEGS.DM.gsOV_BuscarDetalleResult[] lstProductos, GS.SISGEGS.BE.GlosaBE[] lstImpuestos, System.Nullable<decimal> idOperacion, decimal limiteCredito, System.DateTime fechaVencimiento, GS.SISGEGS.DM.gsPedidos_FechasLetrasSelectResult[] ListaFechas, string Letras, int KardexFlete, GS.SISGEGS.DM.gsOV_BuscarDetalleResult objetoFlete, int DiasCredito) {
            return base.Channel.OrdenVenta_Registrar_ContadoAsync(idEmpresa, codigoUsuario, objOrdenVentaCabBE, lstProductos, lstImpuestos, idOperacion, limiteCredito, fechaVencimiento, ListaFechas, Letras, KardexFlete, objetoFlete, DiasCredito);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GS.SISGEGS.Web.OrdenVentaWCF.OrdenVenta_Buscar_GuiaResponse GS.SISGEGS.Web.OrdenVentaWCF.IOrdenVentaWCF.OrdenVenta_Buscar_Guia(GS.SISGEGS.Web.OrdenVentaWCF.OrdenVenta_Buscar_GuiaRequest request) {
            return base.Channel.OrdenVenta_Buscar_Guia(request);
        }
        
        public GS.SISGEGS.DM.gsOV_BuscarCabeceraResult OrdenVenta_Buscar_Guia(int idEmpresa, int codigoUsuario, int idPedido, ref GS.SISGEGS.DM.gsOV_BuscarDetalleResult[] objOrdenVentaDet, ref GS.SISGEGS.DM.gsOV_BuscarImpuestoResult[] objOrdenVentaImp, ref System.Nullable<bool> bloqueado, ref string mensajeBloqueado) {
            GS.SISGEGS.Web.OrdenVentaWCF.OrdenVenta_Buscar_GuiaRequest inValue = new GS.SISGEGS.Web.OrdenVentaWCF.OrdenVenta_Buscar_GuiaRequest();
            inValue.idEmpresa = idEmpresa;
            inValue.codigoUsuario = codigoUsuario;
            inValue.idPedido = idPedido;
            inValue.objOrdenVentaDet = objOrdenVentaDet;
            inValue.objOrdenVentaImp = objOrdenVentaImp;
            inValue.bloqueado = bloqueado;
            inValue.mensajeBloqueado = mensajeBloqueado;
            GS.SISGEGS.Web.OrdenVentaWCF.OrdenVenta_Buscar_GuiaResponse retVal = ((GS.SISGEGS.Web.OrdenVentaWCF.IOrdenVentaWCF)(this)).OrdenVenta_Buscar_Guia(inValue);
            objOrdenVentaDet = retVal.objOrdenVentaDet;
            objOrdenVentaImp = retVal.objOrdenVentaImp;
            bloqueado = retVal.bloqueado;
            mensajeBloqueado = retVal.mensajeBloqueado;
            return retVal.OrdenVenta_Buscar_GuiaResult;
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.Web.OrdenVentaWCF.OrdenVenta_Buscar_GuiaResponse> OrdenVenta_Buscar_GuiaAsync(GS.SISGEGS.Web.OrdenVentaWCF.OrdenVenta_Buscar_GuiaRequest request) {
            return base.Channel.OrdenVenta_Buscar_GuiaAsync(request);
        }
        
        public GS.SISGEGS.DM.gsPedidos_FechasLetrasSelectResult[] PedidoLetras_Detalle(int idEmpresa, int codigoUsuario, int OpOV, int OpDOC, string Tabla) {
            return base.Channel.PedidoLetras_Detalle(idEmpresa, codigoUsuario, OpOV, OpDOC, Tabla);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.gsPedidos_FechasLetrasSelectResult[]> PedidoLetras_DetalleAsync(int idEmpresa, int codigoUsuario, int OpOV, int OpDOC, string Tabla) {
            return base.Channel.PedidoLetras_DetalleAsync(idEmpresa, codigoUsuario, OpOV, OpDOC, Tabla);
        }
        
        public GS.SISGEGS.DM.gsPedido_EliminarOP_WMSResult Pedido_Apto_Modificacion(int idEmpresa, int codigoUsuario, int idPedido, int Op) {
            return base.Channel.Pedido_Apto_Modificacion(idEmpresa, codigoUsuario, idPedido, Op);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.gsPedido_EliminarOP_WMSResult> Pedido_Apto_ModificacionAsync(int idEmpresa, int codigoUsuario, int idPedido, int Op) {
            return base.Channel.Pedido_Apto_ModificacionAsync(idEmpresa, codigoUsuario, idPedido, Op);
        }
        
        public void OrdenVenta_Registrar_Fechas(int idEmpresa, int codigoUsuario, System.Data.DataTable TablaDocs, GS.SISGEGS.DM.gsPedidos_FechasLetrasSelectResult[] ListaFechas) {
            base.Channel.OrdenVenta_Registrar_Fechas(idEmpresa, codigoUsuario, TablaDocs, ListaFechas);
        }
        
        public System.Threading.Tasks.Task OrdenVenta_Registrar_FechasAsync(int idEmpresa, int codigoUsuario, System.Data.DataTable TablaDocs, GS.SISGEGS.DM.gsPedidos_FechasLetrasSelectResult[] ListaFechas) {
            return base.Channel.OrdenVenta_Registrar_FechasAsync(idEmpresa, codigoUsuario, TablaDocs, ListaFechas);
        }
    }
}
