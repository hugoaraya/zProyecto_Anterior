using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostalWeb.Negocio
{
    public class Rubro
    {
        public int RUBRO_ID { get; set; }
        public string DESCRIPCION_RUBRO { get; set; }
 


        public Rubro()
        {
            Inicializador();

        }
        private void Inicializador()
        {
            DESCRIPCION_RUBRO = "";
            RUBRO_ID = 0;


        }

        public bool Read()
        {
            try
            {
                Datos.RUBRO RubroDatos = (
                    from rubro in Conexion.ModeloEntities.RUBRO
                    where rubro.ID == RUBRO_ID
                    select rubro
                    ).First();
                
                DESCRIPCION_RUBRO = RubroDatos.DESCRIPCION;
                RUBRO_ID = RubroDatos.ID;
                //si no lo encuentra el resultado sera null 
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
