using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HostalWeb.Negocio;
namespace HostalWeb.Presentacion.templates
{
    public partial class ModificarEmpresa : System.Web.UI.Page
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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Empresa enterprise2 = new Empresa()
                {
                    RUT_EMPRESA = txtRut.Text,
                    NOMBRE_EMPRESA = txtNombre.Text,
                    GIRO_EMPRESA = txtGiro.Text,
                    DIRECCION_EMPRESA = txtDireccion.Text

                };
                if (txtRut.Text != "" && txtDireccion.Text != "" && txtGiro.Text != "")
                {
                    if (enterprise2.Update())
                    {
                        Clear();
                        lblMessages.Text = "Actualizado ☺";
                    }
                    else
                    {
                        lblMessages.Text = "NO Actualizado";
                    }
                }
                else
                {
                    lblMessages.Text = "No se pudo Actualizar Verifique datos";
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