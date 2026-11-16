using Gestion_Note.Dto;
using Gestion_Note.Factory;
using Gestion_Note.Service;
using Gestion_Note.Views;

class Program
{
    static void Main(string[] args)
    {
        DateService dateService = new DateService();
        
        EtudiantService etudiantService = new EtudiantService(RepositoryFactory.CreateRepositoryEtudiant(),dateService);

        int choix;
        do
        {
           choix =  EtudiantView.Menu();
           switch (choix)
           {

            case 0: 
                Console.WriteLine("A revoir!");
                break;
            case 1: 
                EtudiantSaisiDto? etudiantDto = EtudiantView.SaisieEtudiant();
                bool result = etudiantService.AddEtudiant(etudiantDto,new MatriculeService());
                    if (result)
                    {
                        Console.WriteLine("Etudiant ajouter avec Success!");
                    }
                break;
            case 2:

                break;
            
            default:
                Console.WriteLine("Choix pas valid");
                break;
           }
        } while (choix!=0);
    }
}