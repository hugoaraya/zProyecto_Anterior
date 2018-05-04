using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;

namespace HostalWeb.Negocio
{
    public class Empleado
    {
        #region Campos y Propiedades
        public int ID_EMPLEADO { get; set; }
        private int _rut;
        private string _dv;
        public string NOMBRE_EMPLEADO { get; set; }
        public string APELLIDO_EMPLEADO { get; set; }
        public string CARGO_EMPLEADO { get; set; }
        public string TELEFONO_EMPLEADO { get; set; }
        public string CORREO_EMPLEADO { get; set; }


        public string RUT_EMPLEADO
        {
            get { return string.Format("{0}-{1}", _rut, _dv); }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Rut no puede ir vacio");
                }
                value = value.Replace(".", "").Replace(",", "").Replace(" ", "").Replace("-", "").ToLower();
                char dv = value[value.Length - 1];
                value = value.Remove(value.Length - 1);
                int rut1, ndv;
                if (!int.TryParse(value, out rut1) || (!int.TryParse(dv.ToString(), out ndv) && dv != 'k'))
                    throw new ArgumentException("Rut no valido");

                _rut = rut1;
                _dv = dv.ToString();

            }
        }
        #endregion

        #region Contructor e Inicializador
        public Empleado()
        {
            Inicializador();
        }

        private void Inicializador()
        {

        }

        #endregion

        #region Métodos
        public bool Create()
        {
            try
            {
                Datos.EMPLEADO nuevoEmpleado = new Datos.EMPLEADO()
                {
                    ID = ID_EMPLEADO,
                    RUT = _rut,
                    DV = _dv,
                    NOMBRE = NOMBRE_EMPLEADO,
                    APELLIDO = APELLIDO_EMPLEADO,
                    CARGO = CARGO_EMPLEADO,
                    TELEFONO = TELEFONO_EMPLEADO,
                    CORREO = CORREO_EMPLEADO
                };
                Conexion.ModeloEntities.EMPLEADO.Add(nuevoEmpleado);
                Conexion.ModeloEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Read()
        {
            try
            {
                Datos.EMPLEADO empleadoDatos = (
                    from emp in Conexion.ModeloEntities.EMPLEADO
                    where emp.RUT == _rut
                    select emp
                    ).First();
                ID_EMPLEADO = empleadoDatos.ID;
                _dv = empleadoDatos.DV;
                NOMBRE_EMPLEADO = empleadoDatos.NOMBRE;
                APELLIDO_EMPLEADO = empleadoDatos.APELLIDO;
                CARGO_EMPLEADO = empleadoDatos.CARGO;
                TELEFONO_EMPLEADO = empleadoDatos.TELEFONO;
                CORREO_EMPLEADO = empleadoDatos.CORREO;

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool Update()
        {
            try
            {
                Datos.EMPLEADO empleadoDatos =
                    Conexion.ModeloEntities.EMPLEADO.First(e => e.RUT == _rut);
                //  * Lambda *
                empleadoDatos.ID = ID_EMPLEADO;
                empleadoDatos.DV = _dv;
                empleadoDatos.NOMBRE = NOMBRE_EMPLEADO;
                empleadoDatos.APELLIDO = APELLIDO_EMPLEADO;
                empleadoDatos.CARGO = CARGO_EMPLEADO;
                empleadoDatos.TELEFONO = TELEFONO_EMPLEADO;
                empleadoDatos.CORREO = CORREO_EMPLEADO;
                Conexion.ModeloEntities.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public int GetRut()
        {
            return _rut;
        } 
        #endregion
    }

}

