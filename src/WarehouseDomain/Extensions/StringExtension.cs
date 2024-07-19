using System.Text.RegularExpressions;

namespace WarehouseDomain.Extensions;
public static class StringExtension
{
    public static string SafeSubstring(this string input, int length)
    {
        if (length < 0)
            throw new ArgumentOutOfRangeException(nameof(length), "Substring length cannot be less than 0");

        if (string.IsNullOrEmpty(input) || input.Length <= length)
            return input;

        return input.Substring(0, length);
    }

    public static string GetCorrectPhoneNumber(this string phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber))
            throw new ArgumentException("Phone number cannot be null or empty", nameof(phoneNumber));

        phoneNumber = Regex.Replace(phoneNumber, @"[^\d]", "");

        return phoneNumber.Length switch
        {
            9 => $"998{phoneNumber}",
            12 when !phoneNumber.StartsWith("998") => throw new FormatException("Invalid phone number format."),
            12 => phoneNumber,
            _ => throw new FormatException("Invalid phone number length.")
        };
    }
}
