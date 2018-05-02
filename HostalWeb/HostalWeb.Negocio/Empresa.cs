using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;
namespace HostalWeb.Negocio
{
    public class Empresa
    {
        private int _rut;
        private string _dv;
        public int ID_EMPRESA { get; set; }
        public string RUT_EMPRESA
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

        public string NOMBRE_EMPRESA { get; set; }

        public string DIRECCION_EMPRESA { get; set; }

        public string GIRO_EMPRESA { get; set; }

        public Empresa()
            {
                Inicializador();

            }
            private void Inicializador()
            {
                ID_EMPRESA = 0;
                _rut = 0;
                _dv = "";
                NOMBRE_EMPRESA = "";
                DIRECCION_EMPRESA = "";
                GIRO_EMPRESA = "";
        }


            public bool Create()
            {
                try
                {
<<<<<<< HEAD
                    //objeto que entra en la base de datos
                    Datos.EMPRESA objetoDato = new Datos.EMPRESA()
                    {
                        ID = ID_EMPRESA,
=======
                //objeto que entra en la base de datos
                Datos.EMPRESA objetoDato = new Datos.EMPRESA()
                {
>>>>>>> eea9b802608d92eb856d1711fecd61904de6ff9f
                        RUT = _rut,
                        DV =_dv,
                        NOMBRE = NOMBRE_EMPRESA,
                        DIRECCION = DIRECCION_EMPRESA,
                        GIRO = GIRO_EMPRESA
<<<<<<< HEAD
            };
                    Conexion.ModeloEntities.EMPRESA.Add(objetoDato);
=======
                    };
                Conexion.ModeloEntities.EMPRESA.Add(objetoDato);
>>>>>>> eea9b802608d92eb856d1711fecd61904de6ff9f
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
                    Datos.EMPRESA empresaDatos = (
                        from empre in Conexion.ModeloEntities.EMPRESA
                        where empre.RUT == _rut
                        select empre
                        ).First();
<<<<<<< HEAD
                            ID_EMPRESA = empresaDatos.ID;
                            NOMBRE_EMPRESA = empresaDatos.NOMBRE;
                            DIRECCION_EMPRESA = empresaDatos.DIRECCION;
                            GIRO_EMPRESA = empresaDatos.GIRO;
                            _dv = empresaDatos.DV;
                //si no lo encuentra el resultado sera null 
                return true;
=======
                    NOMBRE_EMPRESA = empresaDatos.NOMBRE;
                    DIRECCION_EMPRESA = empresaDatos.DIRECCION;
                    GIRO_EMPRESA = empresaDatos.GIRO;
                    _dv = empresaDatos.DV;
                    //si no lo encuentra el resultado sera null 
                    return true;
>>>>>>> eea9b802608d92eb856d1711fecd61904de6ff9f
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
                    Datos.EMPRESA empresaDatos =
                        Conexion.ModeloEntities.EMPRESA.First(e => e.RUT == _rut);
                        //aqui usamos lambda
<<<<<<< HEAD
                        empresaDatos.ID = ID_EMPRESA;
=======
>>>>>>> eea9b802608d92eb856d1711fecd61904de6ff9f
                        empresaDatos.NOMBRE = NOMBRE_EMPRESA;
                        empresaDatos.DIRECCION = DIRECCION_EMPRESA;
                        empresaDatos.GIRO = GIRO_EMPRESA;
                        empresaDatos.DV = _dv;
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




    }

