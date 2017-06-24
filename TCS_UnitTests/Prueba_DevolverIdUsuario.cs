using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TCS.UsuariosClases;
using TCS.InitialConfiguration;

namespace TCS_UnitTests
{
    [TestClass]
    public class Prueba_DevolverIdUsuario
    {
        [TestMethod]
        public void consultarIdUsuarioExitosamente()
        {
            if (AppConfigurationManager.Instance().checkDatabaseParameters())
            {
                CRUDUsuario crud_usuario = new CRUDUsuario();
                int devolverUsuario = crud_usuario.devolverIdUsuario("Administrador");

                Assert.AreEqual(59, devolverUsuario);
            }
            else
            {
                Assert.Inconclusive("No hay base de datos para probar");
            }
        }
    }
}
