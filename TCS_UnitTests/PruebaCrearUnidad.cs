﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TCS.MenuFlota.Unidad;

namespace TCS_UnitTests
{
    [TestClass]
    public class PruebaCrearUnidad
    {
        [TestMethod]
        public void TestMethod1()
        {

        }

        [TestMethod]
        public void CrearUnidad()
        {
            //Arrange
            UnidadModelo unidad = new UnidadModelo();
            unidad.Placa = "AM2775";
            unidad.Marca = "Lancer";
            unidad.Modelo = "GT";
            unidad.Estado = "Disponibiliad";


            //Act
            CRUDUnidad crearUnidad = new CRUDUnidad();
            var resultado = crearUnidad.CrearUnidad(unidad);

            //Assert
            Assert.AreEqual(true, resultado);


        }

    }
}