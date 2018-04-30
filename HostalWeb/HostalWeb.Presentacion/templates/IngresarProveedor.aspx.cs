using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HostalWeb.Negocio;

namespace HostalWeb.Presentacion.templates
{
    public partial class IngresarProveedor : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarRubro();
        }

        protected void btn_ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                Proveedor proveedor = new Proveedor()
                {
                    RUT_PROVEEDOR = txt_rut.Text,
                    NOMBRE_PROVEEDOR = txt_nombre.Text,
                    TELEFONO_PROVEEDOR = decimal.Parse(txt_telefono.Text),
                    DIRECCION_PROVEEDOR = txt_direccion.Text,
                    RUBRO_ID = int.Parse(ddl_rubro.SelectedValue),
                    CORREO = txt_correo.Text

                };
                if (proveedor.Create())
                {
                    lb_msj.Text = "Guardado.";
                }
                else
                {
                    lb_msj.Text = "No Guardado.";
                }
            }catch(Exception ex)
            {
                lb_msj.Text = ex.Message;
            }
        }

        private void llenarRubro()
        {
            Colecciones colecion = new Colecciones();
            foreach (Rubro item in colecion.ListadoRubros())
            {
                ddl_rubro.Items.Add(new ListItem()
                {
                    Value = item.RUBRO_ID.ToString(),
                    Text = item.DESCRIPCION_RUBRO
                });
            }
            ddl_rubro.DataBind();           
        }
    }
}