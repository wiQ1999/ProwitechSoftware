using Infrastructure.Helpers;
using Infrastructure.Models.Enums;

namespace Infrastructure.Models.Exceptions;

public class InvalidLengthException : Exception
{
	public InvalidLengthException(AppSource source, string propertyName, int maximuLength) 
		: base($"Właściwość \"{propertyName}\" w zasobie \"{source.GetDescription()}\" zezwala na wprowadzenie tekstu o maksymalnej długości {maximuLength} znaków.") 
	{ }
}
