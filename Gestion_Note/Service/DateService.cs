namespace Gestion_Note.Service;

public class DateService : IDateService
{
    public DateService(){}
    public DateOnly StringToDate(string dateString,string format = "dd/MM/yyyy" )
    {
        DateOnly date;
        bool result = DateOnly.TryParseExact(dateString, format, out date);
        return date;
    }
}