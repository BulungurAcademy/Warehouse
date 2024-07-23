using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace WH.Domain.Extensions
{
    public static class ValidationExtensions
    {
        public static T NotBeNull<T>([NotNull] this T? argument, System.Exception exception)
        {
            if (argument == null)
            {
                throw exception;
            }

            return argument;
        }
        public static string NotBeInvalidEmail(this string email, [CallerArgumentExpression("email")] string? argumentName = null)
        {
            var regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

            if (!regex.IsMatch(email))
                throw new ValidationException($"{argumentName} is not a valid email address.");

            return email;
        }
        public static string ValidPhoneNumber(this string phoneNumber)
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
}
