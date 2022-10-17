using Infrastructure.Common.Helpers;
using Infrastructure.Models.Domain;
using Infrastructure.Models.Enums;

namespace Infrastructure.Models.Exceptions;
public class RequiredAllPermissionPropertiesException : Exception
{
	public RequiredAllPermissionPropertiesException(Permission permission)
		: base($"Wszystkie właściwości uprawnienia {permission.Id} dla zasobu {permission.Source.GetDescription()} nie są określone")
	{
	}

	public RequiredAllPermissionPropertiesException(string message)
		: base(message)
	{ }
}
