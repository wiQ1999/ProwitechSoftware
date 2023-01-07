namespace Infrastructure.Models.Exceptions;

public class PermissionCountException : Exception
{
	public PermissionCountException()
		: base("Ilość uprawnień niezgadza się z dostępnymi zasobami")
	{ }

	public PermissionCountException(string message)
		: base(message)
	{ }
}
