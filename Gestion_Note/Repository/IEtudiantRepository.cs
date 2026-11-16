using Gestion_Note.Entity;

namespace Gestion_Note.Repository;

public interface IEtudiantRepository
{
    int Compteur{get;}
    void Save(Etudiant etudiant);
    List<Etudiant> FindAllEtudiant();

} 