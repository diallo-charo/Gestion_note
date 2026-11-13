using Gestion_Note.Entity;

namespace Gestion_Note.Repository;

internal interface IEtudiantRepository
{
    void Save(Etudiant etudiant);
    List<Etudiant> FindAllEtudiant();

} 