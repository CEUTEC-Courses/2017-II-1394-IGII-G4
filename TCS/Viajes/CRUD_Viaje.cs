using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TCS.Entity;
using TCS.InitialConfiguration;

namespace TCS.Viajes
{
    class CRUD_Viaje
    {
        public void CrearViaje(string unidad, string ruta, DateTime fechapartida, DateTime fecharegreso, string descripcion)
        {
            using (TCS_Entities Conexion = new TCS_Entities())
            {
                Conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                Conexion.Database.Connection.Open();

                var viajeN = new viaje()
                {
                    UnidadID = ObtenerUnidad(unidad),
                    RutaID = ObtenerRuta(ruta),
                    FechaPartida = fechapartida,
                    FechaRegreso = fecharegreso,
                    Descripcion = descripcion
                };

                Conexion.viaje.Add(viajeN);
                Conexion.SaveChanges();
            }
        }

        public List<int> ListarViajesPorNumero(int buscar)
        {
            using (TCS_Entities Conexion = new TCS_Entities())
            {
                Conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                Conexion.Database.Connection.Open();

                var busqueda = (from cons in Conexion.viaje
                                where cons.ViajeID == buscar
                                select cons.ViajeID).ToList();
                return busqueda;
            }
        }

        public viaje ListarViajesGeneral(int buscar)
        {
            using (TCS_Entities Conexion = new TCS_Entities())
            {
                Conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                Conexion.Database.Connection.Open();

                var viaje = (from cons in Conexion.viaje
                             where cons.ViajeID == buscar
                             select cons).FirstOrDefault();
                return viaje;
            }
        }

        public List<flota> ListarFlota()
        {
            using (TCS_Entities Conexion = new TCS_Entities())
            {
                Conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                Conexion.Database.Connection.Open();

                var flota = (from cons in Conexion.flota
                              select cons).ToList();
                
                return flota;
            }
        }

        public unidad ListarUnidadPorID(int buscar)
        {
            using (TCS_Entities Conexion = new TCS_Entities())
            {
                Conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                Conexion.Database.Connection.Open();

                var unidad = (from cons in Conexion.unidad
                            where cons.UnidadID == buscar
                            select cons).FirstOrDefault();

                return unidad;
            }
        }

        public List<unidad> ListarUnidadesPorFlota(string empresaflota)
        {
            List<unidad> ListaUnidades = new List<unidad>();

            using (TCS_Entities Conexion = new TCS_Entities())
            {
                Conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                Conexion.Database.Connection.Open();

                var unidades = (from consf in Conexion.flota
                                join consfu in Conexion.flotaunidad
                                    on consf.FlotaID equals consfu.FlotaID
                                join consu in Conexion.unidad
                                    on consfu.UnidadID equals consu.UnidadID
                                where consf.Empresa == empresaflota
                                select consu
                                ).ToList();

                ListaUnidades = unidades;
            }
            return ListaUnidades;

        }

        public ruta RetornarRuta(int buscar)
        {
            using (TCS_Entities Conexion = new TCS_Entities())
            {
                Conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                Conexion.Database.Connection.Open();

                var ruta = (from cons in Conexion.ruta
                            where cons.RutaID == buscar
                            select cons).FirstOrDefault();

                return ruta;
            }
        }

        public List<ruta> ListarRutas()
        {
            using (TCS_Entities Conexion = new TCS_Entities())
            {
                Conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                Conexion.Database.Connection.Open();

                var ruta = (from cons in Conexion.ruta
                            select cons).ToList();

                return ruta;
            }
        }

        public List<int> ListarViajesPorFecha(DateTime dtDel, DateTime dtAl)
        {
            List<int> l = new List<int>();
                using (TCS_Entities Conexion = new TCS_Entities())
                {
                    Conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                    Conexion.Database.Connection.Open();

                var busqueda = (from cons in Conexion.viaje where (cons.FechaPartida >= dtDel && cons.FechaPartida <= dtAl) select cons.ViajeID).ToList();
                    l = busqueda;
                }
            return l;
        }



        private void EliminarViaje(int id)
        {
            using (TCS_Entities Conexion = new TCS_Entities())
            {
                Conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                Conexion.Database.Connection.Open();

                viaje eliminar = (from elim in Conexion.viaje where elim.ViajeID == id select elim).FirstOrDefault();

                Conexion.viaje.Remove(eliminar);
                Conexion.SaveChanges();
            }
        }

        private int ObtenerUnidad(string unidad)
        {
            int unidadid = 0;

            using (TCS_Entities Conexion = new TCS_Entities())
            {
                Conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                Conexion.Database.Connection.Open();

                unidadid = (from cons in Conexion.unidad
                            where cons.Placa == unidad
                            select cons.UnidadID).FirstOrDefault();
            }
            return unidadid;
        }

        private int ObtenerRuta(string ruta)
        {
            int rutaid = 0;

            using (TCS_Entities Conexion = new TCS_Entities())
            {
                Conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                Conexion.Database.Connection.Open();

                rutaid = (from cons in Conexion.ruta
                          where cons.NombreRuta == ruta
                          select cons.RutaID).FirstOrDefault();

                return rutaid;
            }
        }

        private void ModificarViaje(int id, int unidadid, string nombreunidad, DateTime fechapartida, DateTime fecharegreso, string descripcion)
        {
            using (TCS_Entities Conexion = new TCS_Entities())
            {
                Conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                Conexion.Database.Connection.Open();

                viaje modificar = (from modif in Conexion.viaje where modif.ViajeID == id select modif).FirstOrDefault();

                unidadid = ObtenerUnidad(nombreunidad);
                modificar.UnidadID = unidadid;
                modificar.FechaPartida = fechapartida;
                modificar.FechaRegreso = fecharegreso;
                modificar.Descripcion = descripcion;

                Conexion.SaveChanges();
            }
        }

    }
}
