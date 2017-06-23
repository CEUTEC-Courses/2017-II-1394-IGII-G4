using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS.MenuFlota.Flota
{
    public abstract class FlotaUnidadBuilder
    {
       public abstract void CrearFlotaUnidad(FlotaUnidadModelo flotaUnidad);
        public abstract FlotaUnidadModelo ObtenerFlotaUnidad();
    }
}
