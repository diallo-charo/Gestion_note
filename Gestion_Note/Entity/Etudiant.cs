namespace Gestion_Note.Entity
{
    class Etudiant
    {
        public string matricule{get; set;}
        public string nom{get; set;}
        public string prenom{get; set;}
        public List<double> notes{get; set;}

        public Etudiant(string matricule, string nom, string prenom, List<double> notes)
        {
            this.matricule = matricule;
            this.nom = nom;
            this.prenom = prenom;
            this.notes = notes;
        }


    }
}