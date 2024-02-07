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

            // QUAND le moteur d'ouverture interroge ce lecteur
            MoteurOuverture.Interroger(lecteur);

            // ALORS cette porte s'ouvre
            Assert.True(porte.MethodeOuvrirAppel�e);
        }
    }
}