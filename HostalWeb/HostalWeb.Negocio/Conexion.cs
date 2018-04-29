using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostalWeb.Datos;
namespace HostalWeb.Negocio
{
     internal class Conexion
    {
        private static HostalEntities _modeloEntities;

        public static HostalEntities ModeloEntities
        {
            get
            {
                if(_modeloEntities == null)
                {
                    _modeloEntities = new HostalEntities();
                }
                return _modeloEntities;
            }
            set { _modeloEntities = value; }
        }

    }
}
