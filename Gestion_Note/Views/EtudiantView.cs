using Gestion_Note.Dto;


namespace Gestion_Note.Views
{
    class EtudiantView
    {
       
        public static int Menu() {
            bool result;
            int choix;
            do
            {
                Console.WriteLine("1. Ajouter un etudiant dans une liste");
                Console.WriteLine("2. Afficher la liste des étudiants");
                Console.WriteLine("3. Ajouter une note a un etudiant");
                Console.WriteLine("4. Lister les notes d'un etudiant");
                Console.WriteLine("0. Quitter");
                Console.WriteLine("Saisir votre choix : ");
                result = int.TryParse(Console.ReadLine(), out choix);
            } while (!result);
            return choix;
        }
        // public static void AfficherEtudiant(Etudiant etudiant)
        // {
        //     Console.WriteLine($"Matricule: {etudiant.matricule}");
        //     Console.WriteLine($"Nom: {etudiant.nom}");
        //     Console.WriteLine($"Prenom: {etudiant.prenom}");
        //     Console.WriteLine("Notes:");
        //     foreach (var note in etudiant.notes)
        //     {
        //         Console.WriteLine(note);
        //     }
        // }
        
        // public static void AfficherEtudiants(List<Etudiant> etudiants)
        // {
        //     foreach (var etudiant in etudiants)
        //     {
        //         AfficherEtudiant(etudiant);
        //         Console.WriteLine("--------------------");
        //     }
        // }

        public static EtudiantSaisiDto? SaisieEtudiant()
        {
            EtudiantSaisiDto? etudiantDto = null;
            bool valid = false;
            do
            {
                string nomComplet = LireChaine("Nom : ");
                string dateNaiss = LireChaine("Date de Naissance format dd/MM/yyyy : ");
                try
                {
                    etudiantDto = new EtudiantSaisiDto
                    {
                        NomComplet = nomComplet,
                        DateNaissance = dateNaiss
                    };
                    valid = true;
                }
                catch (ArgumentException ex)
                {
                    
                    Console.WriteLine(ex.Message);
                }
                
            }while (!valid);
            return etudiantDto;
        }

        private static string LireChaine(string msg)
        {
            string? chaine;
            do
            {
                Console.WriteLine(msg);
                chaine = Console.ReadLine();
            } while (chaine == null);
            return chaine;
        }

        private static int LireEntier(string msg)
        {
            bool result ;
            int choix ;
            do
            {
                Console.WriteLine(msg);
                result = int.TryParse(Console.ReadLine(), out choix);
            } while (!result);
            return choix;
        }

        private static double LireDouble(string msg)
        {
            bool result;
            double choix;
            do
            {
                Console.WriteLine(msg);
                result = double.TryParse(Console.ReadLine(), out choix);
            } while (!result);
            return choix;
        }

        
    }
}