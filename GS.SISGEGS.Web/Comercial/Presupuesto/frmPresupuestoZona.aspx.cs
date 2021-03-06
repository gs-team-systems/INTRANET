﻿using GS.SISGEGS.DM;
using GS.SISGEGS.Web.ReporteVentaWCF;
using GS.SISGEGS.Web.AgendaWCF;
using GS.SISGEGS.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using System.Globalization; 

namespace GS.SISGEGS.Web.Comercial.Presupuesto
{
    public partial class frmPresupuestoZona : System.Web.UI.Page
    {

        protected void cboZona_SelectedIndexChanged(object sender, RadComboBoxSelectedIndexChangedEventArgs e)
        {
            if (cboZona == null || cboZona.SelectedValue == "" || cboZona.SelectedValue == "0")
            {
                //cboVendedor.Enabled = false;
                //btnBuscar.Enabled = false;
                //btnCargaMasiva.Enabled = false;
                //btnExpDetalle.Enabled = false;
            }
            else
            {
                //btnBuscar.Enabled = true;
                //btnCargaMasiva.Enabled = true;

                //cboCliente.Enabled = true;
                int idZona = int.Parse(cboZona.SelectedValue);
                Carga_Vendedores(idZona, null);

            }
        }

        private void Zona_Cargar(int id_zona)
        {
            try
            {
                AgendaWCFClient objAgendaWCF = new AgendaWCFClient();
                gsZona_ListarResult objZona = new gsZona_ListarResult();
                List<gsZona_ListarResult> lstZona;

                lstZona = objAgendaWCF.Agenda_ListarZona(((Usuario_LoginResult)HttpContext.Current.Session["Usuario"]).idEmpresa,
                    ((Usuario_LoginResult)HttpContext.Current.Session["Usuario"]).codigoUsuario, id_zona).ToList();

                lstZona.Insert(0, objZona);
                objZona.Zona = "Todos";
                objZona.ID_Zona = 0;

                var lstZonas = from x in lstZona
                               select new
                               {
                                   x.ID_Zona,
                                   DisplayID = String.Format("{0}", x.ID_Zona),
                                   DisplayField = String.Format("{0}", x.Zona)
                                   //DisplayField = String.Format("{0} {1} {2} {3}", x.Placa, x.Modelo, x.Marca, x.Agenda)
                               };

                cboZona.DataSource = lstZonas;
                cboZona.DataTextField = "DisplayField";
                cboZona.DataValueField = "DisplayID";
                cboZona.DataBind();
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.CssClass = "mensajeError";
            }
        }

