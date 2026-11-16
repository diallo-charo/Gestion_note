namespace Gestion_Note.Service;

public interface IDateService
{
    DateOnly StringToDate(string dateString, string format);
}