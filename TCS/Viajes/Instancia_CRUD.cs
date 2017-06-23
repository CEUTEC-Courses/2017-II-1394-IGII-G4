using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS.Viajes
{
    class Instancia_CRUD
    {
        public static CRUD_Viaje Instancia()
        {
            if (instancia == null)
            {
                lock (typeof(CRUD_Viaje))
                {
                    if (instancia == null)
                    {
                        instancia = new CRUD_Viaje();
                    }
                }
            }
            return instancia;
        }
        protected Instancia_CRUD() { }
        private static volatile CRUD_Viaje instancia = null;
    }
}
