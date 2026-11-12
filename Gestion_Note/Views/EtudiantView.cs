using Gestion_Note.Entity;

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
    }
}