using Gestion_Note.Dto;
using Gestion_Note.Entity;
using Gestion_Note.Repository;

namespace Gestion_Note.Service;

public class EtudiantService : IEtudiantService
{

    private  IEtudiantRepository _repository ;
    private IDateService _dateService;

    public EtudiantService(IEtudiantRepository repos,IDateService dateService)
    {
        _repository = repos;
        _dateService = dateService;
        
    }

    public bool AddEtudiant(EtudiantSaisiDto etudiantSaisiDto,IMatriculeService _matricule)
    {
        string nomComplet = etudiantSaisiDto.NomComplet;
        // convertir ta date Par son propre service => service interne
        var dateNaissance = _dateService.StringToDate(etudiantSaisiDto.DateNaissance,"dd/MM/yyyy");
        //generer le matricule Par son propre Service => service interne
        var matricule = _matricule.GenerateMatricule(_repository.Compteur); // si le Compteur n'est pas defini dans l'interface elle ne sera pas visible meme avec l'injection dans le constructeur
        
        Etudiant etudiant = new Etudiant(matricule,nomComplet,dateNaissance);
        _repository.Save(etudiant);
        return true;
    }
}