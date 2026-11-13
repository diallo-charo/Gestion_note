using Gestion_Note.Entity;
using Gestion_Note.Service;
using Gestion_Note.Views;

class Program
{
    static void Main(string[] args)
    {
        EtudiantService.AjouterEtudiant(new Etudiant("Doe", "John", new List<double> { 12.5, 15.0 }));
        EtudiantService.AjouterEtudiant(new Etudiant("Smith", "Jane", new List<double> { 14.0, 16.5 }));

        EtudiantView.MenuEtudiant();
    }
}