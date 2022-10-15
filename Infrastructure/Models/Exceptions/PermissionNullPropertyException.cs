using Infrastructure.Models.Enums;

namespace Infrastructure.Models.Exceptions;
public class PermissionNullPropertyException : Exception
{
	public PermissionNullPropertyException(AppSource source)
		: base($"Zasób {source} nie może posiadać nieokreślonych uprawnień")
	{ }

	public PermissionNullPropertyException(string message)
		: base(message)
	{ }
}
