namespace Gestion_Note.Service;

public class MatriculeService : IMatriculeService
{
    public string GenerateMatricule(int compteur) => $"ISM00{compteur}";
}