using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TCS.UsuariosClases;

namespace TCS_UnitTests
{
    [TestClass]
    public class Prueba_DevolverIdUsuario
    {
        [TestMethod]
        public void consultarIdUsuarioExitosamente()
        {
            CRUDUsuario crud_usuario = new CRUDUsuario();
            int devolverUsuario=crud_usuario.devolverIdUsuario("Administrador");

            Assert.AreEqual(59, devolverUsuario);
        }
    }
}
