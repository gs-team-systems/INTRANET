﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GS.SISGEGS.WINPedidos.GuiaWCF {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GuiaWCF.IGuiaWCF")]
    public interface IGuiaWCF {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_ListarxPedido", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_ListarxPedidoResponse")]
        GS.SISGEGS.DM.gsGuiaVenta_ListarXPedidoResult[] GuiaVenta_ListarxPedido(int idEmpresa, int codigoUsuario, int idPedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_ListarxPedido", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_ListarxPedidoResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.gsGuiaVenta_ListarXPedidoResult[]> GuiaVenta_ListarxPedidoAsync(int idEmpresa, int codigoUsuario, int idPedido);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_Listar", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_ListarResponse")]
        GS.SISGEGS.DM.gsGuiaVentas_listarResult[] GuiaVenta_Listar(int idEmpresa, int codigoUsuario, string id_agenda, System.DateTime fInicio, System.DateTime fFin, string id_item, int ID_Almacen, int OP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_Listar", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_ListarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.gsGuiaVentas_listarResult[]> GuiaVenta_ListarAsync(int idEmpresa, int codigoUsuario, string id_agenda, System.DateTime fInicio, System.DateTime fFin, string id_item, int ID_Almacen, int OP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_ListarxOP", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_ListarxOPResponse")]
        GS.SISGEGS.DM.gsGuiaVenta_ListarxOPResult[] GuiaVenta_ListarxOP(int idEmpresa, int codigoUsuario, int idOperacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_ListarxOP", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_ListarxOPResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.gsGuiaVenta_ListarxOPResult[]> GuiaVenta_ListarxOPAsync(int idEmpresa, int codigoUsuario, int idOperacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_ActualizarTransporte", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_ActualizarTransporteResponse")]
        void GuiaVenta_ActualizarTransporte(int idEmpresa, int codigoUsuario, GS.SISGEGS.DM.gsGuiaVenta_ListarxOPResult objGuiaVentaLista, decimal idOperacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_ActualizarTransporte", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_ActualizarTransporteResponse")]
        System.Threading.Tasks.Task GuiaVenta_ActualizarTransporteAsync(int idEmpresa, int codigoUsuario, GS.SISGEGS.DM.gsGuiaVenta_ListarxOPResult objGuiaVentaLista, decimal idOperacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_FechaInsertar", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_FechaInsertarResponse")]
        void GuiaVenta_FechaInsertar(int idEmpresa, int codigoUsuario, int Op, string transaccion, string id_agenda, System.DateTime fechaEmision, int id_vehiculo, int estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_FechaInsertar", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_FechaInsertarResponse")]
        System.Threading.Tasks.Task GuiaVenta_FechaInsertarAsync(int idEmpresa, int codigoUsuario, int Op, string transaccion, string id_agenda, System.DateTime fechaEmision, int id_vehiculo, int estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_FechasListar", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_FechasListarResponse")]
        GS.SISGEGS.DM.gsGuiaVentas_FechaslistarResult[] GuiaVenta_FechasListar(int idEmpresa, int codigoUsuario, string id_agenda, System.DateTime fInicio, System.DateTime fFin, string id_item, int ID_Almacen, int OP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_FechasListar", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_FechasListarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.gsGuiaVentas_FechaslistarResult[]> GuiaVenta_FechasListarAsync(int idEmpresa, int codigoUsuario, string id_agenda, System.DateTime fInicio, System.DateTime fFin, string id_item, int ID_Almacen, int OP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_TransitoListar", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_TransitoListarResponse")]
        GS.SISGEGS.DM.gsGuiaVentas_TransitolistarResult[] GuiaVenta_TransitoListar(int idEmpresa, int codigoUsuario, string id_agenda, System.DateTime fInicio, System.DateTime fFin, string id_item, int ID_Almacen, int OP, int id_vehiculo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_TransitoListar", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_TransitoListarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.gsGuiaVentas_TransitolistarResult[]> GuiaVenta_TransitoListarAsync(int idEmpresa, int codigoUsuario, string id_agenda, System.DateTime fInicio, System.DateTime fFin, string id_item, int ID_Almacen, int OP, int id_vehiculo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_FechaTransporte", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_FechaTransporteResponse")]
        void GuiaVenta_FechaTransporte(int idEmpresa, int codigoUsuario, int Op, string transaccion, string id_agenda, int estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_FechaTransporte", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_FechaTransporteResponse")]
        System.Threading.Tasks.Task GuiaVenta_FechaTransporteAsync(int idEmpresa, int codigoUsuario, int Op, string transaccion, string id_agenda, int estado);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_ListarGlobal", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_ListarGlobalResponse")]
        GS.SISGEGS.DM.gsGuiaVentas_FechasGlobalResult[] GuiaVenta_ListarGlobal(int idEmpresa, int codigoUsuario, string id_agenda, System.DateTime fInicio, System.DateTime fFin, string id_item, int ID_Almacen, int OP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_ListarGlobal", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_ListarGlobalResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.gsGuiaVentas_FechasGlobalResult[]> GuiaVenta_ListarGlobalAsync(int idEmpresa, int codigoUsuario, string id_agenda, System.DateTime fInicio, System.DateTime fFin, string id_item, int ID_Almacen, int OP);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_Modificar", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_ModificarResponse")]
        void GuiaVenta_Modificar(int idEmpresa, int codigoUsuario, int Op, string transaccion, string id_agenda, int usuarioE, System.DateTime fechaEmision, int usuarioS, System.DateTime fechaSeguridad, int usuarioC, System.DateTime fechaCliente, int estado, int id_vehiculo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_Modificar", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_ModificarResponse")]
        System.Threading.Tasks.Task GuiaVenta_ModificarAsync(int idEmpresa, int codigoUsuario, int Op, string transaccion, string id_agenda, int usuarioE, System.DateTime fechaEmision, int usuarioS, System.DateTime fechaSeguridad, int usuarioC, System.DateTime fechaCliente, int estado, int id_vehiculo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_Registrar", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_RegistrarResponse")]
        void GuiaVenta_Registrar(int idEmpresa, int codigoUsuario, GS.SISGEGS.DM.gsGuia_BuscarCabeceraResult objGuiaVentaCabBE, GS.SISGEGS.DM.gsGuia_BuscarDetalleResult[] lstProductos, System.Nullable<decimal> idOperacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_Registrar", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_RegistrarResponse")]
        System.Threading.Tasks.Task GuiaVenta_RegistrarAsync(int idEmpresa, int codigoUsuario, GS.SISGEGS.DM.gsGuia_BuscarCabeceraResult objGuiaVentaCabBE, GS.SISGEGS.DM.gsGuia_BuscarDetalleResult[] lstProductos, System.Nullable<decimal> idOperacion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_Buscar", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_BuscarResponse")]
        GS.SISGEGS.WINPedidos.GuiaWCF.GuiaVenta_BuscarResponse GuiaVenta_Buscar(GS.SISGEGS.WINPedidos.GuiaWCF.GuiaVenta_BuscarRequest request);
        
        // CODEGEN: Generando contrato de mensaje, ya que la operación tiene múltiples valores de devolución.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IGuiaWCF/GuiaVenta_Buscar", ReplyAction="http://tempuri.org/IGuiaWCF/GuiaVenta_BuscarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.WINPedidos.GuiaWCF.GuiaVenta_BuscarResponse> GuiaVenta_BuscarAsync(GS.SISGEGS.WINPedidos.GuiaWCF.GuiaVenta_BuscarRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GuiaVenta_Buscar", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GuiaVenta_BuscarRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int idEmpresa;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public int codigoUsuario;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public int idPedido;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public GS.SISGEGS.DM.gsGuia_BuscarDetalleResult[] objOrdenVentaDet;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=4)]
        public System.Nullable<bool> bloqueado;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=5)]
        public string mensajeBloqueado;
        
        public GuiaVenta_BuscarRequest() {
        }
        
        public GuiaVenta_BuscarRequest(int idEmpresa, int codigoUsuario, int idPedido, GS.SISGEGS.DM.gsGuia_BuscarDetalleResult[] objOrdenVentaDet, System.Nullable<bool> bloqueado, string mensajeBloqueado) {
            this.idEmpresa = idEmpresa;
            this.codigoUsuario = codigoUsuario;
            this.idPedido = idPedido;
            this.objOrdenVentaDet = objOrdenVentaDet;
            this.bloqueado = bloqueado;
            this.mensajeBloqueado = mensajeBloqueado;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(WrapperName="GuiaVenta_BuscarResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class GuiaVenta_BuscarResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public GS.SISGEGS.DM.gsGuia_BuscarCabeceraResult GuiaVenta_BuscarResult;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public GS.SISGEGS.DM.gsGuia_BuscarDetalleResult[] objOrdenVentaDet;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public System.Nullable<bool> bloqueado;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=3)]
        public string mensajeBloqueado;
        
        public GuiaVenta_BuscarResponse() {
        }
        
        public GuiaVenta_BuscarResponse(GS.SISGEGS.DM.gsGuia_BuscarCabeceraResult GuiaVenta_BuscarResult, GS.SISGEGS.DM.gsGuia_BuscarDetalleResult[] objOrdenVentaDet, System.Nullable<bool> bloqueado, string mensajeBloqueado) {
            this.GuiaVenta_BuscarResult = GuiaVenta_BuscarResult;
            this.objOrdenVentaDet = objOrdenVentaDet;
            this.bloqueado = bloqueado;
            this.mensajeBloqueado = mensajeBloqueado;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGuiaWCFChannel : GS.SISGEGS.WINPedidos.GuiaWCF.IGuiaWCF, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GuiaWCFClient : System.ServiceModel.ClientBase<GS.SISGEGS.WINPedidos.GuiaWCF.IGuiaWCF>, GS.SISGEGS.WINPedidos.GuiaWCF.IGuiaWCF {
        
        public GuiaWCFClient() {
        }
        
        public GuiaWCFClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GuiaWCFClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GuiaWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GuiaWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GS.SISGEGS.DM.gsGuiaVenta_ListarXPedidoResult[] GuiaVenta_ListarxPedido(int idEmpresa, int codigoUsuario, int idPedido) {
            return base.Channel.GuiaVenta_ListarxPedido(idEmpresa, codigoUsuario, idPedido);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.gsGuiaVenta_ListarXPedidoResult[]> GuiaVenta_ListarxPedidoAsync(int idEmpresa, int codigoUsuario, int idPedido) {
            return base.Channel.GuiaVenta_ListarxPedidoAsync(idEmpresa, codigoUsuario, idPedido);
        }
        
        public GS.SISGEGS.DM.gsGuiaVentas_listarResult[] GuiaVenta_Listar(int idEmpresa, int codigoUsuario, string id_agenda, System.DateTime fInicio, System.DateTime fFin, string id_item, int ID_Almacen, int OP) {
            return base.Channel.GuiaVenta_Listar(idEmpresa, codigoUsuario, id_agenda, fInicio, fFin, id_item, ID_Almacen, OP);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.gsGuiaVentas_listarResult[]> GuiaVenta_ListarAsync(int idEmpresa, int codigoUsuario, string id_agenda, System.DateTime fInicio, System.DateTime fFin, string id_item, int ID_Almacen, int OP) {
            return base.Channel.GuiaVenta_ListarAsync(idEmpresa, codigoUsuario, id_agenda, fInicio, fFin, id_item, ID_Almacen, OP);
        }
        
        public GS.SISGEGS.DM.gsGuiaVenta_ListarxOPResult[] GuiaVenta_ListarxOP(int idEmpresa, int codigoUsuario, int idOperacion) {
            return base.Channel.GuiaVenta_ListarxOP(idEmpresa, codigoUsuario, idOperacion);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.gsGuiaVenta_ListarxOPResult[]> GuiaVenta_ListarxOPAsync(int idEmpresa, int codigoUsuario, int idOperacion) {
            return base.Channel.GuiaVenta_ListarxOPAsync(idEmpresa, codigoUsuario, idOperacion);
        }
        
        public void GuiaVenta_ActualizarTransporte(int idEmpresa, int codigoUsuario, GS.SISGEGS.DM.gsGuiaVenta_ListarxOPResult objGuiaVentaLista, decimal idOperacion) {
            base.Channel.GuiaVenta_ActualizarTransporte(idEmpresa, codigoUsuario, objGuiaVentaLista, idOperacion);
        }
        
        public System.Threading.Tasks.Task GuiaVenta_ActualizarTransporteAsync(int idEmpresa, int codigoUsuario, GS.SISGEGS.DM.gsGuiaVenta_ListarxOPResult objGuiaVentaLista, decimal idOperacion) {
            return base.Channel.GuiaVenta_ActualizarTransporteAsync(idEmpresa, codigoUsuario, objGuiaVentaLista, idOperacion);
        }
        
        public void GuiaVenta_FechaInsertar(int idEmpresa, int codigoUsuario, int Op, string transaccion, string id_agenda, System.DateTime fechaEmision, int id_vehiculo, int estado) {
            base.Channel.GuiaVenta_FechaInsertar(idEmpresa, codigoUsuario, Op, transaccion, id_agenda, fechaEmision, id_vehiculo, estado);
        }
        
        public System.Threading.Tasks.Task GuiaVenta_FechaInsertarAsync(int idEmpresa, int codigoUsuario, int Op, string transaccion, string id_agenda, System.DateTime fechaEmision, int id_vehiculo, int estado) {
            return base.Channel.GuiaVenta_FechaInsertarAsync(idEmpresa, codigoUsuario, Op, transaccion, id_agenda, fechaEmision, id_vehiculo, estado);
        }
        
        public GS.SISGEGS.DM.gsGuiaVentas_FechaslistarResult[] GuiaVenta_FechasListar(int idEmpresa, int codigoUsuario, string id_agenda, System.DateTime fInicio, System.DateTime fFin, string id_item, int ID_Almacen, int OP) {
            return base.Channel.GuiaVenta_FechasListar(idEmpresa, codigoUsuario, id_agenda, fInicio, fFin, id_item, ID_Almacen, OP);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.gsGuiaVentas_FechaslistarResult[]> GuiaVenta_FechasListarAsync(int idEmpresa, int codigoUsuario, string id_agenda, System.DateTime fInicio, System.DateTime fFin, string id_item, int ID_Almacen, int OP) {
            return base.Channel.GuiaVenta_FechasListarAsync(idEmpresa, codigoUsuario, id_agenda, fInicio, fFin, id_item, ID_Almacen, OP);
        }
        
        public GS.SISGEGS.DM.gsGuiaVentas_TransitolistarResult[] GuiaVenta_TransitoListar(int idEmpresa, int codigoUsuario, string id_agenda, System.DateTime fInicio, System.DateTime fFin, string id_item, int ID_Almacen, int OP, int id_vehiculo) {
            return base.Channel.GuiaVenta_TransitoListar(idEmpresa, codigoUsuario, id_agenda, fInicio, fFin, id_item, ID_Almacen, OP, id_vehiculo);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.gsGuiaVentas_TransitolistarResult[]> GuiaVenta_TransitoListarAsync(int idEmpresa, int codigoUsuario, string id_agenda, System.DateTime fInicio, System.DateTime fFin, string id_item, int ID_Almacen, int OP, int id_vehiculo) {
            return base.Channel.GuiaVenta_TransitoListarAsync(idEmpresa, codigoUsuario, id_agenda, fInicio, fFin, id_item, ID_Almacen, OP, id_vehiculo);
        }
        
        public void GuiaVenta_FechaTransporte(int idEmpresa, int codigoUsuario, int Op, string transaccion, string id_agenda, int estado) {
            base.Channel.GuiaVenta_FechaTransporte(idEmpresa, codigoUsuario, Op, transaccion, id_agenda, estado);
        }
        
        public System.Threading.Tasks.Task GuiaVenta_FechaTransporteAsync(int idEmpresa, int codigoUsuario, int Op, string transaccion, string id_agenda, int estado) {
            return base.Channel.GuiaVenta_FechaTransporteAsync(idEmpresa, codigoUsuario, Op, transaccion, id_agenda, estado);
        }
        
        public GS.SISGEGS.DM.gsGuiaVentas_FechasGlobalResult[] GuiaVenta_ListarGlobal(int idEmpresa, int codigoUsuario, string id_agenda, System.DateTime fInicio, System.DateTime fFin, string id_item, int ID_Almacen, int OP) {
            return base.Channel.GuiaVenta_ListarGlobal(idEmpresa, codigoUsuario, id_agenda, fInicio, fFin, id_item, ID_Almacen, OP);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.gsGuiaVentas_FechasGlobalResult[]> GuiaVenta_ListarGlobalAsync(int idEmpresa, int codigoUsuario, string id_agenda, System.DateTime fInicio, System.DateTime fFin, string id_item, int ID_Almacen, int OP) {
            return base.Channel.GuiaVenta_ListarGlobalAsync(idEmpresa, codigoUsuario, id_agenda, fInicio, fFin, id_item, ID_Almacen, OP);
        }
        
        public void GuiaVenta_Modificar(int idEmpresa, int codigoUsuario, int Op, string transaccion, string id_agenda, int usuarioE, System.DateTime fechaEmision, int usuarioS, System.DateTime fechaSeguridad, int usuarioC, System.DateTime fechaCliente, int estado, int id_vehiculo) {
            base.Channel.GuiaVenta_Modificar(idEmpresa, codigoUsuario, Op, transaccion, id_agenda, usuarioE, fechaEmision, usuarioS, fechaSeguridad, usuarioC, fechaCliente, estado, id_vehiculo);
        }
        
        public System.Threading.Tasks.Task GuiaVenta_ModificarAsync(int idEmpresa, int codigoUsuario, int Op, string transaccion, string id_agenda, int usuarioE, System.DateTime fechaEmision, int usuarioS, System.DateTime fechaSeguridad, int usuarioC, System.DateTime fechaCliente, int estado, int id_vehiculo) {
            return base.Channel.GuiaVenta_ModificarAsync(idEmpresa, codigoUsuario, Op, transaccion, id_agenda, usuarioE, fechaEmision, usuarioS, fechaSeguridad, usuarioC, fechaCliente, estado, id_vehiculo);
        }
        
        public void GuiaVenta_Registrar(int idEmpresa, int codigoUsuario, GS.SISGEGS.DM.gsGuia_BuscarCabeceraResult objGuiaVentaCabBE, GS.SISGEGS.DM.gsGuia_BuscarDetalleResult[] lstProductos, System.Nullable<decimal> idOperacion) {
            base.Channel.GuiaVenta_Registrar(idEmpresa, codigoUsuario, objGuiaVentaCabBE, lstProductos, idOperacion);
        }
        
        public System.Threading.Tasks.Task GuiaVenta_RegistrarAsync(int idEmpresa, int codigoUsuario, GS.SISGEGS.DM.gsGuia_BuscarCabeceraResult objGuiaVentaCabBE, GS.SISGEGS.DM.gsGuia_BuscarDetalleResult[] lstProductos, System.Nullable<decimal> idOperacion) {
            return base.Channel.GuiaVenta_RegistrarAsync(idEmpresa, codigoUsuario, objGuiaVentaCabBE, lstProductos, idOperacion);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        GS.SISGEGS.WINPedidos.GuiaWCF.GuiaVenta_BuscarResponse GS.SISGEGS.WINPedidos.GuiaWCF.IGuiaWCF.GuiaVenta_Buscar(GS.SISGEGS.WINPedidos.GuiaWCF.GuiaVenta_BuscarRequest request) {
            return base.Channel.GuiaVenta_Buscar(request);
        }
        
        public GS.SISGEGS.DM.gsGuia_BuscarCabeceraResult GuiaVenta_Buscar(int idEmpresa, int codigoUsuario, int idPedido, ref GS.SISGEGS.DM.gsGuia_BuscarDetalleResult[] objOrdenVentaDet, ref System.Nullable<bool> bloqueado, ref string mensajeBloqueado) {
            GS.SISGEGS.WINPedidos.GuiaWCF.GuiaVenta_BuscarRequest inValue = new GS.SISGEGS.WINPedidos.GuiaWCF.GuiaVenta_BuscarRequest();
            inValue.idEmpresa = idEmpresa;
            inValue.codigoUsuario = codigoUsuario;
            inValue.idPedido = idPedido;
            inValue.objOrdenVentaDet = objOrdenVentaDet;
            inValue.bloqueado = bloqueado;
            inValue.mensajeBloqueado = mensajeBloqueado;
            GS.SISGEGS.WINPedidos.GuiaWCF.GuiaVenta_BuscarResponse retVal = ((GS.SISGEGS.WINPedidos.GuiaWCF.IGuiaWCF)(this)).GuiaVenta_Buscar(inValue);
            objOrdenVentaDet = retVal.objOrdenVentaDet;
            bloqueado = retVal.bloqueado;
            mensajeBloqueado = retVal.mensajeBloqueado;
            return retVal.GuiaVenta_BuscarResult;
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.WINPedidos.GuiaWCF.GuiaVenta_BuscarResponse> GuiaVenta_BuscarAsync(GS.SISGEGS.WINPedidos.GuiaWCF.GuiaVenta_BuscarRequest request) {
            return base.Channel.GuiaVenta_BuscarAsync(request);
        }
    }
}
