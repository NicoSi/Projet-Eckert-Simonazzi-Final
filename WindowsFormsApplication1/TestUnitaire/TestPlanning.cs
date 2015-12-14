using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitaire
{
    [TestClass]
    public class TestPlanning
    {
        [TestMethod]
        public void Test_GetJourActuel()
        {

            DateTime d = new DateTime(2015,11,15, 0,0,0);
            Planning p = new Planning("planning", d);

            int jourAttendu = 29;
            int jourObtenu = p.getJourActuel();


            Assert.AreEqual(jourAttendu, jourObtenu);

        }
    }
}
