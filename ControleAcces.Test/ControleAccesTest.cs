using ControleAcces.Test.Utilities;

namespace ControleAcces.Test
{
    public class ControleAccesTest
    {
        [Fact]
        public void CasNominal()
        {
            // ETANT DONNE un lecteur ayant détecté un badge
            // ET une porte lui étant liée
            var lecteur = new LecteurFake();
            lecteur.SimulerPrésentationBadge();

            var porte = new PorteSpy();
            var moteur = new MoteurOuverture(porte);

            // QUAND le moteur d'ouverture interroge ce lecteur
            MoteurOuverture.Interroger(lecteur);

            // ALORS cette porte s'ouvre
            Assert.True(porte.MethodeOuvrirAppelée);
        }

        [Fact]
        public void CasSansInterrogation()
        {
            // ETANT DONNE un lecteur ayant détecté un badge
            // ET une porte lui étant liée
            var lecteur = new LecteurFake();
            lecteur.SimulerPrésentationBadge();

            var porte = new PorteSpy();
            var moteur = new MoteurOuverture(porte);

            // ALORS cette porte s'ouvre
            Assert.False(porte.MethodeOuvrirAppelée);
        }
    }
}