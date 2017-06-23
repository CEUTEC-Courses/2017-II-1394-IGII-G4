using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS.MenuFlota.Unidad
{
   public class UnidadModelo
    {
        public int UnidadID { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> Anio { get; set; }

    }
}
