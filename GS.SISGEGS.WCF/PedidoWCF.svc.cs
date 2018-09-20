﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using GS.SISGEGS.DM;
using GS.SISGEGS.BL;
using GS.SISGEGS.BE;

namespace GS.SISGEGS.WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "PedidoWCF" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione PedidoWCF.svc o PedidoWCF.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class PedidoWCF : IPedidoWCF
    {
        public gsPedido_BuscarCabeceraResult Pedido_BuscarCabecera(int idEmpresa, int codigoUsuario, int idPedido)
        {
            PedidoBL objPedidoBL;
            try
            {
                objPedidoBL = new PedidoBL();
                return objPedidoBL.Pedido_BuscarCabecera(idEmpresa, codigoUsuario, idPedido);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<gsPedido_BuscarDetalleResult> Pedido_BuscarDetalle(int idEmpresa, int codigoUsuario, int idPedido, decimal? idAlmacen)
        {
            PedidoBL objPedidoBL;
            try
            {
                objPedidoBL = new PedidoBL();
                return objPedidoBL.Pedido_BuscarDetalle(idEmpresa, codigoUsuario, idPedido, idAlmacen);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Pedido_Eliminar(int idEmpresa, int codigoUsuario, int idOperacion, string password)
        {
            PedidoBL objPedidoBL;
            try
            {
                objPedidoBL = new PedidoBL();
                objPedidoBL.Pedido_Eliminar(idEmpresa, codigoUsuario, idOperacion, password);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<gsPedido_ListarResult> Pedido_Listar(int? idEmpresa, int codigoUsuario, string idAgenda, DateTime fechaInicio, DateTime fechaFinal, int? idDocumento, string idVendedor, int? idFormaPago, decimal? estadoAprobacion, ref bool superUsuario)
        {
            PedidoBL objPedidoBL;
            try
            {
                objPedidoBL = new PedidoBL();
                return objPedidoBL.Pedido_Listar(idEmpresa, codigoUsuario, idAgenda, fechaInicio, fechaFinal, idDocumento, idVendedor, idFormaPago, estadoAprobacion, ref superUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<VBG03630Result> Pedido_ListarTipo(int idEmpresa, int codigoUsuario)
        {
            PedidoBL objPedidoBL;
            try
            {
                objPedidoBL = new PedidoBL();
                return objPedidoBL.Pedido_ListarTipo(idEmpresa, codigoUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Pedido_Registrar(int idEmpresa, int codigoUsuario, PedidoCabBE objPedidoCabBE, List<PedidoDetBE> lstProductos, 
            List<GlosaBE> lstImpuestos, decimal? idOperacion, string password, decimal limiteCredito)
        {
            PedidoBL objPedidoBL;
            try
            {
                objPedidoBL = new PedidoBL();
                objPedidoBL.Pedido_Registrar(idEmpresa, codigoUsuario, objPedidoCabBE, lstProductos, lstImpuestos, idOperacion, password, limiteCredito);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Pedido_Aprobar(int idEmpresa, int codigoUsuario, int idPedido, int op, string idSectorista, bool aproCred, string motivo)
        {
            PedidoBL objPedidoBL;
            try
            {
                objPedidoBL = new PedidoBL();
                objPedidoBL.Pedido_Aprobar(idEmpresa, codigoUsuario,idPedido,op,idSectorista,aproCred,motivo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Pedido_DesAprobar(int idEmpresa, int codigoUsuario, int idPedido, int op, string idSectorista, bool aproCred)
        {
            PedidoBL objPedidoBL;
            try
            {
                objPedidoBL = new PedidoBL();
                objPedidoBL.Pedido_DesAprobar(idEmpresa, codigoUsuario, idPedido, op, idSectorista, aproCred);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void  gsDocVentaAprobacion_Registrar(int idEmpresa, int idPedido, int op, string id_agenda, int codigoUsuario)
        {
            PedidoBL objPedidoBL;
            try
            {
                objPedidoBL = new PedidoBL();
                objPedidoBL.gsDocVentaAprobacion_Registrar(idEmpresa, idPedido, op, id_agenda, codigoUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public VerificarExisteDocVentaResult VerificarExisteDocVenta(int idEmpresa, int codigoUsuario, string idAgenda) {
            PedidoBL objPedidoBL;
            try
            {
                objPedidoBL = new PedidoBL();
                return objPedidoBL.VerificarExisteDocVenta(idEmpresa,codigoUsuario, idAgenda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<gsPedidos_FechasLetrasSelectResult> PedidoLetras_Detalle(int idEmpresa, int codigoUsuario, int OpOV, int OpDOC, string Tabla)
        {
            PedidoBL objPedidoBL;
            try
            {
                objPedidoBL = new PedidoBL();
                return objPedidoBL.PedidoLetras_Detalle(idEmpresa, codigoUsuario, OpOV, OpDOC, Tabla);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }




    }
}