using Infrastructure.Common.Helpers;
using Infrastructure.Models.Enums;

namespace Infrastructure.Models.Exceptions;

public class RequiredValueException : Exception
{
	public RequiredValueException(AppSource source, string propertyName) 
		: base($"Właściwość \"{propertyName}\" w zasobach \"{source.GetDescription()}\" jest wymagana.")
	{ }
}
