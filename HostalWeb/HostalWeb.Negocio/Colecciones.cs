using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;

namespace HostalWeb.Negocio
{
    public class Colecciones
    {
        public List<Empresa> ListadoEmpresas()
        {
            List<Empresa> salida = new List<Empresa>();
            //guarad todos los datos de todas las empresas
            foreach (Datos.EMPRESA datosempresa in Conexion.ModeloEntities.EMPRESA)
            {
                salida.Add(
                    new Empresa()
                    {
                        ID_EMPRESA = datosempresa.ID_EMPRESA,
                        RUT_EMPRESA = datosempresa.RUT_EMPRESA + datosempresa.DV_EMPRESA,
                        NOMBRE_EMPRESA = datosempresa.NOMBRE_EMPRESA,
                        DIRECCION_EMPRESA = datosempresa.DIRECCION_EMPRESA,
                        GIRO_EMPRESA = datosempresa.GIRO_EMPRESA
                    }
          );
            }
            return salida;
        }
    }
}
