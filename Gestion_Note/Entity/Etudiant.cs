namespace Gestion_Note.Entity;
class Etudiant(string matricule, string nom, string prenom, DateOnly dateNaiss)
{
    public string Matricule{get; set;} = matricule;
    public string Nom{get; set;} = nom;
    public string Prenom{get; set;} = prenom;
    public DateOnly DateNaiss {get;set;} = dateNaiss;
    public int Age
    {
        get
        {
            var dateNow  = DateOnly.FromDateTime(DateTime.Today);
            var age = dateNow.Year - DateNaiss.Year;
            return age;
        }
    } 
    public List<Note> notes{get;} = [];

    public void addNote(Note note)
    {
        notes.Add(note);
    }




}