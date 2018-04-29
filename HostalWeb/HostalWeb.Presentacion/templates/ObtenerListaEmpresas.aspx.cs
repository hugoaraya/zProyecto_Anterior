using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HostalWeb.Negocio;
namespace HostalWeb.Presentacion.templates
{
    public partial class ObtenerListaEmpresas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LeerEmpresas();
            }
        }

        private void LeerEmpresas()
        {
            Colecciones coleccion = new Colecciones();
            GVEmpresas.DataSource = coleccion.ListadoEmpresas();
            GVEmpresas.DataBind();
        }

        protected void GVEmpresas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GVEmpresas.PageIndex = e.NewPageIndex;
            LeerEmpresas();
        }
    }
    
}