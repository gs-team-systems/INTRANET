﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GS.SISGEGS.Web.MarcasWCF {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MarcasWCF.IMarcasWCF")]
    public interface IMarcasWCF {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/TitularMarca_Listar", ReplyAction="http://tempuri.org/IMarcasWCF/TitularMarca_ListarResponse")]
        GS.SISGEGS.DM.TitularMarca_ListarResult[] TitularMarca_Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/TitularMarca_Listar", ReplyAction="http://tempuri.org/IMarcasWCF/TitularMarca_ListarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.TitularMarca_ListarResult[]> TitularMarca_ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/RegistroMarca_Listar", ReplyAction="http://tempuri.org/IMarcasWCF/RegistroMarca_ListarResponse")]
        GS.SISGEGS.DM.RegistroMarca_Listar_v2Result[] RegistroMarca_Listar(int idEmpresa, string marca, int idTipo, int idPais, int idTitular, System.DateTime fechaInicio, System.DateTime fechaFin, string clase, int todo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/RegistroMarca_Listar", ReplyAction="http://tempuri.org/IMarcasWCF/RegistroMarca_ListarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.RegistroMarca_Listar_v2Result[]> RegistroMarca_ListarAsync(int idEmpresa, string marca, int idTipo, int idPais, int idTitular, System.DateTime fechaInicio, System.DateTime fechaFin, string clase, int todo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/TipoMarca_Listar", ReplyAction="http://tempuri.org/IMarcasWCF/TipoMarca_ListarResponse")]
        GS.SISGEGS.DM.TipoMarca_ListarResult[] TipoMarca_Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/TipoMarca_Listar", ReplyAction="http://tempuri.org/IMarcasWCF/TipoMarca_ListarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.TipoMarca_ListarResult[]> TipoMarca_ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/Pais_Listar", ReplyAction="http://tempuri.org/IMarcasWCF/Pais_ListarResponse")]
        GS.SISGEGS.DM.Pais_ListarResult[] Pais_Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/Pais_Listar", ReplyAction="http://tempuri.org/IMarcasWCF/Pais_ListarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.Pais_ListarResult[]> Pais_ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/Marca_Listar", ReplyAction="http://tempuri.org/IMarcasWCF/Marca_ListarResponse")]
        GS.SISGEGS.DM.Marca_ListarResult[] Marca_Listar(string nombreMarca);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/Marca_Listar", ReplyAction="http://tempuri.org/IMarcasWCF/Marca_ListarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.Marca_ListarResult[]> Marca_ListarAsync(string nombreMarca);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/ResponsablesRegistros_Listar", ReplyAction="http://tempuri.org/IMarcasWCF/ResponsablesRegistros_ListarResponse")]
        GS.SISGEGS.DM.ResponsablesRegistros_ListarResult[] ResponsablesRegistros_Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/ResponsablesRegistros_Listar", ReplyAction="http://tempuri.org/IMarcasWCF/ResponsablesRegistros_ListarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.ResponsablesRegistros_ListarResult[]> ResponsablesRegistros_ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/RegistroMarca_Notificacion", ReplyAction="http://tempuri.org/IMarcasWCF/RegistroMarca_NotificacionResponse")]
        GS.SISGEGS.DM.RegistroMarca_NotificacionResult[] RegistroMarca_Notificacion();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/RegistroMarca_Notificacion", ReplyAction="http://tempuri.org/IMarcasWCF/RegistroMarca_NotificacionResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.RegistroMarca_NotificacionResult[]> RegistroMarca_NotificacionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/EstadoMarca_Listar", ReplyAction="http://tempuri.org/IMarcasWCF/EstadoMarca_ListarResponse")]
        GS.SISGEGS.DM.EstadoMarca_ListarResult[] EstadoMarca_Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/EstadoMarca_Listar", ReplyAction="http://tempuri.org/IMarcasWCF/EstadoMarca_ListarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.EstadoMarca_ListarResult[]> EstadoMarca_ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/RegistroMarca_Obtener", ReplyAction="http://tempuri.org/IMarcasWCF/RegistroMarca_ObtenerResponse")]
        GS.SISGEGS.DM.RegistroMarca_ObtenerResult RegistroMarca_Obtener(int idRegistroMarca);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/RegistroMarca_Obtener", ReplyAction="http://tempuri.org/IMarcasWCF/RegistroMarca_ObtenerResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.RegistroMarca_ObtenerResult> RegistroMarca_ObtenerAsync(int idRegistroMarca);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/RegistroMarca_Registrar", ReplyAction="http://tempuri.org/IMarcasWCF/RegistroMarca_RegistrarResponse")]
        void RegistroMarca_Registrar(int idMarca, int idEmpresa, string marca, int idPais, int idTipo, int idTitular, string clase, string certificado, System.DateTime fechaVencimiento, int idEstadoMarca, string observacion, int usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/RegistroMarca_Registrar", ReplyAction="http://tempuri.org/IMarcasWCF/RegistroMarca_RegistrarResponse")]
        System.Threading.Tasks.Task RegistroMarca_RegistrarAsync(int idMarca, int idEmpresa, string marca, int idPais, int idTipo, int idTitular, string clase, string certificado, System.DateTime fechaVencimiento, int idEstadoMarca, string observacion, int usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/HistoricoMarca_Listar", ReplyAction="http://tempuri.org/IMarcasWCF/HistoricoMarca_ListarResponse")]
        GS.SISGEGS.DM.RegistroMarcaHistorico_ListarResult[] HistoricoMarca_Listar(int idMarca, System.DateTime FechanVencimientoIni, System.DateTime FechaVencimientoFin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/HistoricoMarca_Listar", ReplyAction="http://tempuri.org/IMarcasWCF/HistoricoMarca_ListarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.RegistroMarcaHistorico_ListarResult[]> HistoricoMarca_ListarAsync(int idMarca, System.DateTime FechanVencimientoIni, System.DateTime FechaVencimientoFin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/DocumentoMarca_Registrar", ReplyAction="http://tempuri.org/IMarcasWCF/DocumentoMarca_RegistrarResponse")]
        void DocumentoMarca_Registrar(int idRegistroMarca, int idTipoDocumento, string documento, string ruta, int usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/DocumentoMarca_Registrar", ReplyAction="http://tempuri.org/IMarcasWCF/DocumentoMarca_RegistrarResponse")]
        System.Threading.Tasks.Task DocumentoMarca_RegistrarAsync(int idRegistroMarca, int idTipoDocumento, string documento, string ruta, int usuario);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/DocumentoMarca_Listar", ReplyAction="http://tempuri.org/IMarcasWCF/DocumentoMarca_ListarResponse")]
        GS.SISGEGS.DM.DocumentosMarca_ListarResult[] DocumentoMarca_Listar(int idRegistroMarca, int idTipoDocumentoMarca);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/DocumentoMarca_Listar", ReplyAction="http://tempuri.org/IMarcasWCF/DocumentoMarca_ListarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.DocumentosMarca_ListarResult[]> DocumentoMarca_ListarAsync(int idRegistroMarca, int idTipoDocumentoMarca);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/DocumentoMarca_Eliminar", ReplyAction="http://tempuri.org/IMarcasWCF/DocumentoMarca_EliminarResponse")]
        void DocumentoMarca_Eliminar(int idDocumento, int idRegistroMarca);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/DocumentoMarca_Eliminar", ReplyAction="http://tempuri.org/IMarcasWCF/DocumentoMarca_EliminarResponse")]
        System.Threading.Tasks.Task DocumentoMarca_EliminarAsync(int idDocumento, int idRegistroMarca);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/TipoDocumentoMarca_Listar", ReplyAction="http://tempuri.org/IMarcasWCF/TipoDocumentoMarca_ListarResponse")]
        GS.SISGEGS.DM.TipoDocumentoMarca_ListarResult[] TipoDocumentoMarca_Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/TipoDocumentoMarca_Listar", ReplyAction="http://tempuri.org/IMarcasWCF/TipoDocumentoMarca_ListarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.TipoDocumentoMarca_ListarResult[]> TipoDocumentoMarca_ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/ClaseMarca_Listar", ReplyAction="http://tempuri.org/IMarcasWCF/ClaseMarca_ListarResponse")]
        GS.SISGEGS.DM.ClaseMarca_ListarResult[] ClaseMarca_Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcasWCF/ClaseMarca_Listar", ReplyAction="http://tempuri.org/IMarcasWCF/ClaseMarca_ListarResponse")]
        System.Threading.Tasks.Task<GS.SISGEGS.DM.ClaseMarca_ListarResult[]> ClaseMarca_ListarAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMarcasWCFChannel : GS.SISGEGS.Web.MarcasWCF.IMarcasWCF, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MarcasWCFClient : System.ServiceModel.ClientBase<GS.SISGEGS.Web.MarcasWCF.IMarcasWCF>, GS.SISGEGS.Web.MarcasWCF.IMarcasWCF {
        
        public MarcasWCFClient() {
        }
        
        public MarcasWCFClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MarcasWCFClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MarcasWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MarcasWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GS.SISGEGS.DM.TitularMarca_ListarResult[] TitularMarca_Listar() {
            return base.Channel.TitularMarca_Listar();
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.TitularMarca_ListarResult[]> TitularMarca_ListarAsync() {
            return base.Channel.TitularMarca_ListarAsync();
        }
        
        public GS.SISGEGS.DM.RegistroMarca_Listar_v2Result[] RegistroMarca_Listar(int idEmpresa, string marca, int idTipo, int idPais, int idTitular, System.DateTime fechaInicio, System.DateTime fechaFin, string clase, int todo) {
            return base.Channel.RegistroMarca_Listar(idEmpresa, marca, idTipo, idPais, idTitular, fechaInicio, fechaFin, clase, todo);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.RegistroMarca_Listar_v2Result[]> RegistroMarca_ListarAsync(int idEmpresa, string marca, int idTipo, int idPais, int idTitular, System.DateTime fechaInicio, System.DateTime fechaFin, string clase, int todo) {
            return base.Channel.RegistroMarca_ListarAsync(idEmpresa, marca, idTipo, idPais, idTitular, fechaInicio, fechaFin, clase, todo);
        }
        
        public GS.SISGEGS.DM.TipoMarca_ListarResult[] TipoMarca_Listar() {
            return base.Channel.TipoMarca_Listar();
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.TipoMarca_ListarResult[]> TipoMarca_ListarAsync() {
            return base.Channel.TipoMarca_ListarAsync();
        }
        
        public GS.SISGEGS.DM.Pais_ListarResult[] Pais_Listar() {
            return base.Channel.Pais_Listar();
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.Pais_ListarResult[]> Pais_ListarAsync() {
            return base.Channel.Pais_ListarAsync();
        }
        
        public GS.SISGEGS.DM.Marca_ListarResult[] Marca_Listar(string nombreMarca) {
            return base.Channel.Marca_Listar(nombreMarca);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.Marca_ListarResult[]> Marca_ListarAsync(string nombreMarca) {
            return base.Channel.Marca_ListarAsync(nombreMarca);
        }
        
        public GS.SISGEGS.DM.ResponsablesRegistros_ListarResult[] ResponsablesRegistros_Listar() {
            return base.Channel.ResponsablesRegistros_Listar();
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.ResponsablesRegistros_ListarResult[]> ResponsablesRegistros_ListarAsync() {
            return base.Channel.ResponsablesRegistros_ListarAsync();
        }
        
        public GS.SISGEGS.DM.RegistroMarca_NotificacionResult[] RegistroMarca_Notificacion() {
            return base.Channel.RegistroMarca_Notificacion();
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.RegistroMarca_NotificacionResult[]> RegistroMarca_NotificacionAsync() {
            return base.Channel.RegistroMarca_NotificacionAsync();
        }
        
        public GS.SISGEGS.DM.EstadoMarca_ListarResult[] EstadoMarca_Listar() {
            return base.Channel.EstadoMarca_Listar();
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.EstadoMarca_ListarResult[]> EstadoMarca_ListarAsync() {
            return base.Channel.EstadoMarca_ListarAsync();
        }
        
        public GS.SISGEGS.DM.RegistroMarca_ObtenerResult RegistroMarca_Obtener(int idRegistroMarca) {
            return base.Channel.RegistroMarca_Obtener(idRegistroMarca);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.RegistroMarca_ObtenerResult> RegistroMarca_ObtenerAsync(int idRegistroMarca) {
            return base.Channel.RegistroMarca_ObtenerAsync(idRegistroMarca);
        }
        
        public void RegistroMarca_Registrar(int idMarca, int idEmpresa, string marca, int idPais, int idTipo, int idTitular, string clase, string certificado, System.DateTime fechaVencimiento, int idEstadoMarca, string observacion, int usuario) {
            base.Channel.RegistroMarca_Registrar(idMarca, idEmpresa, marca, idPais, idTipo, idTitular, clase, certificado, fechaVencimiento, idEstadoMarca, observacion, usuario);
        }
        
        public System.Threading.Tasks.Task RegistroMarca_RegistrarAsync(int idMarca, int idEmpresa, string marca, int idPais, int idTipo, int idTitular, string clase, string certificado, System.DateTime fechaVencimiento, int idEstadoMarca, string observacion, int usuario) {
            return base.Channel.RegistroMarca_RegistrarAsync(idMarca, idEmpresa, marca, idPais, idTipo, idTitular, clase, certificado, fechaVencimiento, idEstadoMarca, observacion, usuario);
        }
        
        public GS.SISGEGS.DM.RegistroMarcaHistorico_ListarResult[] HistoricoMarca_Listar(int idMarca, System.DateTime FechanVencimientoIni, System.DateTime FechaVencimientoFin) {
            return base.Channel.HistoricoMarca_Listar(idMarca, FechanVencimientoIni, FechaVencimientoFin);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.RegistroMarcaHistorico_ListarResult[]> HistoricoMarca_ListarAsync(int idMarca, System.DateTime FechanVencimientoIni, System.DateTime FechaVencimientoFin) {
            return base.Channel.HistoricoMarca_ListarAsync(idMarca, FechanVencimientoIni, FechaVencimientoFin);
        }
        
        public void DocumentoMarca_Registrar(int idRegistroMarca, int idTipoDocumento, string documento, string ruta, int usuario) {
            base.Channel.DocumentoMarca_Registrar(idRegistroMarca, idTipoDocumento, documento, ruta, usuario);
        }
        
        public System.Threading.Tasks.Task DocumentoMarca_RegistrarAsync(int idRegistroMarca, int idTipoDocumento, string documento, string ruta, int usuario) {
            return base.Channel.DocumentoMarca_RegistrarAsync(idRegistroMarca, idTipoDocumento, documento, ruta, usuario);
        }
        
        public GS.SISGEGS.DM.DocumentosMarca_ListarResult[] DocumentoMarca_Listar(int idRegistroMarca, int idTipoDocumentoMarca) {
            return base.Channel.DocumentoMarca_Listar(idRegistroMarca, idTipoDocumentoMarca);
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.DocumentosMarca_ListarResult[]> DocumentoMarca_ListarAsync(int idRegistroMarca, int idTipoDocumentoMarca) {
            return base.Channel.DocumentoMarca_ListarAsync(idRegistroMarca, idTipoDocumentoMarca);
        }
        
        public void DocumentoMarca_Eliminar(int idDocumento, int idRegistroMarca) {
            base.Channel.DocumentoMarca_Eliminar(idDocumento, idRegistroMarca);
        }
        
        public System.Threading.Tasks.Task DocumentoMarca_EliminarAsync(int idDocumento, int idRegistroMarca) {
            return base.Channel.DocumentoMarca_EliminarAsync(idDocumento, idRegistroMarca);
        }
        
        public GS.SISGEGS.DM.TipoDocumentoMarca_ListarResult[] TipoDocumentoMarca_Listar() {
            return base.Channel.TipoDocumentoMarca_Listar();
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.TipoDocumentoMarca_ListarResult[]> TipoDocumentoMarca_ListarAsync() {
            return base.Channel.TipoDocumentoMarca_ListarAsync();
        }
        
        public GS.SISGEGS.DM.ClaseMarca_ListarResult[] ClaseMarca_Listar() {
            return base.Channel.ClaseMarca_Listar();
        }
        
        public System.Threading.Tasks.Task<GS.SISGEGS.DM.ClaseMarca_ListarResult[]> ClaseMarca_ListarAsync() {
            return base.Channel.ClaseMarca_ListarAsync();
        }
    }
}