namespace Part2_ObjectOrientedProgramming.Models;

public static class PasswordValidator
{
    /*
     *  Password rules:
     *  - Must be between 6 and 13 characters long
     *  - Must contain at least one uppercase letter
     *  - Must contain at least one lowercase letter
     *  - Must contain at least one digit
     *  - Cannot contain capital T or & symbols
     */

    private const int MinLength = 6;
    private const int MaxLength = 13;
    private const char ForbiddenCharT = 'T';
    private const char ForbiddenCharAmp = '&';

    public static bool IsValid(string password)
    {
        // Check length
        if (password.Length < MinLength || password.Length > MaxLength) return false;

        // Check for forbidden characters
        if (password.Contains(ForbiddenCharT) || password.Contains(ForbiddenCharAmp)) return false;

        // Check for uppercase, lowercase, and digit
        bool hasUpper = false;
        bool hasLower = false;
        bool hasDigit = false;

        foreach (char c in password)
        {
            if (char.IsUpper(c)) hasUpper = true;
            else if (char.IsLower(c)) hasLower = true;
            else if (char.IsDigit(c)) hasDigit = true;

            // Early exit if all conditions are met
            if (hasUpper && hasLower && hasDigit) break;
        }

        return hasUpper && hasLower && hasDigit;
    }
}