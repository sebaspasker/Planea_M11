using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using library;
using System.Configuration;

namespace TestsLibrary {
    /// <summary>
    /// Descripción resumida de CADUsuarioTest
    /// </summary>
    [TestClass]
    public class CADUsuarioTest {
        public CADUsuarioTest()
        {
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Obtiene o establece el contexto de las pruebas que proporciona
        ///información y funcionalidad para la serie de pruebas actual.
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

        #region Atributos de prueba adicionales
        //
        // Puede usar los siguientes atributos adicionales conforme escribe las pruebas:
        //
        // Use ClassInitialize para ejecutar el código antes de ejecutar la primera prueba en la clase
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup para ejecutar el código una vez ejecutadas todas las pruebas en una clase
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Usar TestInitialize para ejecutar el código antes de ejecutar cada prueba 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup para ejecutar el código una vez ejecutadas todas las pruebas
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        private void Insertar(ENUsuario usuario)
        {
            usuario.apellidos = "apellido apellido";
            usuario.email = "email@email.com";
            usuario.edad = 10;
            usuario.nombre = "Nombre";
            usuario.password = "Password";
            usuario.preferencia = "Preferencia";
            if(!usuario.InsertarUsuario())
            {
                Assert.Fail("No se ha podido insertar el usuario");
            } 
            else
            {
                if(!usuario.SeleccionarUsuario())
                {
                    Assert.Fail("Sigue sin existir el usuario");
                }
            }
        }

        private void Eliminar(ENUsuario usuario)
        {
            if(!usuario.BorrarUsuario())
            {
                Assert.Fail("No se ha podido eliminar el usuario");
            }
            else
            {
                if(usuario.SeleccionarUsuario())
                {
                    Assert.Fail("Sigue existiendo el usuario");
                }
            }
        }

        [TestMethod]
        public void BorrarEInsertar()
        {
            ENUsuario usuario = new ENUsuario();
            usuario.nombre_usuario = "prueba1";
            try
            {
                if(!usuario.SeleccionarUsuario())
                {
                    Insertar(usuario);
                    Eliminar(usuario);
                }
                else
                {
                    Eliminar(usuario);
                    Insertar(usuario);
                    Eliminar(usuario);
                }
            } catch(Exception e)
            {
                Assert.Fail("No deberia de haber saltado una excepcion " + e.Message + " " + e.StackTrace);
            }
        }

        private void Modificar(ENUsuario usuario)
        {
            if(usuario.SeleccionarUsuario())
            {
                usuario.nombre = "Juan";
                usuario.preferencia = "Golf";
                usuario.edad = 12;
                usuario.apellidos = "DeLaTorre";
                if(usuario.ModificarUsuario())
                {
                    ENUsuario usuario2 = new ENUsuario();
                    usuario2.nombre_usuario = usuario.nombre_usuario;
                    if(usuario2.SeleccionarUsuario())
                    {
                        Assert.AreEqual(usuario, usuario2);
                    } else
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
        public void InsertarYModificar()
        {
            ENUsuario usuario = new ENUsuario();
            usuario.nombre_usuario = "prueba1";
            try
            {
                if(!usuario.SeleccionarUsuario())
                {
                    Insertar(usuario);
                    Modificar(usuario);
                    Eliminar(usuario);
                }
                else
                {
                    Modificar(usuario);
                    Eliminar(usuario);
                }
            }
            catch(Exception e)
            {
                Assert.Fail("No deberia de haber saltado una excepcion " + e.Message);
            }
        }
    }
}
