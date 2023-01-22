using System.ComponentModel;
using System.Reflection;

namespace Infrastructure.Helpers;

public static class EnumExtension
{
    public static string GetDescription(this Enum value)
    {
        FieldInfo fi = value.GetType().GetField(value.ToString())!;
        DescriptionAttribute[]? attributes = fi.GetCustomAttributes(
            typeof(DescriptionAttribute), false) as DescriptionAttribute[];

        if (attributes != null && attributes.Any())
            return attributes.First().Description;

        return value.ToString();
    }

    public static T GetEnumFromDescription<T>(this string description)
        where T : Enum
    {
        foreach (Enum enumValue in Enum.GetValues(typeof(T)))
        {
            if (enumValue.GetDescription() == description)
                return (T)enumValue;
        }
        throw new ArgumentException($"Nie znaleziono wartości {description}");
    }

    public static string SwapToJsonProperty(this Enum value)
    {
        string enumText = value.ToString();

        char firstChar = char.ToLower(enumText[0]);

        if (enumText.Length < 2)
            return firstChar.ToString();

        string result = firstChar + enumText.Substring(1);

        return result;
    }
}
