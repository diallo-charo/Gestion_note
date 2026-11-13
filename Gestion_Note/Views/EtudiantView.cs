using Gestion_Note.Entity;
using Gestion_Note.Service;

namespace Gestion_Note.Views
{
    class EtudiantView
    {
        public static void AfficherEtudiant(Etudiant etudiant)
        {
            Console.WriteLine($"Matricule: {etudiant.matricule}");
            Console.WriteLine($"Nom: {etudiant.nom}");
            Console.WriteLine($"Prenom: {etudiant.prenom}");
            Console.WriteLine("Notes:");
            foreach (var note in etudiant.notes)
            {
                Console.WriteLine(note);
            }
        }
        
        public static void AfficherEtudiants(List<Etudiant> etudiants)
        {
            foreach (var etudiant in etudiants)
            {
                AfficherEtudiant(etudiant);
                Console.WriteLine("--------------------");
            }
        }

        public static Etudiant SaisieEtudiant()
        {
            string nom = LireChaine("Nom : ");
            string prenom = LireChaine("Prénom : ");
            return new Etudiant(nom, prenom, new List<double>());
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
            bool result = false;
            int choix = 0;
            do
            {
                Console.WriteLine(msg);
                result = int.TryParse(Console.ReadLine(), out choix);
            } while (!result);
            return choix;
        }

        private static double LireDouble(string msg)
        {
            bool result = false;
            double choix = 0;
            do
            {
                Console.WriteLine(msg);
                result = double.TryParse(Console.ReadLine(), out choix);
            } while (!result);
            return choix;
        }

        public static void MenuEtudiant()
        {
            int choix;
            do
            {
                Console.WriteLine("1. Ajouter un étudiant");
                Console.WriteLine("2. Afficher les étudiants");
                Console.WriteLine("3. Ajouter une note à un étudiant");
                Console.WriteLine("4. Quitter");
                choix = LireEntier("Choix : ");
                switch (choix)
                {
                    case 1:
                        var etudiant = SaisieEtudiant();
                        EtudiantService.AjouterEtudiant(etudiant);
                        break;
                    case 2:
                        AfficherEtudiants(EtudiantService.etudiants);
                        break;
                    case 3:
                        string matricule = LireChaine("Matricule de l'étudiant : ");
                        double note = LireDouble("Note : ");
                        if (!EtudiantService.AddNote(note, matricule))
                        {
                            Console.WriteLine("Le matricule ne correspond à aucun étudiant");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Au revoir !");
                        break;
                    default:
                        Console.WriteLine("Choix invalide");
                        break;
                }
            } while (choix != 4);
        }
    }
}