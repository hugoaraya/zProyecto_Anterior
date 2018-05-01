using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;

namespace HostalWeb.Negocio
{
   public class Proveedor
    {

        #region CAMPOS
        private int _rut;
        private string _dv;

        public string RUT_PROVEEDOR
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
        public int ID_PROVEEDOR { get; set; }
        public string NOMBRE_PROVEEDOR { get; set; }
        public Nullable<decimal> TELEFONO_PROVEEDOR { get; set; }
        public string DIRECCION_PROVEEDOR { get; set; }
        public int RUBRO_ID { get; set; }
        public string CORREO { get; set; }
        

        #endregion

        #region constructor
        public Proveedor()
        {
            Inicializador();

        }
        private void Inicializador()
        {
            ID_PROVEEDOR = 0;
            _rut = 0;
            _dv = "";
            NOMBRE_PROVEEDOR = "";
            TELEFONO_PROVEEDOR = 0;
            DIRECCION_PROVEEDOR = "";
            RUBRO_ID = 0;
            CORREO = "";
            
        }

        #endregion
        #region CRUD
        public bool Create()
        {
            try
            {
                //objeto que entra en la base de datos
                Datos.PROVEEDOR objetoDato = new Datos.PROVEEDOR()
                {
                   
                    RUT = _rut,
                    DV = _dv,
                    NOMBRE = NOMBRE_PROVEEDOR,
                    TELEFONO = TELEFONO_PROVEEDOR,
                    DIRECCION = DIRECCION_PROVEEDOR,
                    RUBRO_ID = RUBRO_ID,
                    CORREO = CORREO
                };

                Conexion.ModeloEntities.PROVEEDOR.Add(objetoDato);
                Conexion.ModeloEntities.SaveChanges(); //abre la conexion, hace el comando sql, actualiza la BD, cierra la conexion

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
                Datos.PROVEEDOR proveedorDatos = (
                    from prov in Conexion.ModeloEntities.PROVEEDOR
                    where prov.RUT == _rut
                    select prov
                    ).First();
                _dv = proveedorDatos.DV;
                ID_PROVEEDOR = proveedorDatos.ID;
                NOMBRE_PROVEEDOR = proveedorDatos.NOMBRE;
                TELEFONO_PROVEEDOR = proveedorDatos.TELEFONO;
                DIRECCION_PROVEEDOR = proveedorDatos.DIRECCION;
                RUBRO_ID = proveedorDatos.RUBRO_ID;
                CORREO = proveedorDatos.CORREO;
                            
                //si no lo encuentra el resultado sera null 
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
                Datos.PROVEEDOR proveedorDatos =
                Conexion.ModeloEntities.PROVEEDOR.First(e => e.RUT == _rut);
                //aqui usamos lambda
                proveedorDatos.ID = ID_PROVEEDOR;
                proveedorDatos.NOMBRE = NOMBRE_PROVEEDOR;
                proveedorDatos.TELEFONO = TELEFONO_PROVEEDOR;
                proveedorDatos.DIRECCION = DIRECCION_PROVEEDOR;
                proveedorDatos.RUBRO_ID = RUBRO_ID;
                proveedorDatos.DV = _dv;
                proveedorDatos.CORREO = CORREO;
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
