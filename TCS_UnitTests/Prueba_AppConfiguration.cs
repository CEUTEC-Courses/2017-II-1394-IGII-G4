﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TCS.InitialConfiguration;

namespace TCS_UnitTests
{
    /// <summary>
    /// Summary description for Prueba_AppConfiguration
    /// </summary>
    [TestClass]
    public class Prueba_AppConfiguration
    {
        public Prueba_AppConfiguration()
        {
           
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion
        [TestMethod]
        public void PruebaEscibeRegistro()
        {
            Assert.IsNotNull(AppConfigurationManager.Instance().TCSKey);
        }

        [TestMethod]
        public void PruebaLecturaRegistro()
        {
            Assert.IsTrue(AppConfigurationManager.Instance().leerDatabaseParameters());
        }
                
    }
}
