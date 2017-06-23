
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
   public class ValidacionesFlota
    {
        public bool ExitenCamposVacios(FlotaModelo flota)
        {
            if (flota.Empresa==string.Empty||flota.Dueno == string.Empty|| flota.Codigo == string.Empty)
            {
                return true;
            }
            return false;
        }

        public bool ExisteEmpresa(FlotaModelo flota)
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();

                var empresa = conexion.flota.Where(x => x.Empresa == flota.Empresa).FirstOrDefault();
                if (empresa != null)
                {
                    return true;
                }
                return false;
            }
        }

        public bool ExisteCodigo(FlotaModelo flota)
        {
            using (TCS_Entities conexion = new TCS_Entities())
            {
                conexion.Database.Connection.ConnectionString = AppConfigurationManager.Instance().SQLConnectionString;
                conexion.Database.Connection.Open();

                var codigo = conexion.flota.Where(x => x.Codigo == flota.Codigo).FirstOrDefault();
                if (codigo != null)
                {
                    return true;
                }
                return false;
            }
        }

        public bool ExitenValidaciones(FlotaModelo flota)
        {
           if (ExitenCamposVacios(flota))
            {
                MessageBox.Show("!No se permiten campos vacios!");
                return true;
            }

            if (ExisteEmpresa(flota))
            {
                MessageBox.Show("!Esta empresa ya existe, favor ingrese otra!");
                return true;
            }

            if (ExisteCodigo(flota))
            {
                MessageBox.Show("!Este codigo ya existe, favor ingrese otro codigo!");
                return true;
            }
            return false;
        }
    }
}
