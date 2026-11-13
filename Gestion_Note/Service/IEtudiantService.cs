using Gestion_Note.Dto;

namespace Gestion_Note.Service;

internal interface IEtudiantService
{
    bool AddEtudiant(EtudiantSaisiDto etudiantSaisiDto);
}