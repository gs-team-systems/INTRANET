﻿using GS.SISGEGS.DM;
using GS.SISGEGS.Web.AgendaWCF;
using GS.SISGEGS.Web.ItemWCF;
using GS.SISGEGS.Web.GuiaWCF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using Telerik.Web.UI;
using System.Data;
using GS.SISGEGS.Web.Helpers;
using System.Drawing;
using xi = Telerik.Web.UI.ExportInfrastructure;
using Telerik.Web.UI.GridExcelBuilder;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Web.UI.HtmlControls;





namespace GS.SISGEGS.Web.Almacen.Operacion 
{
    public partial class frmGuiaVentas : System.Web.UI.Page
    {
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

                    dpInicio.SelectedDate = DateTime.Now;
                    dpFinal.SelectedDate = DateTime.Now;
                    lblDate.Text = "";
                    Almacen_Cargar();
                }
            }

            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.CssClass = "mensajeError";
            }
        }
        private void ListarGuiasVentas(string codAgenda,  DateTime fechaInicial, DateTime fechaFinal, string id_item, int id_almacen)
        {

            GuiaWCFClient objGuiaWCF = new GuiaWCFClient();

            try
            {
                List<gsGuiaVentas_listarResult> lst = objGuiaWCF.GuiaVenta_Listar(((Usuario_LoginResult)Session["Usuario"]).idEmpresa, ((Usuario_LoginResult)Session["Usuario"]).codigoUsuario, codAgenda,  fechaInicial, fechaFinal, id_item, id_almacen, 0).ToList();
       
                ViewState["lstGuiasVentas"] = JsonHelper.JsonSerializer(lst);
                grdGuiasVentas.DataSource = lst;
                grdGuiasVentas.DataBind();
                lblDate.Text = "1";
    
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime fecha1;
            DateTime fecha2;
            string cliente;
            int almacen;
            string item;
            int OP;

            item = "";
            cliente = "";
            almacen = 0;

            lblMensaje.Text = "";
            if (Session["Usuario"] == null)
                Response.Redirect("~/Security/frmCerrar.aspx");

            try
            {
                if(Validar_Variables() == 0)
                {
                    fecha1 = dpInicio.SelectedDate.Value;
                    fecha2 = dpFinal.SelectedDate.Value;
                    //fecha2 = dpInicio.SelectedDate.Value;

                    if (acbCliente == null || acbCliente.Text.Split('-')[0] == "" || acbCliente.Text == "")
                    {
                        cliente = null;
                    }
                    else { cliente = acbCliente.Text.Split('-')[0]; }

                    if ( cboAlmacen == null || cboAlmacen.SelectedValue == "" || cboAlmacen.SelectedIndex ==0)
                    {
                        almacen = Convert.ToInt32(null);
                    }
                    else { almacen = Convert.ToInt32(cboAlmacen.SelectedValue.ToString()); }


                    ListarGuiasVentas(cliente, fecha1 , fecha2 , item , almacen);
                }

            }
            catch (Exception ex)
            {
                lblMensaje.Text = ex.Message;
                lblMensaje.CssClass = "mensajeError";
            }
        }

        public int Validar_Variables()
        {
            int valor = 0;

            if ( dpInicio == null || dpInicio.SelectedDate.Value.ToString() == "")
            {
                valor = 1;
                lblMensaje.Text = lblMensaje.Text + "Seleccionar fecha final de emisión. ";
                lblMensaje.CssClass = "mensajeError";
            }

            return valor;
        }

        #region Métodos web
        [WebMethod]
        public static AutoCompleteBoxData Agenda_BuscarCliente(object context)
        {
            AutoCompleteBoxData res = new AutoCompleteBoxData();
            string searchString = ((Dictionary<string, object>)context)["Text"].ToString();
            if (searchString.Length > 2)
            {
                AgendaWCFClient objAgendaWCFClient = new AgendaWCFClient();
                gsAgenda_ListarClienteResult[] lst = objAgendaWCFClient.Agenda_ListarCliente(((Usuario_LoginResult)HttpContext.Current.Session["Usuario"]).idEmpresa,
                    ((Usuario_LoginResult)HttpContext.Current.Session["Usuario"]).codigoUsuario, searchString, 1);
                List<AutoCompleteBoxItemData> result = new List<AutoCompleteBoxItemData>();

                foreach (gsAgenda_ListarClienteResult agenda in lst)
                {
                    AutoCompleteBoxItemData childNode = new AutoCompleteBoxItemData();
                    childNode.Text = agenda.ID_Agenda + "-" + agenda.Nombre;
                    childNode.Value = agenda.ID_Agenda;
                    result.Add(childNode);
                }
                res.Items = result.ToArray();
            }
            return res;
        }

        [WebMethod]
        public static AutoCompleteBoxData Agenda_BuscarItem(object context)
        {
            AutoCompleteBoxData res = new AutoCompleteBoxData();
            string searchString = ((Dictionary<string, object>)context)["Text"].ToString();
            if (searchString.Length > 2)
            {
                ItemWCFClient objItemWCFClient = new ItemWCFClient();

                gsItem_ListarResult[] lst = objItemWCFClient.Item_Listar(((Usuario_LoginResult)HttpContext.Current.Session["Usuario"]).idEmpresa, ((Usuario_LoginResult)HttpContext.Current.Session["Usuario"]).codigoUsuario, searchString);
                List<AutoCompleteBoxItemData> result = new List<AutoCompleteBoxItemData>();

                foreach (gsItem_ListarResult Item in lst)
                {
                    AutoCompleteBoxItemData childNode = new AutoCompleteBoxItemData();
                    childNode.Text = Item.ID_Item + "-" + Item.Nombre;
                    childNode.Value = Item.ID_Item;
                    result.Add(childNode);
                }
                res.Items = result.ToArray();
            }
            return res;
        }
        #endregion
        protected void grdGuiasVentas_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {
            try
            {
                if (lblDate.Text == "1")
                {
                    List<gsGuiaVentas_listarResult> lst = JsonHelper.JsonDeserialize<List<gsGuiaVentas_listarResult>>((string)ViewState["lstGuiasVentas"]);
                    grdGuiasVentas.DataSource = lst;
                    grdGuiasVentas.DataBind();
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "No se encontrarón resultados.";
                lblMensaje.CssClass = "mensajeError";
            }
        }

        private void Almacen_Cargar()
        {
            try
            {
                AgendaWCFClient objAgendaWCF = new AgendaWCFClient();
                VBG00746Result objAlmacen = new VBG00746Result();
                List<VBG00746Result> lstAlmacen;

                lstAlmacen = objAgendaWCF.AgendaAnexo_ListarAlmacen(((Usuario_LoginResult)HttpContext.Current.Session["Usuario"]).idEmpresa,
                    ((Usuario_LoginResult)HttpContext.Current.Session["Usuario"]).codigoUsuario).ToList();
                lstAlmacen.Insert(0, objAlmacen);
                objAlmacen.AlmacenAnexo = "Todos";
                objAlmacen.ID_Almacen = "";

                cboAlmacen.DataSource = lstAlmacen;
                cboAlmacen.DataTextField = "AlmacenAnexo";
                cboAlmacen.DataValueField = "ID_AlmacenAnexo";
                cboAlmacen.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void grdGuiasVentas_ItemDataBound(object sender, Telerik.Web.UI.GridItemEventArgs e)
        {
            if (Session["Usuario"] == null)
                ScriptManager.RegisterStartupScript(Page, this.GetType(), "mykey", "CancelEdit();", true);

            try
            {
                //if (e.Item is GridDataItem)
                //{
                //    GridDataItem item = (GridDataItem)e.Item;

                //    if (item["Ok1"].Text == "False")
                //    {
                //        ((Image)e.Item.FindControl("imgEstado1")).ImageUrl = "~/Images/Icons/sign-error-16.png";
                //        ((Image)e.Item.FindControl("imgEstado1")).ToolTip = "Por aprobar";
                //    }
                //    else
                //    {
                //        ((Image)e.Item.FindControl("imgEstado1")).ImageUrl = "~/Images/Icons/sign-check-16.png";
                //        ((Image)e.Item.FindControl("imgEstado1")).ToolTip = "Aprobado";
                //        item["Elim"].Visible = false;
                //    }

                //    if (item["Ok2"].Text == "False")
                //    {
                //        ((Image)e.Item.FindControl("imgEstado2")).ImageUrl = "~/Images/Icons/sign-error-16.png";
                //        ((Image)e.Item.FindControl("imgEstado2")).ToolTip = "Por aprobar";
                //    }
                //    else
                //    {
                //        ((Image)e.Item.FindControl("imgEstado2")).ImageUrl = "~/Images/Icons/sign-check-16.png";
                //        ((Image)e.Item.FindControl("imgEstado2")).ToolTip = "Aprobado";
                //        item["Elim"].Visible = false;
                //    }
                //}
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "ERROR: " + ex.Message;
                lblMensaje.CssClass = "mensajeError";
            }
        }
        protected void grdGuiasVentas_ItemCommand(object sender, GridCommandEventArgs e)
        {
            if (Session["Usuario"] == null)
                ScriptManager.RegisterStartupScript(Page, this.GetType(), "mykey", "CancelEdit();", true);
            try
            {
                if (e.CommandName == "Editar")
                {
                    ScriptManager.RegisterStartupScript(Page, this.GetType(), "mykey", "ShowInsertForm(" + e.CommandArgument + ");", true);
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "ERROR: " + ex.Message;

            }
        }

    }
}