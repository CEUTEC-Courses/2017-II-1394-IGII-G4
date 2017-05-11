using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS.Rutas
{
    public class Punto
    {

        private int puntoId = -1;
        private String nombrePunto;

        public int PuntoID
        {
            get
            {
                return puntoId;
            }
            set
            {
                puntoId = value;
            }
        }

        public String NombrePunto
        {
            get
            {
                return nombrePunto;
            }
            set
            {
                nombrePunto = value;
            }
        }

        public Punto()
        {
            PuntoID = -1;
            NombrePunto = "";
        }

        public Punto(String nombre)
        {
            NombrePunto = nombre;
        }

        public Punto(int id, String nombre)
        {
            PuntoID = id;
            NombrePunto = nombre;
        }

    }
}
