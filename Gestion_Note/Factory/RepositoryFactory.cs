using Gestion_Note.Repository;

namespace Gestion_Note.Factory;

public  class RepositoryFactory
{
    private RepositoryFactory(){}

    public static EtudiantRepository CreateRepositoryEtudiant()
    {
        return new EtudiantRepository(DataBaseRepository.GetInstance());
    }
}