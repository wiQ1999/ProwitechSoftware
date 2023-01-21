using Infrastructure.Helpers;
using Infrastructure.Models.Enums;

namespace Infrastructure.Models.Exceptions;

public class NotUniqueInDbException : Exception
{
    public NotUniqueInDbException(string message) : base(message)
    { }

    public NotUniqueInDbException(AppSource source, Guid id)
        : base($"W zasobach \"{source.GetDescription()}\" istnieje już rekord o identyfikatorze {id}.")
	{ }

    public NotUniqueInDbException(AppSource source, string value)
        : base($"W zasobach \"{source.GetDescription()}\" istnieje już rekord zawierający wartość \"{value}\".")
    { }

    public NotUniqueInDbException(AppSource source, string value, string propertyName)
        : base($"W zasobach \"{source.GetDescription()}\" istnieje już rekord zawierający wartość \"{value}\" dla właściwości \"{propertyName}\".")
    { }
}
