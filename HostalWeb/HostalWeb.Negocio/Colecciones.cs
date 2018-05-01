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
                        ID_EMPRESA = datosempresa.ID,
                        RUT_EMPRESA = datosempresa.RUT + datosempresa.DV,
                        NOMBRE_EMPRESA = datosempresa.NOMBRE,
                        DIRECCION_EMPRESA = datosempresa.DIRECCION,
                        GIRO_EMPRESA = datosempresa.GIRO
                    }
          );
            }
            return salida;
        }

        public List<Proveedor> ListadoProveedores()
        {
            List<Proveedor> salida = new List<Proveedor>();
            //guarad todos los datos de todas las Proveedor
            foreach (Datos.PROVEEDOR datosproveedor in Conexion.ModeloEntities.PROVEEDOR)
            {
                salida.Add(
                    new Proveedor()
                    {

                        ID_PROVEEDOR = datosproveedor.ID,
                        RUT_PROVEEDOR = datosproveedor.RUT + datosproveedor.DV,
                        NOMBRE_PROVEEDOR = datosproveedor.NOMBRE,
                        TELEFONO_PROVEEDOR = datosproveedor.TELEFONO,
                        DIRECCION_PROVEEDOR = datosproveedor.DIRECCION,
                        RUBRO_ID = datosproveedor.RUBRO_ID,
                        CORREO = datosproveedor.CORREO
                    }
          );
            }
            return salida;
        }

        //listar rubros

        public List<Rubro> ListadoRubros()
        {
            List<Rubro> salida = new List<Rubro>();
            //guarad todos los datos de todas las Proveedor
            foreach (Datos.RUBRO datosrubro in Conexion.ModeloEntities.RUBRO)
            {
                salida.Add(
                    new Rubro()
                    {


                        DESCRIPCION_RUBRO = datosrubro.DESCRIPCION,
                        RUBRO_ID = datosrubro.ID

                    }
          );
            }
            return salida;
        }
    }
}
