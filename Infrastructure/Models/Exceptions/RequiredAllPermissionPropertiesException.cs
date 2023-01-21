using Infrastructure.Helpers;
using Infrastructure.Models.Domain;

namespace Infrastructure.Models.Exceptions;

public class RequiredAllPermissionPropertiesException : Exception
{
	public RequiredAllPermissionPropertiesException(string message)
		: base(message)
	{ }

    public RequiredAllPermissionPropertiesException(Permission permission)
        : base($"Nie wszystkie właściwości uprawnienia o identyfikatorze \"{permission.Id}\" dla zasobu {permission.Source.GetDescription()} są określone.")
    { }
}
