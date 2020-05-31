using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using library;
using System.Configuration;

namespace TestsLibrary
{
    [TestClass]
    public class CADFavoritosTest
    {
        public CADFavoritosTest()
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

        private void Insertar(ENFavoritos favorito)
        {
            favorito.nombre_usuario = "apellido apellido";
            favorito.nombre_usuario_favorito = "email3@email.com";
            if (!favorito.InsertarFavorito())
            {
                Assert.Fail("No se ha podido insertar el usuario");
            }
            else
            {
                if (!favorito.LeerFavorito())
                {
                    Assert.Fail("Sigue sin existir el usuario");
                }
            }
        }
        private void Eliminar(ENFavoritos favorito)
        {
            if (!favorito.BorrarFavorito())
            {
                Assert.Fail("No se pudo borrar");
            }
            if (favorito.LeerFavorito())
            {
                Assert.Fail("Sigue existiendo");
            }
        }


        [TestMethod]
        public void InsertarBorrarModificar()
        {
            ENFavoritos favorito = new ENFavoritos();
            favorito.nombre_usuario = "Matias";
            try
            {
                if (!favorito.LeerFavorito())
                {
                    Insertar(favorito);
                    Modificar(favorito);
                    Eliminar(favorito);
                }
                else
                {
                    Modificar(favorito);
                    Eliminar(favorito);
                }
            }
            catch (Exception e)
            {
                Assert.Fail("No deberia de haber saltado una excepcion " + e.Message);
            }

        }
        private void Modificar(ENFavoritos f)
        {
            if (f.LeerFavorito())
            {
                f.nombre_usuario = "santi";
                if (f.ModificarFavorito())
                {
                    ENFavoritos f2 = new ENFavoritos();
                    f2.nombre_usuario = f.nombre_usuario;
                    if (f2.LeerFavorito())
                    {
                        Assert.AreEqual(f.nombre_usuario, f2.nombre_usuario);
                        Assert.AreEqual(f2.nombre_usuario_favorito, f.nombre_usuario_favorito);
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
    }
}
