namespace Gestion_Note.Entity;

public class Note(string matiere, double valeur)
{
    public string Matiere{get;set;} = matiere;
    public double Valeur { get;set; } = valeur < 0 || valeur > 20 ? throw new ArgumentOutOfRangeException(nameof(valeur), "La note dois etre compris entre 0 et 20"): valeur;

    // public double Valeur
    // {
    //     get;
    //     set
    //     {
    //         if(value < 0 || value > 20)
    //         {
    //             throw new ArgumentOutOfRangeException(nameof(value), "La note dois etre compris entre 0 et 20");
    //         }
    //         field =  valeur; // pas de return 
    //     }
    // } 


}