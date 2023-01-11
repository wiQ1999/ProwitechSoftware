using Infrastructure.Common.Helpers;
using Infrastructure.Models.Enums;

namespace Infrastructure.Models.Exceptions;

public class NotFoundInDbExcption : Exception
{
    public NotFoundInDbExcption(AppSource source, Guid id)
        : base($"Nie znaleziono obiektu w zasobie \"{source.GetDescription()}\" dla identyfikaotra \"{id}\".")
    { }
}
