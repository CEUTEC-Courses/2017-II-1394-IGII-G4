using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS.MenuFlota.Flota
{
  public abstract  class FlotaBuilder
    {
        public abstract bool CrearFlota(FlotaModelo flota);

        public abstract FlotaModelo obtenerFlota();

        public abstract int obtenerIDFlota();
    }
}
