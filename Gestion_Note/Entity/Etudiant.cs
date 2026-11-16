namespace Gestion_Note.Entity;
public class Etudiant(string matricule, string nomComplet, DateOnly dateNaiss)
{
    public string Matricule{get; set;} = matricule;
    public string NomComplet{get; set;} = nomComplet;
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