using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestUnitaire
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Test_PlanningGetJourActuel()
        {

            DateTime d = new DateTime(2015,11,15, 0,0,0);
            Planning p = new Planning("planning", d);

            int jourAttendu = 29;
            int jourObtenu = p.getJourActuel();


            Assert.AreEqual(jourAttendu, jourObtenu);

        }

        [TestMethod]
        public void Test_LieuGetCoordonneeX()
        {
            Lieu l = new Lieu("Cratere Cosmique", 210, 150);

            double coordonneeAttendu = 210;
            double coordonneeObtenu = l.GetCoordonneeX;

            Assert.AreEqual(coordonneeAttendu, coordonneeObtenu);

        }

        [TestMethod]
        public void Test_AstronauteGetNom()
        {

            Astronautes a = new Astronautes("Simonazzi", "Nicolas", 23);

            string nomAttendu = "Simonazzi";
            string nomObtenu = a.GetnomAstronaute;

            Assert.AreEqual(nomAttendu, nomObtenu);

        }

        [TestMethod]
        public void Test_JourGetListeActivite()
        {

            Lieu l = new Lieu("Cratere Cosmique", 210, 150);

            Astronautes a1 = new Astronautes("Simonazzi", "Nicolas", 23);
            Astronautes a2 = new Astronautes("Eckert", "Maxime", 22);

            List<Astronautes> listeAstro = new List<Astronautes>();

            listeAstro.Add(a1);
            listeAstro.Add(a2);

            Activités acti = new Activités("Activité1", "Private", 120, 180, l, listeAstro, "blabla");

            List<Astronautes>  listeAstroObtenu = acti.GetlisteAstronautes;

            Assert.AreEqual(listeAstro, listeAstroObtenu);
        
        
        }

    }
}
