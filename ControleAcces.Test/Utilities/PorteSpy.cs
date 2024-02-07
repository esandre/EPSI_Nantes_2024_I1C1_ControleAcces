namespace ControleAcces.Test.Utilities;

internal class PorteSpy : IPorte
{
    public bool MethodeOuvrirAppelée { get; private set; }

    public void Ouvrir()
    {
        MethodeOuvrirAppelée = true;
    }
}