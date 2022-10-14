namespace Infrastructure.Models.Exceptions;
public class NotFoundInDbExcption : Exception
{
    public NotFoundInDbExcption(string source, string identifier)
        : base($"Nie znaleziono obiektu '{source}' dla identyfikaotra '{identifier}'.")
    { }
}
