﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using GS.SISGEGS.Web.LoginWCF;
using GS.SISGEGS.DM;
using GS.SISGEGS.Web.Helpers;

namespace GS.SISGEGS.Web
{
    public partial class frmPasswordMng : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try {
                if (!Page.IsPostBack) {
                    LoginWCF.LoginWCFClient objLoginWCF = new LoginWCF.LoginWCFClient();
                    objLoginWCF.AuditoriaMenu_Registrar(System.Web.HttpContext.Current.Request.Url.AbsolutePath, Environment.MachineName,
                        ((Usuario_LoginResult)System.Web.HttpContext.Current.Session["Usuario"]).idUsuario);

                    Title = "Cambiar contraseña";
                }
            }
            catch (Exception ex) {
                lblMensaje.Text = ex.Message;
                lblMensaje.CssClass = "mensajeError";
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            LoginWCFClient objLoginWCF = new LoginWCFClient();
            try {
                if (txtContrasena1.Text != txtContrasena2.Text)
                    throw new ArgumentException("Las contraseñas ingresadas son diferentes. Vuelva a intentarlo");

                Usuario_AutenticarResult objUsuario = JsonHelper.JsonDeserialize<Usuario_AutenticarResult>(Request.QueryString["objUsuario"]);
                objLoginWCF.Usuario_CambiarContrasena(objUsuario.idEmpresa, objUsuario.codigoUsuario, objUsuario.idUsuario, txtContrasena1.Text,
                    objUsuario.cambiarAmbos);

                ScriptManager.RegisterStartupScript(Page, this.GetType(), "mykey", "CloseAndRebind("+ objUsuario.idUsuario.ToString() + ");", true);
            }
            catch (Exception ex) {
                lblMensaje.Text = ex.Message;
                lblMensaje.CssClass = "mensajeError";
            }


        }
    }
}