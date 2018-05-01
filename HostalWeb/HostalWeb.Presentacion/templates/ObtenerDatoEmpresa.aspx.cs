using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HostalWeb.Negocio;
namespace HostalWeb.Presentacion.templates
{
    public partial class ObtenerDatoEmpresa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                Empresa empre = new Empresa()
                {
                    RUT_EMPRESA = txtRut.Text
                };
                if (empre.Read())
                {
                    txtNombre.Text = empre.NOMBRE_EMPRESA;
                    txtDireccion.Text = empre.DIRECCION_EMPRESA;
                    txtRut.Text = empre.RUT_EMPRESA;
                    txtGiro.Text = empre.GIRO_EMPRESA;
                    lblMessages.Text = "encontrado! ☺";
                }
                else
                {
                    lblMessages.Text = "NO encontrado! ";
                    txtDireccion.Text = "";
                    txtNombre.Text = "";
                    txtGiro.Text = "";
                }
            }
            catch (Exception ex)
            {
                txtDireccion.Text = "";
                txtNombre.Text = "";
                txtGiro.Text = "";
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