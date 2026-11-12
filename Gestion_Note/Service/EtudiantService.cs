using Gestion_Note.Entity;

namespace Gestion_Note.Service
{
    class EtudiantService
    {
        
        public static List<Etudiant> etudiants = new List<Etudiant>();

        public static void AjouterEtudiant(Etudiant etudiant)
            {
                etudiants.Add(etudiant);
            }

        public static Etudiant? GetEtudiantByMatricule(string matricule)
        {
            return etudiants.FirstOrDefault(e => e.matricule == matricule);
        }

        public static bool AddNote(double note, string matricule)
        {
            Etudiant? etudiant = GetEtudiantByMatricule(matricule);
            if (etudiant is null)
            {
                return false;
            }
            etudiant?.notes.Add(note);
            return true;
        }

    }
};
