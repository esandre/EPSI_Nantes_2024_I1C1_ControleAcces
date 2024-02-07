namespace ControleAcces;

public class MoteurOuverture
{
    private readonly IPorte _porte;

    public MoteurOuverture(IPorte porte)
    {
        _porte = porte;
    }

    public void Interroger(ILecteur lecteur)
    {
        _porte.Ouvrir();
    }
}