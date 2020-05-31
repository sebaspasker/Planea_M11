using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using library;
using System.Configuration;

namespace TestsLibrary
{
    [TestClass]
    public class CADParejasTest
    {
        public CADParejasTest()
        {

        }
        private TestContext testContextInstance;
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

        private void Insertar(ENParejas p)
        {
            p.nombre_usuario_2 = "Juana";
            p.hora_inicio = 10;
            p.hora_fin = 11;
            p.nombre_plan = "Cenita";
            p.plan_aceptado = "Si";
            p.fecha = "30-12-2000";
            
            if (!p.InsertarPareja())
            {
                Assert.Fail("No se ha podido insertar el usuario");
            }
            else
            {
                if (!p.SeleccionarPareja())
                {
                    Assert.Fail("Sigue sin existir el usuario");
                }
            }
        }
        private void Eliminar(ENParejas p)
        {
            if (!p.BorrarPareja())
            {
                Assert.Fail("No se ha podido borrar el usuario");
            }
            if (p.SeleccionarPareja())
            {
                Assert.Fail("Sigue existiendo");
            }
        }
        private void Modificar(ENParejas p)
        {
            p.nombre_usuario_1 = "santi";
            p.nombre_usuario_2 = "Ana";
            if (p.ModificarPareja())
            {
                ENParejas p2 = new ENParejas();
                p2.nombre_usuario_1 = p.nombre_usuario_1;
                p2.nombre_usuario_2 = p.nombre_usuario_2;
                if (p2.SeleccionarPareja())
                {
                    Assert.AreEqual(p.nombre_usuario_1, p2.nombre_usuario_1);
                    Assert.AreEqual(p.nombre_usuario_2, p2.nombre_usuario_2);
                    Assert.AreEqual(p2.hora_fin, p.hora_fin);
                    Assert.AreEqual(p2.hora_inicio, p.hora_inicio);
                    Assert.AreEqual(p2.fecha, p.fecha);
                    Assert.AreEqual(p2.plan_aceptado, p.plan_aceptado);
                }
                else
                {
                    Assert.Fail("No se ha podido encontrar al usuario");
                }

            }
            else
            {
                Assert.Fail("No se puede modificar si no existe");
            }
        }

        [TestMethod]
        public void BorrarEInsertar()
        {
            ENParejas p = new ENParejas();
            p.nombre_usuario_1 = "prueba8";
            try
            {
                if (!p.SeleccionarPareja())
                {
                    Insertar(p);
                    Eliminar(p);
                }
                else
                {
                    Eliminar(p);
                }
            }
            catch (Exception e)
            {
                Assert.Fail("No deberia de haber saltado una excepcion " + e.Message + " " + e.StackTrace);
            }
        }
    }
}
