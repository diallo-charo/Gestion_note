using Gestion_Note.Entity;

namespace Gestion_Note.Repository;

public class DataBaseRepository
{
    public  List<Etudiant> _etudiants = [];

    //singleton
    private static DataBaseRepository? _instance = null;
    private DataBaseRepository(){}
    public static DataBaseRepository GetInstance()
    {
        return _instance ??=  new DataBaseRepository();
    }
}