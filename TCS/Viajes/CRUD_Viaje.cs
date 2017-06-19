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
        public void CrearViaje(string unidad, DateTime fechapartida, DateTime fecharegreso, string descripcion)
        {
            using (TCS_Entities Conexion = new TCS_Entities())
            {
                Conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                Conexion.Database.Connection.Open();

                var viajeN = new viaje()
                {
                    UnidadID = ObtenerUnidad(unidad),
                    FechaPartida = fechapartida,
                    FechaRegreso = fecharegreso,
                    Descripcion = descripcion
                };

                Conexion.viaje.Add(viajeN);
                Conexion.SaveChanges();
            }
        }

        public List<int> ListarViajesPorNumero(string buscar)
        {
            List<int> l = new List<int>();
            using (TCS_Entities Conexion = new TCS_Entities())
            {
                Conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                Conexion.Database.Connection.Open();

                int b = Convert.ToInt16(buscar);
                var busqueda = (from cons in Conexion.viaje where cons.ViajeID == b select cons.ViajeID).ToList();
                l = busqueda;
                return l;
            }
        }

        public List<int?> ListarViajesPorFecha(DateTime dtDel, DateTime dtAl)
        {
            List<int?> l = new List<int?>();

            using (TCS_Entities Conexion = new TCS_Entities())
            {
                Conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                Conexion.Database.Connection.Open();

                var busqueda = Conexion.FiltroFechasViajes(dtDel, dtAl).ToList();
                l = busqueda;
                return l;
            }
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
            int rUnidad = 0;

            using (TCS_Entities Conexion = new TCS_Entities())
            {
                Conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                Conexion.Database.Connection.Open();

                rUnidad = (from cons in Conexion.unidad where cons.Placa == unidad select cons.UnidadID).FirstOrDefault();
            }
            return rUnidad;
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
