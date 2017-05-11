using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TCS.Rutas;


namespace TCS_UnitTests
{
    [TestClass]
    public class Prueba_RutaSimpleBuilder
    {
        [TestMethod]
        public void PruebaUnitaria_RutaSimpleBuilderCreaExitosamente()
        {
            RutaBuilder rutaBuilder = new RutaSimpleBuilder();

            rutaBuilder.CrearRuta("Ruta de Prueba", "PuntoA", "PuntoB");
            Ruta rutaPrueba = rutaBuilder.ObtenerRuta();

            Assert.AreEqual("Ruta de Prueba", rutaPrueba.NombreRuta);
            Assert.AreEqual("PuntoA", rutaPrueba.PuntoOrigen.NombrePunto);
            Assert.AreEqual("PuntoB", rutaPrueba.PuntoDestino.NombrePunto);
   
        }
    }
}
