using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using library;
using library.UTILS;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace TestsLibrary {
    [TestClass]
    public class createPlayGround {
        [TestMethod]
        public void TestMethod1()
        {
            for(int i=0; i<=5; i++)
            {
                ENUsuario en = new ENUsuario();
                en.nombre_usuario = "nombre" + i.ToString();
                en.nombre = "Juan";
                en.apellidos = "apellido" + i.ToString();
                en.password = "password";
                en.email = "em" + i.ToString() + "@em.com";
                en.ciudad = "Barcelona";
                en.preferencia = "restaurante";
                en.edad = 10;
                if(!en.SeleccionarUsuario())
                {
                    en.InsertarUsuario();
                }
            } 

            IWebDriver driver = library.UTILS.WebScraping.GetDriver();
            List<ENPlanes> planes = WebScraping.scrap(driver, "Barcelona", "restaurante");
            foreach(ENPlanes plan in planes)
            {
                if(Filter.filterNombrePlan(plan.Nombre))
                {
                    if(!plan.SeleccionarPlan())
                    {
                        plan.InsertarPlan();
                    }
                }
            } 
        }
    }
}
