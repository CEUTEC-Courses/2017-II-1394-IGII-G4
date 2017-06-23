using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TCS.Entity;
using TCS.InitialConfiguration;

namespace TCS.MenuFlota.Flota
{
    public class CRUDFlota
    {
        public void AtualizarFlota(FlotaModelo flota)
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();

                var flotaActualizada = conexion.flota.Where(x => x.FlotaID == flota.FlotaID).FirstOrDefault();
                flotaActualizada.Empresa = flota.Empresa;
                flotaActualizada.Dueno = flota.Dueno;
                flotaActualizada.Codigo = flota.Codigo;
                conexion.SaveChanges();
            }
        }

        public void MostrarListaFlota(ref ListView listaFlotas)
        {
            listaFlotas.Items.Clear();
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();

                var queryListaFlotas = from flota in conexion.flota
                                         select new
                                         {
                                             FlotaID=flota.FlotaID,
                                             Empresa=flota.Empresa,
                                             Dueno=flota.Dueno,
                                             Codigo=flota.Codigo
                                         };

                foreach (var item in queryListaFlotas)
                {
                    ListViewItem lista = listaFlotas.Items.Add(item.FlotaID.ToString());
                    lista.SubItems.Add(item.Empresa.ToString());
                    lista.SubItems.Add(item.Dueno.ToString());
                    lista.SubItems.Add(item.Codigo.ToString());
                }
            }
        }

        public void EliminarFlota(int id)
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();
                var flotaEliminada = (from flota in conexion.flota
                                      where flota.FlotaID==id
                                      select flota).FirstOrDefault();


                conexion.flota.Remove(flotaEliminada);
                conexion.SaveChanges();
            }
        }
    }
}
