using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCS.Rutas
{
    public class Ruta
    {

        private int rutaId = -1;
        private String nombreRuta;
        private List<Punto> puntos;
        private String origen;
        private String destino;
        private Punto puntoOrigen;
        private Punto puntoDestino;

        public Punto PuntoOrigen
        {
            get
            {
                if (puntos != null)
                    return puntos[0];
                else
                    return null;
            }
        }

        public Punto PuntoDestino
        {
            get
            {
                if (puntos != null && puntos.Count >= 2)
                    return puntos[puntos.Count - 1];
                else
                    return null;
            }
        }

        public String Origen
        {
            get
            {
                return origen;
            }
            set
            {
                origen = value;
            }
        }

        public String Destino
        {
            get
            {
                return destino;
            }
            set
            {
                destino = value;
            }
        }

        public int RutaID
        {
            get
            {
                return rutaId;
            }
            set
            {
                rutaId = value;
            }
        }

        public String NombreRuta
        {
            get
            {
                return nombreRuta;
            }
            set
            {
                nombreRuta = value;
            }
        }

        public List<Punto> Puntos
        {
            get
            {
                return puntos;
            }
            set
            {
                puntos = value;
            }
        }

        public Ruta()
        {
            RutaID = -1;
            NombreRuta = "";
        }

        public Ruta(String nombre, String orig, String dest)
        {
            NombreRuta = nombre;
            Origen = orig;
            Destino = dest;
            puntos = new List<Punto>();
            puntos.Insert(0, new Punto(orig));
            puntos.Insert(1, new Punto(dest));
        }

        public Ruta(int id, String nombre, String orig, String dest)
        {
            RutaID = id;
            NombreRuta = nombre;
            Origen = orig;
            Destino = dest;
            puntos = new List<Punto>();
            puntos.Insert(0, new Punto(orig));
            puntos.Insert(1, new Punto(dest));
        }

        public Ruta(int id, String nombre, String orig, String dest, List<Punto> listaPuntos)
        {
            RutaID = id;
            NombreRuta = nombre;
            Origen = orig;
            Destino = dest;
            Puntos = listaPuntos;
        }

    }
}
