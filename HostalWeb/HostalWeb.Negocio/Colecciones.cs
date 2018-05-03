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
        public List<Trabajador> ListadoTrabajadores()
        {
            List<Trabajador> salida = new List<Trabajador>();
            //guarad todos los datos de todas las empresas
            foreach (Datos.TRABAJADOR datostrabajador in Conexion.ModeloEntities.TRABAJADOR)
            {
                salida.Add(
                    new Trabajador()
                    {
                        ID = datostrabajador.ID,
                        RUT = datostrabajador.RUT + datostrabajador.DV,
                        NOMBRE = datostrabajador.NOMBRE,
                        TELEFONO = datostrabajador.TELEFONO,
                        CORREO = datostrabajador.CORREO,
                        EMPRESA_NOMBRE = datostrabajador.EMPRESA.NOMBRE,
                        USUARIO_NOMBRE = datostrabajador.USUARIO.NOMBRE
                    }
                    );
                      }
                    return salida;
        }



    }
}
