using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HostalWeb.Negocio;
namespace HostalWeb.Presentacion
{
    public partial class ObtenerListaTrabajadores : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LeerTrabajadores();
            }
        }

        private void LeerTrabajadores()
        {
            Colecciones coleccion = new Colecciones();
            GVTrabajadores.DataSource = coleccion.ListadoTrabajadores();
            GVTrabajadores.DataBind();
        }

        protected void GVTrabajadores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GVTrabajadores.PageIndex = e.NewPageIndex;
            LeerTrabajadores();
        }
    }
}