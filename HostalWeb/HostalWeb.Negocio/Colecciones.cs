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
            //Guarada todos los datos de todas las empresas
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

        public List<Empleado> ListadoEmpleado()
        {
            List<Empleado> salida = new List<Empleado>();

            foreach (Datos.EMPLEADO datosempleado in Conexion.ModeloEntities.EMPLEADO)
            {
                salida.Add(
                    new Empleado()
                    {
                        ID_EMPLEADO = datosempleado.ID,
                        RUT_EMPLEADO = datosempleado.RUT + datosempleado.DV,
                        NOMBRE_EMPLEADO = datosempleado.NOMBRE,
                        APELLIDO_EMPLEADO = datosempleado.APELLIDO,
                        CARGO_EMPLEADO = datosempleado.CARGO,
                        TELEFONO_EMPLEADO = datosempleado.TELEFONO,
                        CORREO_EMPLEADO = datosempleado.CORREO
                    }
          );
            }
            return salida;
        }

    }
}
