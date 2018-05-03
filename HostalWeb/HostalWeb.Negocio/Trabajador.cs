using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;
namespace HostalWeb.Negocio
{
    public class Trabajador
    {
        #region Campos
        public int ID { get; set; }
        private int _rut;
        private string _dv;
        
        public string RUT
        {
            get
            {
                return string.Format("{0}-{1}", _rut.ToString("0,0"), _dv);
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Rut no puede ir vacío");
                }
                value = value.Replace(" ", "").Replace(",", "").Replace(".", "").Replace("-", "").ToLower();
                _dv = value[value.Length - 1].ToString();
                value = value.Remove(value.Length - 1);
                int dvn;
                //Verificar
                if (!int.TryParse(value, out _rut) || (!int.TryParse(_dv, out dvn) && _dv != "k"))
                {
                    throw new ArgumentException("Rut no es válido");
                }
            }
        }

        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string TELEFONO { get; set; }
        public string CORREO { get; set; }
        public int EMPRESA_ID { get; set; }
        public string EMPRESA_NOMBRE { get; set; }
        public int USUARIO_ID { get; set; }
        public string USUARIO_NOMBRE { get; set; }
#endregion

#region Constructor e Inicializador
        public Trabajador()
        {
            Init();
        }

        private void Init()
        {
            ID = 0;
            _rut = 0;
            NOMBRE = "";
            APELLIDO = "";
            TELEFONO = "";
            CORREO = "";
            EMPRESA_ID = 0;
            USUARIO_ID = 0;
        }
#endregion

#region CRUD
        public bool Create()
        {
            try
            {
                Datos.TRABAJADOR trabajador = new Datos.TRABAJADOR()
                {
                    RUT = _rut,
                    DV = _dv,
                    NOMBRE = NOMBRE,
                    APELLIDO = APELLIDO,
                    TELEFONO = TELEFONO,
                    CORREO = CORREO,
                    EMPRESA_ID = EMPRESA_ID,
                    USUARIO_ID = USUARIO_ID
                };
                Conexion.ModeloEntities.TRABAJADOR.Add(trabajador);
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
                Datos.TRABAJADOR trabajador = Conexion.ModeloEntities.TRABAJADOR.First(em => em.RUT == _rut);
                RUT = trabajador.RUT + trabajador.DV;
                NOMBRE = trabajador.NOMBRE;
                APELLIDO = trabajador.APELLIDO;
                TELEFONO = trabajador.TELEFONO;
                CORREO = trabajador.CORREO;
                EMPRESA_ID = trabajador.EMPRESA.ID;
                EMPRESA_NOMBRE = trabajador.EMPRESA.NOMBRE;
                USUARIO_ID = trabajador.USUARIO.ID;
                USUARIO_NOMBRE = trabajador.USUARIO.NOMBRE;
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
                Datos.TRABAJADOR trabajador = Conexion.ModeloEntities.TRABAJADOR.First(em => em.RUT == _rut);
                trabajador.DV = _dv;
                trabajador.NOMBRE = NOMBRE;
                trabajador.APELLIDO = APELLIDO;
                trabajador.TELEFONO = TELEFONO;
                trabajador.CORREO = CORREO;
                trabajador.EMPRESA_ID = EMPRESA_ID;
                trabajador.USUARIO_ID = USUARIO_ID;
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
    }
    #endregion
    
}

