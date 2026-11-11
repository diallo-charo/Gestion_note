using Etudiant = (string matricule, string nom, string prenom, System.Collections.Generic.List<double> notes);
class Program {
    private static List<Etudiant> etudiants = new();
    public static void Main(string[] args) {
        etudiants.Add(("ism1", "Ba", "Amadou", new List<double>{10, 12.5, 14}));
        int compteur = 1;
        dynamic x = 2;
        x = 12;
        x = 12.5;
        int choix;
        do
        {
            choix = Menu();
            switch (choix)
            {  
                case 0: 
                    Console.WriteLine("Au revoir");
                    break;

                case 1:
                    var etudiant = SaisieEtudiant(ref compteur);
                    etudiants.Add(etudiant);
                    break;

                case 2:
                    AfficherEtudiants();
                    break;

                case 3:
                    string matricule = LireChaine("Saisir le matricule à rechercher : ");
                    double note = -1;
                    bool result = true;
                    do
                    {
                        note = LireDouble("Saisir une note entre 0 et 20 : ");
                        if (note < 0 || note > 20)
                        {
                            Console.WriteLine("Note invalide");
                            result = false;
                        }
                    } while (!result);
                    result = false;
                    do
                    {
                        result = AddNote(note, matricule);
                    } while (!result);
                    break;

                case 4:
                    matricule = LireChaine("Saisir le matricule : ");
                    Etudiant? etudiantNullable= GetEtudiantByMatricule(matricule);
                    if (etudiantNullable is null)
                    {
                        Console.WriteLine("Ce matricule ne correspond à aucun étudiant");
                    } else
                    {
                        var notes = etudiantNullable?.notes;
                        notes?.ForEach(n => Console.WriteLine(n));
                    }
                    break;
                
                default: 
                    Console.WriteLine("Saisir un entier entre 0 et 4");
                    break;
            }
        } while (choix != 0);
        
    }

    private static int Menu() {
        bool result = false;
        int choix = 0;
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

    private static Etudiant SaisieEtudiant(ref int compteur)
    {
        return (GenererMatricule(ref compteur), LireChaine("Nom : "), LireChaine("Prénom : "), []);
    }

    private static string GenererMatricule(ref int compteur)
    {
        compteur++;
        // return "ism" + compteur;
        return $"ism{compteur}";
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

    private static void AfficherEtudiants()
    {
        etudiants.ForEach(e => Console.WriteLine($"Matricule : {e.matricule} ; Nom : {e.nom} ; Prénom : {e.prenom}"));
    }

    private static Etudiant? GetEtudiantByMatricule(string matricule)
    {
        return etudiants.FirstOrDefault(e => e.matricule == matricule);
    }

    private static bool AddNote(double note, string matricule)
    {
        Etudiant? etudiant = GetEtudiantByMatricule(matricule);
        if (etudiant is null)
        {
            Console.WriteLine("Le matricule ne correspond à aucun étudiant");
            return false;
        }
        etudiant?.notes.Add(note);
        return true;
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
}
