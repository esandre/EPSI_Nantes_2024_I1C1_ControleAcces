using ControleAcces.Test.Utilities;

namespace ControleAcces.Test
{
    public class ControleAccesTest
    {
        [Fact]
        public void CasNominal()
        {
            // ETANT DONNE un lecteur ayant d�tect� un badge
            // ET une porte lui �tant li�e
            var lecteur = new LecteurFake();
            lecteur.SimulerPr�sentationBadge();

            var porte = new PorteSpy();
            var moteur = new MoteurOuverture(porte);

            // QUAND le moteur d'ouverture interroge ce lecteur
            moteur.Interroger(lecteur);

            // ALORS cette porte s'ouvre
            Assert.Equal(1, porte.NombreAppelsM�thodeOuvrir);
        }

        [Fact]
        public void CasSansInterrogation()
        {
            // ETANT DONNE un lecteur ayant d�tect� un badge
            // ET une porte lui �tant li�e
            var lecteur = new LecteurFake();
            lecteur.SimulerPr�sentationBadge();

            var porte = new PorteSpy();
            var moteur = new MoteurOuverture(porte);

            // ALORS cette porte ne s'ouvre pas
            Assert.Equal(0, porte.NombreAppelsM�thodeOuvrir);
        }

        [Fact]
        public void CasSansPr�sentation()
        {
            // ETANT DONNE un lecteur
            // ET une porte lui �tant li�e
            var lecteur = new LecteurFake();
            var porte = new PorteSpy();
            var moteur = new MoteurOuverture(porte);

            // QUAND le moteur d'ouverture interroge ce lecteur
            moteur.Interroger(lecteur);

            // ALORS cette porte ne s'ouvre pas
            Assert.Equal(0, porte.NombreAppelsM�thodeOuvrir);
        }

        [Fact]
        public void CasPr�sentationPuisRien()
        {
            // ETANT DONNE un lecteur ayant d�tect� un badge
            // ET une porte lui �tant li�e
            var lecteur = new LecteurFake();
            lecteur.SimulerPr�sentationBadge();

            var porte = new PorteSpy();
            var moteur = new MoteurOuverture(porte);

            // QUAND le moteur d'ouverture interroge ce lecteur deux fois
            moteur.Interroger(lecteur);
            moteur.Interroger(lecteur);

            // ALORS cette porte s'ouvre une fois
            Assert.Equal(1, porte.NombreAppelsM�thodeOuvrir);
        }
    }
}