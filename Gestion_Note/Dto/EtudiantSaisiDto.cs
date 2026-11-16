namespace Gestion_Note.Dto;

public record  EtudiantSaisiDto
{
    public required string NomComplet
    {
        get; init
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Le nom est obligatoire.");
            }
            field = value;
        }
    }

    public required string DateNaissance
    {
        get; init
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("La date de Naissance est obligatoire");
            }
            if(!DateOnly.TryParseExact(value,"dd/MM/yyyy",out _))
            {
                throw new ArgumentException("Le format de la Date incorrect , format : dd/MM/yyyy");
            }
            field = value;
        }
    }
}

