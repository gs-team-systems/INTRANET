﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GS.SISGEGS.WINPedidos.WmsWCF {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WmsWCF.IWmsWCF")]
    public interface IWmsWCF {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWmsWCF/WmsPendientes_Envio", ReplyAction="http://tempuri.org/IWmsWCF/WmsPendientes_EnvioResponse")]
        GS.SISGEGS.DM.gsWMSPendientes_EnvioResult[] WmsPendientes_Envio(int idEmpresa, int codigoUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWmsWCF/WmsPendientes_Envio", ReplyAction="http://tempuri.org/IWmsWCF/WmsPendientes_EnvioResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.gsWMSPendientes_EnvioResult[]> WmsPendientes_EnvioAsync(int idEmpresa, int codigoUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWmsWCF/WmsProduccion_PendientesRecibir", ReplyAction="http://tempuri.org/IWmsWCF/WmsProduccion_PendientesRecibirResponse")]
        GS.SISGEGS.DM.gsWMSProduccion_PendientesRecibirResult[] WmsProduccion_PendientesRecibir(int idEmpresa, int codigoUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWmsWCF/WmsProduccion_PendientesRecibir", ReplyAction="http://tempuri.org/IWmsWCF/WmsProduccion_PendientesRecibirResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.gsWMSProduccion_PendientesRecibirResult[]> WmsProduccion_PendientesRecibirAsync(int idEmpresa, int codigoUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWmsWCF/WMS_RegistrarGuiaCompra", ReplyAction="http://tempuri.org/IWmsWCF/WMS_RegistrarGuiaCompraResponse")]
        int WMS_RegistrarGuiaCompra(int idEmpresa, int codigoUsuario, string idAlmacen, string idAgenda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWmsWCF/WMS_RegistrarGuiaCompra", ReplyAction="http://tempuri.org/IWmsWCF/WMS_RegistrarGuiaCompraResponse")]
        System.Threading.Tasks.Task<int> WMS_RegistrarGuiaCompraAsync(int idEmpresa, int codigoUsuario, string idAlmacen, string idAgenda);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWmsWCF/WMS_ObtenerOrdenCompra", ReplyAction="http://tempuri.org/IWmsWCF/WMS_ObtenerOrdenCompraResponse")]
        GS.SISGEGS.DM.WMS_ObtenerOrdenCompraResult WMS_ObtenerOrdenCompra(int idEmpresa, int codigoUsuario, string nroRegistro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWmsWCF/WMS_ObtenerOrdenCompra", ReplyAction="http://tempuri.org/IWmsWCF/WMS_ObtenerOrdenCompraResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.WMS_ObtenerOrdenCompraResult> WMS_ObtenerOrdenCompraAsync(int idEmpresa, int codigoUsuario, string nroRegistro);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWmsWCF/WMS_RegistrarGuiaCompraLinea", ReplyAction="http://tempuri.org/IWmsWCF/WMS_RegistrarGuiaCompraLineaResponse")]
        int WMS_RegistrarGuiaCompraLinea(int idEmpresa, int codigoUsuario, int Op, int OrdenCompraOp, string item, int unidadesRecibidas, string noLote);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWmsWCF/WMS_RegistrarGuiaCompraLinea", ReplyAction="http://tempuri.org/IWmsWCF/WMS_RegistrarGuiaCompraLineaResponse")]
        System.Threading.Tasks.Task<int> WMS_RegistrarGuiaCompraLineaAsync(int idEmpresa, int codigoUsuario, int Op, int OrdenCompraOp, string item, int unidadesRecibidas, string noLote);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWmsWCF/ProcesarGuiaCompra", ReplyAction="http://tempuri.org/IWmsWCF/ProcesarGuiaCompraResponse")]
        void ProcesarGuiaCompra(int idEmpresa, int codigoUsuario, int op);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWmsWCF/ProcesarGuiaCompra", ReplyAction="http://tempuri.org/IWmsWCF/ProcesarGuiaCompraResponse")]
        System.Threading.Tasks.Task ProcesarGuiaCompraAsync(int idEmpresa, int codigoUsuario, int op);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWmsWCF/WMS_Produccion_Recibir", ReplyAction="http://tempuri.org/IWmsWCF/WMS_Produccion_RecibirResponse")]
        int WMS_Produccion_Recibir(int idEmpresa, int codigoUsuario, string id_almacen, int almacenAnexo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWmsWCF/WMS_Produccion_Recibir", ReplyAction="http://tempuri.org/IWmsWCF/WMS_Produccion_RecibirResponse")]
        System.Threading.Tasks.Task<int> WMS_Produccion_RecibirAsync(int idEmpresa, int codigoUsuario, string id_almacen, int almacenAnexo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWmsWCF/WMS_ProduccionLinea_Recibir", ReplyAction="http://tempuri.org/IWmsWCF/WMS_ProduccionLinea_RecibirResponse")]
        int WMS_ProduccionLinea_Recibir(int idEmpresa, int codigoUsuario, int op, int linea, string ID_Item, int kardex, decimal cantidad, string lote, System.DateTime fechaFabricacion, System.DateTime fechaVencimiento, string proveedor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWmsWCF/WMS_ProduccionLinea_Recibir", ReplyAction="http://tempuri.org/IWmsWCF/WMS_ProduccionLinea_RecibirResponse")]
        System.Threading.Tasks.Task<int> WMS_ProduccionLinea_RecibirAsync(int idEmpresa, int codigoUsuario, int op, int linea, string ID_Item, int kardex, decimal cantidad, string lote, System.DateTime fechaFabricacion, System.DateTime fechaVencimiento, string proveedor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWmsWCF/WmsPedidosPendientes_Envio", ReplyAction="http://tempuri.org/IWmsWCF/WmsPedidosPendientes_EnvioResponse")]
        GS.SISGEGS.DM.VBG00518_WMSResult[] WmsPedidosPendientes_Envio(int idEmpresa, int codigoUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWmsWCF/WmsPedidosPendientes_Envio", ReplyAction="http://tempuri.org/IWmsWCF/WmsPedidosPendientes_EnvioResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.VBG00518_WMSResult[]> WmsPedidosPendientes_EnvioAsync(int idEmpresa, int codigoUsuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWmsWCF/WmsPedidosPendientes_Insertar", ReplyAction="http://tempuri.org/IWmsWCF/WmsPedidosPendientes_InsertarResponse")]
        void WmsPedidosPendientes_Insertar(int idEmpresa, int codigoUsuario, string NroPedido, string ID_Item, string Lote, decimal CantidadPedido, decimal CantidaEntregada, decimal CantidadPendiente, string EstadoPedido, int Id_Amarre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IWmsWCF/WmsPedidosPendientes_Insertar", ReplyAction="http://tempuri.org/IWmsWCF/WmsPedidosPendientes_InsertarResponse")]
        System.Threading.Tasks.Task WmsPedidosPendientes_InsertarAsync(int idEmpresa, int codigoUsuario, string NroPedido, string ID_Item, string Lote, decimal CantidadPedido, decimal CantidaEntregada, decimal CantidadPendiente, string EstadoPedido, int Id_Amarre);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IWmsWCFChannel : GS.SISGEGS.WINPedidos.WmsWCF.IWmsWCF, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WmsWCFClient : System.ServiceModel.ClientBase<GS.SISGEGS.WINPedidos.WmsWCF.IWmsWCF>, GS.SISGEGS.WINPedidos.WmsWCF.IWmsWCF {
        
        public WmsWCFClient() {
        }
        
        public WmsWCFClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WmsWCFClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WmsWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WmsWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GS.SISGEGS.DM.gsWMSPendientes_EnvioResult[] WmsPendientes_Envio(int idEmpresa, int codigoUsuario) {
            return base.Channel.WmsPendientes_Envio(idEmpresa, codigoUsuario);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.gsWMSPendientes_EnvioResult[]> WmsPendientes_EnvioAsync(int idEmpresa, int codigoUsuario) {
            return base.Channel.WmsPendientes_EnvioAsync(idEmpresa, codigoUsuario);
        }
        
        public GS.SISGEGS.DM.gsWMSProduccion_PendientesRecibirResult[] WmsProduccion_PendientesRecibir(int idEmpresa, int codigoUsuario) {
            return base.Channel.WmsProduccion_PendientesRecibir(idEmpresa, codigoUsuario);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.gsWMSProduccion_PendientesRecibirResult[]> WmsProduccion_PendientesRecibirAsync(int idEmpresa, int codigoUsuario) {
            return base.Channel.WmsProduccion_PendientesRecibirAsync(idEmpresa, codigoUsuario);
        }
        
        public int WMS_RegistrarGuiaCompra(int idEmpresa, int codigoUsuario, string idAlmacen, string idAgenda) {
            return base.Channel.WMS_RegistrarGuiaCompra(idEmpresa, codigoUsuario, idAlmacen, idAgenda);
        }
        
        public System.Threading.Tasks.Task<int> WMS_RegistrarGuiaCompraAsync(int idEmpresa, int codigoUsuario, string idAlmacen, string idAgenda) {
            return base.Channel.WMS_RegistrarGuiaCompraAsync(idEmpresa, codigoUsuario, idAlmacen, idAgenda);
        }
        
        public GS.SISGEGS.DM.WMS_ObtenerOrdenCompraResult WMS_ObtenerOrdenCompra(int idEmpresa, int codigoUsuario, string nroRegistro) {
            return base.Channel.WMS_ObtenerOrdenCompra(idEmpresa, codigoUsuario, nroRegistro);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.WMS_ObtenerOrdenCompraResult> WMS_ObtenerOrdenCompraAsync(int idEmpresa, int codigoUsuario, string nroRegistro) {
            return base.Channel.WMS_ObtenerOrdenCompraAsync(idEmpresa, codigoUsuario, nroRegistro);
        }
        
        public int WMS_RegistrarGuiaCompraLinea(int idEmpresa, int codigoUsuario, int Op, int OrdenCompraOp, string item, int unidadesRecibidas, string noLote) {
            return base.Channel.WMS_RegistrarGuiaCompraLinea(idEmpresa, codigoUsuario, Op, OrdenCompraOp, item, unidadesRecibidas, noLote);
        }
        
        public System.Threading.Tasks.Task<int> WMS_RegistrarGuiaCompraLineaAsync(int idEmpresa, int codigoUsuario, int Op, int OrdenCompraOp, string item, int unidadesRecibidas, string noLote) {
            return base.Channel.WMS_RegistrarGuiaCompraLineaAsync(idEmpresa, codigoUsuario, Op, OrdenCompraOp, item, unidadesRecibidas, noLote);
        }
        
        public void ProcesarGuiaCompra(int idEmpresa, int codigoUsuario, int op) {
            base.Channel.ProcesarGuiaCompra(idEmpresa, codigoUsuario, op);
        }
        
        public System.Threading.Tasks.Task ProcesarGuiaCompraAsync(int idEmpresa, int codigoUsuario, int op) {
            return base.Channel.ProcesarGuiaCompraAsync(idEmpresa, codigoUsuario, op);
        }
        
        public int WMS_Produccion_Recibir(int idEmpresa, int codigoUsuario, string id_almacen, int almacenAnexo) {
            return base.Channel.WMS_Produccion_Recibir(idEmpresa, codigoUsuario, id_almacen, almacenAnexo);
        }
        
        public System.Threading.Tasks.Task<int> WMS_Produccion_RecibirAsync(int idEmpresa, int codigoUsuario, string id_almacen, int almacenAnexo) {
            return base.Channel.WMS_Produccion_RecibirAsync(idEmpresa, codigoUsuario, id_almacen, almacenAnexo);
        }
        
        public int WMS_ProduccionLinea_Recibir(int idEmpresa, int codigoUsuario, int op, int linea, string ID_Item, int kardex, decimal cantidad, string lote, System.DateTime fechaFabricacion, System.DateTime fechaVencimiento, string proveedor) {
            return base.Channel.WMS_ProduccionLinea_Recibir(idEmpresa, codigoUsuario, op, linea, ID_Item, kardex, cantidad, lote, fechaFabricacion, fechaVencimiento, proveedor);
        }
        
        public System.Threading.Tasks.Task<int> WMS_ProduccionLinea_RecibirAsync(int idEmpresa, int codigoUsuario, int op, int linea, string ID_Item, int kardex, decimal cantidad, string lote, System.DateTime fechaFabricacion, System.DateTime fechaVencimiento, string proveedor) {
            return base.Channel.WMS_ProduccionLinea_RecibirAsync(idEmpresa, codigoUsuario, op, linea, ID_Item, kardex, cantidad, lote, fechaFabricacion, fechaVencimiento, proveedor);
        }
        
        public GS.SISGEGS.DM.VBG00518_WMSResult[] WmsPedidosPendientes_Envio(int idEmpresa, int codigoUsuario) {
            return base.Channel.WmsPedidosPendientes_Envio(idEmpresa, codigoUsuario);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.VBG00518_WMSResult[]> WmsPedidosPendientes_EnvioAsync(int idEmpresa, int codigoUsuario) {
            return base.Channel.WmsPedidosPendientes_EnvioAsync(idEmpresa, codigoUsuario);
        }
        
        public void WmsPedidosPendientes_Insertar(int idEmpresa, int codigoUsuario, string NroPedido, string ID_Item, string Lote, decimal CantidadPedido, decimal CantidaEntregada, decimal CantidadPendiente, string EstadoPedido, int Id_Amarre) {
            base.Channel.WmsPedidosPendientes_Insertar(idEmpresa, codigoUsuario, NroPedido, ID_Item, Lote, CantidadPedido, CantidaEntregada, CantidadPendiente, EstadoPedido, Id_Amarre);
        }
        
        public System.Threading.Tasks.Task WmsPedidosPendientes_InsertarAsync(int idEmpresa, int codigoUsuario, string NroPedido, string ID_Item, string Lote, decimal CantidadPedido, decimal CantidaEntregada, decimal CantidadPendiente, string EstadoPedido, int Id_Amarre) {
            return base.Channel.WmsPedidosPendientes_InsertarAsync(idEmpresa, codigoUsuario, NroPedido, ID_Item, Lote, CantidadPedido, CantidaEntregada, CantidadPendiente, EstadoPedido, Id_Amarre);
        }
    }
}
