using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HostalWeb.Negocio;
namespace HostalWeb.Presentacion.templates
{
    public partial class ObtenerListaProveedores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LeerProveedor();
                LeerRubro();
            }
        }

        private void LeerProveedor()
        {
            Colecciones coleccion = new Colecciones();
            GvProveedor.DataSource = coleccion.ListadoProveedores();
            GvProveedor.DataBind();
        }

        protected void GvProveedor_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GvProveedor.PageIndex = e.NewPageIndex;
            LeerProveedor();
        }

        private void LeerRubro()
        {
            Colecciones coleccion = new Colecciones();
            Gv_Rubro.DataSource = coleccion.ListadoRubros();
            Gv_Rubro.DataBind();
        }

        protected void Gv_Rubro_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            Gv_Rubro.PageIndex = e.NewPageIndex;
            LeerRubro();
        }

    }
}