namespace ControleAcces;

public class MoteurOuverture
{
    private readonly IPorte[] _portes;

    public MoteurOuverture(params IPorte[] portes)
    {
        _portes = portes;
    }

    public void Interroger(ILecteur lecteur)
    {
        if (!lecteur.BadgeDétecté) 
            return;

        foreach (var porte in _portes)
            porte.Ouvrir();
    }
}