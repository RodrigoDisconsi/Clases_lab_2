using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CentralitaHerencia;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CentralitaNoNull()
        {
            Centralita aux = new Centralita();
            Assert.IsNotNull(aux.Llamadas);
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void CentralitaOperatorLocalException()
        {
            Centralita c = new Centralita();
            Local l = new Local("Bernal", 40, "Berazategui", 10);
            Local l2 = new Local(l, 10);
            c += l;
            c += l2;
        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void CentralitaOperatorProvincialException()
        {
            Centralita c = new Centralita();
            Provincial p1 = new Provincial("Bernal", Provincial.Franja.Franja_2, 244, "Berazategui");
            Provincial p2 = new Provincial(Provincial.Franja.Franja_3, p1);
            c += p1;
            c += p2;
        }

        [TestMethod]
        public void ValidarLLamadas()
        {
            Provincial p1 = new Provincial("Bernal", Provincial.Franja.Franja_2, 244, "Berazategui");
            Provincial p2 = new Provincial(Provincial.Franja.Franja_3, p1);
            Local l1 = new Local("Bernal", 40, "Berazategui", 10);
            Local l2 = new Local(l1, 10);
        }


    }
}
