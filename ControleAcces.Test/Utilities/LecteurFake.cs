namespace ControleAcces.Test.Utilities;

internal class LecteurFake : ILecteur
{
    public bool BadgeDétecté { get; private set; }

    public void SimulerPrésentationBadge()
    {
        BadgeDétecté = true;
    }
}