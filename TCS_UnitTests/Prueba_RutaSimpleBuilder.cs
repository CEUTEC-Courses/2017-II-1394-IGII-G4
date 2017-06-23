using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TCS.Rutas;
using TCS.InitialConfiguration;


namespace TCS_UnitTests
{
    [TestClass]
    public class Prueba_RutaSimpleBuilder
    {
        [TestMethod]
        public void PruebaUnitaria_RutaSimpleBuilderCreaYBorraExitosamente()
        {
            //Correr test si hay una base de datos valida, si no entonces pasarla
            if (AppConfigurationManager.Instance().checkDatabaseParameters())
            {
                PuntoSimpleBuilder origenBuilder = new PuntoSimpleBuilder();
                origenBuilder.crearPunto("Origen");
                PuntoSimpleBuilder destinoBuilder = new PuntoSimpleBuilder();
                destinoBuilder.crearPunto("Destino");
                RutaSimpleBuilder RutaBuilder = new RutaSimpleBuilder();
                Assert.IsTrue(RutaBuilder.crearRuta("RutaPrueba", "Origen", "Destino"));
                Ruta ruta = new Ruta(RutaBuilder.obtenerRuta().RutaID);
                AppConfigurationManager.Instance().DbContext.punto.Remove(origenBuilder.obtenerPunto());
                AppConfigurationManager.Instance().DbContext.punto.Remove(destinoBuilder.obtenerPunto());
                Assert.IsTrue(ruta.eliminarRuta());
            }
            else
            {
                Assert.Inconclusive("No hay base de datos para probar");
            }
        }
    }
}
