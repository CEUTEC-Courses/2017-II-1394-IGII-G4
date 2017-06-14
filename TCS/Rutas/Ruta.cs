using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.Entity;
using TCS.InitialConfiguration;

namespace TCS.Rutas
{
    public class Ruta : RutaSimpleBuilder
    {

        private ruta _ruta;

        public Ruta(int RutaID)
        {
            if(AppConfigurationManager.Instance().DbContext != null)
                _ruta = AppConfigurationManager.Instance().DbContext.ruta.Where(r => r.RutaID == RutaID).FirstOrDefault();  
        }

        public Ruta(String nombre, punto origen, punto destino)
        {
            if (!crearRuta(nombre, origen, destino))
                throw new Exception("Origen o Destino no existen!");
        }

        public Ruta(String nombre, String origen, String destino)
        {
            if (!crearRuta(nombre, origen, destino))
                throw new Exception("Origen o Destino no existen!");
        }

        public Ruta(ruta ruta)
        {
            _ruta = ruta;
        }

        public bool modificarRuta(String nombre)
        {
            if (_ruta != null && AppConfigurationManager.Instance().DbContext != null)
            {
                _ruta.NombreRuta = nombre;
                AppConfigurationManager.Instance().DbContext.SaveChanges();
                return true;
            }
            else
                return false;

        }

        public bool modificarRuta(String nombre, punto puntoOrigen, punto puntoDestino)
        {
            if (_ruta != null && AppConfigurationManager.Instance().DbContext != null)
            {
                _ruta.NombreRuta = nombre;
                _ruta.IDPuntoDestino = puntoDestino.PuntoID;
                _ruta.IDPuntoOrigen = puntoOrigen.PuntoID;
                AppConfigurationManager.Instance().DbContext.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool modificarRuta(String nombre, int origenID, int destinoID)
        {
            if (_ruta != null && AppConfigurationManager.Instance().DbContext != null)
            {
                _ruta.NombreRuta = nombre;
                _ruta.IDPuntoDestino = destinoID;
                _ruta.IDPuntoOrigen = origenID;
                AppConfigurationManager.Instance().DbContext.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public bool modificarRuta(String nombre, String nombreOrigen, String nombreDestino)
        {
            if (_ruta != null && AppConfigurationManager.Instance().DbContext != null)
            {
                _ruta.NombreRuta = nombre;
                _ruta.IDPuntoDestino = AppConfigurationManager.Instance().DbContext.punto.Where(p => p.NombrePunto == nombreDestino).FirstOrDefault().PuntoID;
                _ruta.IDPuntoOrigen = AppConfigurationManager.Instance().DbContext.punto.Where(p => p.NombrePunto == nombreOrigen).FirstOrDefault().PuntoID;
                AppConfigurationManager.Instance().DbContext.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
