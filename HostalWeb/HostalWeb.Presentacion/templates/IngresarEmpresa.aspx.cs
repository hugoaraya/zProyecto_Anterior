using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HostalWeb.Negocio;
namespace HostalWeb.Presentacion.templates
{
    public partial class IngresarEmpresa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                Empresa enterprise = new Empresa()
                {
                    RUT_EMPRESA = txtRut.Text,
                    NOMBRE_EMPRESA = txtNombre.Text,
                    DIRECCION_EMPRESA = txtDireccion.Text,
                    GIRO_EMPRESA = txtGiro.Text

                };

                if (enterprise.Read())
                {
                    lblMessages.Text = "No Guardado. Verifique que Empresa no exista";
                }
                else if (txtRut.Text != "" && txtDireccion.Text != "" && txtGiro.Text != "")
                {
                    enterprise.Create();
                    Clear();
                    lblMessages.Text = "Guardado ☺";
                }
                else
                {
                    lblMessages.Text = "No Guardado, verifique datos";
                }

            }
            catch (Exception ex)
            {
                lblMessages.Text = ex.Message;
            }

    }
        

        protected void btnlimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            txtRut.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtGiro.Text = "";
            lblMessages.Text = "";
        }
    }
}