        private void Carga_Vendedores(int id_zona, string id_vendedor)
        {
            try
            {
                AgendaWCFClient objAgendaWCF = new AgendaWCFClient();
                gsVendedor_ListarResult objVendedor = new gsVendedor_ListarResult();
                List<gsVendedor_ListarResult> lstVendedor;

                lstVendedor = objAgendaWCF.Agenda_ListarVendedorProyectado(((Usuario_LoginResult)HttpContext.Current.Session["Usuario"]).idEmpresa,
                    ((Usuario_LoginResult)HttpContext.Current.Session["Usuario"]).codigoUsuario, id_zona, id_vendedor).ToList();

                lstVendedor.Insert(0, objVendedor);
                objVendedor.ID_Agenda = "0";
                objVendedor.AgendaNombre = "Todos";

                var lstVendedores = from x in lstVendedor
                                    select new
                                    {
                                        x.ID_Agenda,
                                        DisplayID = x.ID_Agenda.ToString(),
                                        DisplayField = String.Format("{0} - {1}", x.ID_Agenda, x.AgendaNombre)
                                    };

                cboVendedor.DataSource = lstVendedores;
                cboVendedor.DataTextField = "DisplayField";
                cboVendedor.DataValueField = "DisplayID";
                cboVendedor.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void grdPresupuesto_CellDataBound(object sender, Telerik.Web.UI.PivotGridCellDataBoundEventArgs e)
        {
            //&month& patterns is added in the DataFormatString, so it could be catched and parsed to month name
            if (e.Cell is PivotGridColumnHeaderCell)
            {
                int month = 0;
                string strMes = ""; 

                PivotGridColumnHeaderCell cell = e.Cell as PivotGridColumnHeaderCell;
                strMes = cell.Text.ToString(); 


                if (strMes.Length > 0 && strMes.Length < 3)
                {
                    string cellValue = strMes;
                    if (int.TryParse(cellValue, out month))
                    {
                        cell.Text = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(int.Parse(cellValue));
                    }
                }
            }
        }

        private void Reporte_Cargar(int id_zonaV, string id_vendedorV)
        {
            int anho;
            int id_zona;
            string id_vendedor; 

            List<gsPresupuesto_ZonaResult> lstPrespuesto;
            try
            {
                ReporteVentaWCFClient objReporteVenta = new ReporteVentaWCFClient();

                DateTime fechaInicio = new DateTime(dpFecInicio.SelectedDate.Value.Year, dpFecInicio.SelectedDate.Value.Month, 1);
                DateTime fechaFinal = new DateTime(dpFecFinal.SelectedDate.Value.Year, dpFecFinal.SelectedDate.Value.Month, 1).AddMonths(1).AddDays(-1);
          
                id_zona = id_zonaV;
                id_vendedor = id_vendedorV;

                lstPrespuesto = objReporteVenta.Presupuesto_Zona(((Usuario_LoginResult)Session["Usuario"]).idEmpresa, ((Usuario_LoginResult)Session["Usuario"]).codigoUsuario, fechaInicio, fechaFinal, id_zona , id_vendedor).ToList();

                grdPresupuesto.DataSource = lstPrespuesto;
                grdPresupuesto.DataBind();

                lblMensaje.Text = "Se han encontrado " + lstPrespuesto.Count.ToString() + " registro.";
                lblMensaje.CssClass = "mensajeExito";

                ViewState["lstPrespuesto"] = JsonHelper.JsonSerializer(lstPrespuesto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void AddStylesToDataCells(PivotGridBaseModelCell modelDataCell, PivotGridCellExportingArgs e)
        {
            if (modelDataCell.Data != null && modelDataCell.Data.GetType() == typeof(decimal))
            {
                decimal value = Convert.ToDecimal(modelDataCell.Data);
                if (value > 100000)
                {
                    e.ExportedCell.Style.BackColor = Color.FromArgb(51, 204, 204);
                    AddBorders(e);
                }
                e.ExportedCell.Format = "0.0";

                if (modelDataCell.Field.Caption == "VentaPresupuesto")
                    e.ExportedCell.Format = "$0.0";
            }

        }

        private void AddStylesToColumnHeaderCells(PivotGridBaseModelCell modelDataCell, PivotGridCellExportingArgs e)
        {
            if (e.ExportedCell.Table.Columns[e.ExportedCell.ColIndex].Width == 0)
            {
                e.ExportedCell.Table.Columns[e.ExportedCell.ColIndex].Width = 200D;
            }

            if (modelDataCell.IsTotalCell)
            {
                e.ExportedCell.Style.BackColor = Color.FromArgb(150, 150, 150);
                e.ExportedCell.Style.Font.Bold = true;
            }
            else
            {
                e.ExportedCell.Style.BackColor = Color.FromArgb(192, 192, 192);
            }
            AddBorders(e);
        }

        private void AddStylesToRowHeaderCells(PivotGridBaseModelCell modelDataCell, PivotGridCellExportingArgs e)
        {
            if (e.ExportedCell.Table.Columns[e.ExportedCell.ColIndex].Width == 0)
            {
                e.ExportedCell.Table.Columns[e.ExportedCell.ColIndex].Width = 80D;
            }
            if (modelDataCell.IsTotalCell)
            {
                e.ExportedCell.Style.BackColor = Color.FromArgb(150, 150, 150);
                e.ExportedCell.Style.Font.Bold = true;
            }
            else
            {
                e.ExportedCell.Style.BackColor = Color.FromArgb(192, 192, 192);
            }

            AddBorders(e);
        }

        private static void AddBorders(PivotGridCellExportingArgs e)
        {
            e.ExportedCell.Style.BorderBottomColor = Color.FromArgb(128, 128, 128);
            e.ExportedCell.Style.BorderBottomWidth = new Unit(1);
            e.ExportedCell.Style.BorderBottomStyle = BorderStyle.Solid;

            e.ExportedCell.Style.BorderRightColor = Color.FromArgb(128, 128, 128);
            e.ExportedCell.Style.BorderRightWidth = new Unit(1);
            e.ExportedCell.Style.BorderRightStyle = BorderStyle.Solid;

            e.ExportedCell.Style.BorderLeftColor = Color.FromArgb(128, 128, 128);
            e.ExportedCell.Style.BorderLeftWidth = new Unit(1);
            e.ExportedCell.Style.BorderLeftStyle = BorderStyle.Solid;

            e.ExportedCell.Style.BorderTopColor = Color.FromArgb(128, 128, 128);
            e.ExportedCell.Style.BorderTopWidth = new Unit(1);
            e.ExportedCell.Style.BorderTopStyle = BorderStyle.Solid;
        }

        private bool IsTotalDataCell(PivotGridBaseModelCell modelDataCell)
        {
            return modelDataCell.TableCellType == PivotGridTableCellType.DataCell &&
               (modelDataCell.CellType == PivotGridDataCellType.ColumnTotalDataCell ||
                 modelDataCell.CellType == PivotGridDataCellType.RowTotalDataCell ||
                 modelDataCell.CellType == PivotGridDataCellType.RowAndColumnTotal);
        }

        private bool IsGrandTotalDataCell(PivotGridBaseModelCell modelDataCell)
        {
            return modelDataCell.TableCellType == PivotGridTableCellType.DataCell &&
                (modelDataCell.CellType == PivotGridDataCellType.ColumnGrandTotalDataCell ||
                    modelDataCell.CellType == PivotGridDataCellType.ColumnGrandTotalRowTotal ||
                    modelDataCell.CellType == PivotGridDataCellType.RowGrandTotalColumnTotal ||
                    modelDataCell.CellType == PivotGridDataCellType.RowGrandTotalDataCell ||
                    modelDataCell.CellType == PivotGridDataCellType.RowAndColumnGrandTotal);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
                Response.Redirect("~/Security/frmCerrar.aspx");

            try
            {
                if (!Page.IsPostBack)
                {
                    LoginWCF.LoginWCFClient objLoginWCF = new LoginWCF.LoginWCFClient();
                    objLoginWCF.AuditoriaMenu_Registrar(System.Web.HttpContext.Current.Request.Url.AbsolutePath, Environment.MachineName,
                        ((Usuario_LoginResult)System.Web.HttpContext.Current.Session["Usuario"]).idUsuario);

                    int month = DateTime.Now.Month;

                    dpFecInicio.SelectedDate = DateTime.Now;
                    dpFecFinal.SelectedDate = DateTime.Now.AddMonths(+11);


                    Zona_Cargar(0);
                    Carga_Vendedores(0,null);
                    Reporte_Cargar(0,null);
                }
            }
            catch (Exception ex)
            {
                rwmReporte.RadAlert(ex.Message, 500, 100, "Error al descargar el excel", "");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            int id_zona;
            string id_vendedor;

            if (Session["Usuario"] == null)
                Response.Redirect("~/Security/frmCerrar.aspx");

            try
            {
                id_zona = int.Parse(cboZona.SelectedValue);
                id_vendedor = cboVendedor.SelectedValue.ToString();
                Reporte_Cargar(id_zona, id_vendedor);

            }
            catch (Exception ex)
            {
                rwmReporte.RadAlert(ex.Message, 500, 100, "Error al descargar el excel", "");
            }
        }

        protected void btnExcel_Click(object sender, EventArgs e)
        {
            if (Session["Usuario"] == null)
                Response.Redirect("~/Security/frmCerrar.aspx");

            try
            {
                grdPresupuesto.ExportSettings.Excel.Format = (PivotGridExcelFormat)Enum.Parse(typeof(PivotGridExcelFormat), "Xlsx");
                grdPresupuesto.ExportSettings.FileName = "ReportePresupuestoZona_" + DateTime.Now.ToString("yyyyMMddHmm");
                grdPresupuesto.ExportToExcel();
            }
            catch (Exception ex)
            {
                rwmReporte.RadAlert(ex.Message, 500, 100, "Error al descargar el excel", "");
            }
        }

        protected void grdPresupuesto_PivotGridCellExporting(object sender, PivotGridCellExportingArgs e)
        {
            try
            {
                PivotGridBaseModelCell modelDataCell = e.PivotGridModelCell as PivotGridBaseModelCell;
                if (modelDataCell != null)
                {
                    AddStylesToDataCells(modelDataCell, e);
                }

                if (modelDataCell.TableCellType == PivotGridTableCellType.RowHeaderCell)
                {
                    AddStylesToRowHeaderCells(modelDataCell, e);
                }

                if (modelDataCell.TableCellType == PivotGridTableCellType.ColumnHeaderCell)
                {
                    AddStylesToColumnHeaderCells(modelDataCell, e);
                }

                if (modelDataCell.IsGrandTotalCell)
                {
                    e.ExportedCell.Style.BackColor = Color.FromArgb(128, 128, 128);
                    e.ExportedCell.Style.Font.Bold = true;
                }

                if (IsTotalDataCell(modelDataCell))
                {
                    e.ExportedCell.Style.BackColor = Color.FromArgb(150, 150, 150);
                    e.ExportedCell.Style.Font.Bold = true;
                    AddBorders(e);
                }

                if (IsGrandTotalDataCell(modelDataCell))
                {
                    e.ExportedCell.Style.BackColor = Color.FromArgb(128, 128, 128);
                    e.ExportedCell.Style.Font.Bold = true;
                    AddBorders(e);
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.CssClass = "mensajeError";
            }
        }

        protected void grdPresupuesto_NeedDataSource(object sender, PivotGridNeedDataSourceEventArgs e)
        {
            if (Session["Usuario"] == null)
                Response.Redirect("~/Security/frmCerrar.aspx");

            try
            {
                grdPresupuesto.DataSource = JsonHelper.JsonDeserialize<List<gsPresupuesto_ZonaResult>>((string)ViewState["lstPrespuesto"]);
            }
            catch (Exception ex)
            {
                rwmReporte.RadAlert(ex.Message, 500, 100, "Error al descargar el excel", "");
            }
        }
    }
}