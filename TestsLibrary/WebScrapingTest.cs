using Microsoft.VisualStudio.TestTools.UnitTesting;
using library.UTILS;
using library;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace TestsLibrary {
    [TestClass]
    public class WebScrapingTest {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver driver = WebScraping.GetDriver();
            List<ENPlanes> planes = library.UTILS.WebScraping.scrap(driver, "Barcelona", "restaurante");
            
            Assert.AreEqual(planes[0].Nombre, "Bo de Gracia");
            Assert.AreEqual(planes[1].Nombre, "Barceló Raval");
            Assert.AreEqual(planes[2].Nombre, "Vinitus Germà Petit");
            Assert.AreEqual(planes[3].Nombre, "Guell");

            Assert.AreEqual(planes[0].Precio, 20);
            Assert.AreEqual(planes[1].Precio, 20);
            Assert.AreEqual(planes[2].Precio, 20);
            Assert.AreEqual(planes[3].Precio, 20);

            Assert.AreEqual(planes[0].Ciudad, "Barcelona");
            Assert.AreEqual(planes[1].Ciudad, "Barcelona");
            Assert.AreEqual(planes[2].Ciudad, "Barcelona");
            Assert.AreEqual(planes[3].Ciudad, "Barcelona");

            Assert.AreEqual(planes[0].Categoria, "restaurante");
            Assert.AreEqual(planes[1].Categoria, "restaurante");
            Assert.AreEqual(planes[2].Categoria, "restaurante");
            Assert.AreEqual(planes[3].Categoria, "restaurante");
        }
    }
}
