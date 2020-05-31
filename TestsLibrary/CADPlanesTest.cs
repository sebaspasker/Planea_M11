using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using library;
using System.Configuration;

namespace TestsLibrary
{
    [TestClass]
    public class CADPlanesTest
    {
        public CADPlanesTest()
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

        private void Insertar(ENPlanes plan)
        {
            plan.Ciudad = "Callosita";
            plan.Categoria = "Cenita";
            plan.Precio = 15;
            if (!plan.InsertarPlan())
            {
                Assert.Fail("No se ha podido insertar el usuario");
            }
            else
            {
                if (!plan.SeleccionarPlan())
                {
                    Assert.Fail("Sigue sin existir el usuario");
                }
            }
        }
        private void UltimoPlan(ENPlanes plan)
        {
            if (!plan.UltimoPlan())
            {
                Assert.Fail("No se ha podido encontrar el último usuario");
            }
        }
        private void Insertar2(ENPlanes plan)
        {
            plan.Ciudad = "Callosita";
            plan.Categoria = "Golf";
            plan.Precio = 15;
            if (!plan.InsertarPlan())
            {
                Assert.Fail("No se ha podido insertar el usuario");
            }
            else
            {
                if (!plan.SeleccionarPlan())
                {
                    Assert.Fail("Sigue sin existir el usuario");
                }
            }
        }
        private void SiguientePlan(ENPlanes plan)
        {
            if (!plan.SiguientePlan())
            {
                Assert.Fail("No se ha podido encontrar el usuario");
            }
        }

        private void Eliminar(ENPlanes plan)
        {
            if (!plan.BorrarPlan())
            {
                Assert.Fail("No se ha podido eliminar el usuario");
            }
            else
            {
                if (plan.SeleccionarPlan())
                {
                    Assert.Fail("Sigue existiendo el usuario");
                }
            }
        }
        private void Modificar(ENPlanes plan)
        {
            if (plan.SeleccionarPlan())
            {
                plan.Nombre = "Juan";
                plan.Categoria = "Golf";
                plan.Precio = 12;
                plan.Ciudad = "Alicante";
                if (plan.ModificarPlan())
                {
                    ENPlanes plan2 = new ENPlanes();
                    plan2.Nombre = plan.Nombre;
                    if (plan2.SeleccionarPlan())
                    {
                        Assert.AreEqual(plan.Nombre, plan2.Nombre);
                        Assert.AreEqual(plan2.Categoria, plan.Categoria);
                        Assert.AreEqual(plan2.Precio, plan.Precio);
                        Assert.AreEqual(plan2.Ciudad, plan.Ciudad);
                    }
                    else
                    {
                        Assert.Fail("No se ha podido encontrar al usuario");
                    }

                }
                else
                {
                    Assert.Fail("No se ha podido modificar el usuario");
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
            ENPlanes plan = new ENPlanes();
            plan.Nombre = "prueba8";
            try
            {
                if (!plan.SeleccionarPlan())
                {
                    Insertar(plan);
                    Eliminar(plan);
                }
                else
                {
                    Eliminar(plan);
                }
            }
            catch (Exception e)
            {
                Assert.Fail("No deberia de haber saltado una excepcion " + e.Message + " " + e.StackTrace);
            }
        }
        [TestMethod]
        public void InsertarBorrarModificar()
        {
            ENPlanes plan = new ENPlanes();
            plan.Nombre = "prueba8";
            try
            {
                if (!plan.SeleccionarPlan())
                {
                    Insertar(plan);
                    Modificar(plan);
                    Eliminar(plan);
                }
                else
                {
                    Modificar(plan);
                    Eliminar(plan);
                }
            }
            catch (Exception e)
            {
                Assert.Fail("No deberia de haber saltado una excepcion " + e.Message + " " + e.StackTrace);
            }
        }
        [TestMethod]
        public void SiguientePlan()
        {
            ENPlanes plan = new ENPlanes();
            ENPlanes plan2 = new ENPlanes();
            plan.Nombre = "usu2";
            plan2.Nombre = "usu3";
            try
            {
                if (!plan.SeleccionarPlan() && !plan2.SeleccionarPlan())
                {
                    Insertar(plan);
                    Insertar2(plan2);
                    SiguientePlan(plan);
                    //Eliminar(plan);
                    //Eliminar(plan2);
                }
                else if (!plan.SeleccionarPlan() && plan2.SeleccionarPlan())
                {
                    Insertar2(plan2);
                    SiguientePlan(plan);
                    //Eliminar(plan);
                    //Eliminar(plan2);
                }
                else
                {
                    SiguientePlan(plan);
                    //Eliminar(plan);
                    //Eliminar(plan2);
                }

            }
            catch (Exception e)
            {
                Assert.Fail("No deberia de haber saltado una excepcion " + e.Message);
            }
        }
        [TestMethod]
        public void PrimeroUltimo()
        {
            ENPlanes plan = new ENPlanes();
            plan.Nombre = "usu6";
            try
            {
                if (!plan.SeleccionarPlan())
                {
                    Insertar(plan);
                    UltimoPlan(plan);
                    Eliminar(plan);
                }
                else
                {
                    UltimoPlan(plan);
                    Eliminar(plan);
                }

            }
            catch (Exception e)
            {
                Assert.Fail("No deberia de haber saltado una excepcion " + e.Message);
            }
        }

    }
}
