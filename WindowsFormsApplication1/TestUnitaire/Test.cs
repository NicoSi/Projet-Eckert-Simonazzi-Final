using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

//On test plusieurs fonctions de type accesseurs qui renvoient des attributs de type string, int, List..
namespace TestUnitaire
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        // On test si la méthode qui renvoie le jour actuelle fonctionne
        public void Test_PlanningGetJourActuel()
        {

            DateTime d = new DateTime(2015,11,15, 0,0,0);
            Planning p = new Planning("planning", d);
            //On attend le jour en question (qui évolue au cours du temps, ce ne sera donc plus 29 quand vous lirez ceci)
            int jourAttendu = 29;
            int jourObtenu = p.getJourActuel();

            //On effectue le test ici
            Assert.AreEqual(jourAttendu, jourObtenu);

        }

        //On test si la méthode qui renvoie les coordonnée d'un lieu fonctionne
        [TestMethod]
        public void Test_LieuGetCoordonneeX()
        {
            Lieu l = new Lieu("Cratere Cosmique", 210, 150);

            double coordonneeAttendu = 210;
            double coordonneeObtenu = l.GetCoordonneeX;
            // Test ici
            Assert.AreEqual(coordonneeAttendu, coordonneeObtenu);

        }

        [TestMethod]
        //On test ici si la méthode qui renvoie le nom d'un astronaute fonctionne
        public void Test_AstronauteGetNom()
        {

            Astronautes a = new Astronautes("Simonazzi", "Nicolas", 23);

            string nomAttendu = "Simonazzi";
            string nomObtenu = a.GetnomAstronaute;
            // test ici
            Assert.AreEqual(nomAttendu, nomObtenu);

        }

        [TestMethod]
        //On test si la méthode qui renvoie les astronautes associés à une activité fonctionne
        public void Test_JourGetListeActivite()
        {

            Lieu l = new Lieu("Cratere Cosmique", 210, 150);
            //instanciation de deux astronautes qu'on doit retrouver dans la liste à la fin du test
            Astronautes a1 = new Astronautes("Simonazzi", "Nicolas", 23);
            Astronautes a2 = new Astronautes("Eckert", "Maxime", 22);
            // On créer une liste d'astronautes
            List<Astronautes> listeAstro = new List<Astronautes>();

            listeAstro.Add(a1);
            listeAstro.Add(a2);
            //On implémente un objet activité
            Activités acti = new Activités("Activité1", "Private", 120, 180, l, listeAstro, "blabla");

            List<Astronautes>  listeAstroObtenu = acti.GetlisteAstronautes;
            //Test ici 
            Assert.AreEqual(listeAstro, listeAstroObtenu);
        
        
        }

    }
}
