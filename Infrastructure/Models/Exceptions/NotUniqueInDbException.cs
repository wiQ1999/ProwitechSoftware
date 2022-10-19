using Infrastructure.Models.Enums;

namespace Infrastructure.Models.Exceptions;

public class NotUniqueInDbException : Exception
{
    public NotUniqueInDbException(string message) : base(message)
    { }

    public NotUniqueInDbException(AppSource source, Guid id)
		: base($"Rekord o identyfikatorze {id} dla zasobów {source} nie jest unikatowy")
	{ }

    public NotUniqueInDbException(AppSource source, string propertyName, string repeatingValue)
        : base($"Właściwość \"{propertyName}\" o wartości \"{repeatingValue}\" dla zasobu {source} nie jest unikatowa")
    { }

    public NotUniqueInDbException(AppSource source, Guid id, string propertyName, string repeatingValue)
        : base($"Właściwość \"{propertyName}\" o wartości \"{repeatingValue}\" rekordu o identyfikatorze {id} dla zasobu {source} nie jest unikatowa")
    { }
}
