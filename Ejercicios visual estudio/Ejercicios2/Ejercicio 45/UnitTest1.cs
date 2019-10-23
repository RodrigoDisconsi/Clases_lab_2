using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MiClaseExcepcion;

namespace Ejercicio_45
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void ExcepcionCero()
        {
            MiClase.ExepcionDivisionCero();
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void ExcepcionConstructor()
        {
            MiClase aux = new MiClase();
        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void ExcepcionConstructor2()
        {
            MiClase aux = new MiClase(2);
        }

        [TestMethod]
        [ExpectedException(typeof(MiException))]
        public void ExcepcionConstructor3()
        {
            MiClase aux = new MiClase("hola");
            aux.MiMetodo();
        }
    }
}
