using Gestion_Note.Entity;

namespace Gestion_Note.Repository;

public class EtudiantRepository : IEtudiantRepository
{

    //Implementation du Singleton
    private EtudiantRepository(){}
    private static EtudiantRepository? _instance = null;
    public static EtudiantRepository? getInstance()
    {
        if(_instance is null)
        {
            return _instance = new EtudiantRepository();
        }
        return _instance;
    }

    private List<Etudiant> _etudiants = [];
    public int Compteur {get;private set;} = 1;

    List<Etudiant> IEtudiantRepository.FindAllEtudiant()
    {
        return _etudiants;
    }

    void IEtudiantRepository.Save(Etudiant etudiant)
    {
        _etudiants.Add(etudiant);
        Compteur++;
    }
}