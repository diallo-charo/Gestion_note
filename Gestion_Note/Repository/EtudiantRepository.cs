using Gestion_Note.Entity;

namespace Gestion_Note.Repository;

public class EtudiantRepository : IEtudiantRepository
{

    private DataBaseRepository _db;

    public EtudiantRepository(DataBaseRepository db)
    {
        _db = db;
    }

    public int Compteur {get;private set;} = 1;

    public void Save(Etudiant etudiant)
    {
        _db._etudiants.Add(etudiant);
        Compteur++;
    }

    public List<Etudiant> FindAllEtudiant()
    {
        return _db._etudiants;
    }

    

    
}