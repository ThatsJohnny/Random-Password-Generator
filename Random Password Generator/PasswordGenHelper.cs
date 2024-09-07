using System;
using System.Collections.Generic;
using System.Linq;

namespace Random_Password_Generator
{
    public enum CharType
    {
        LowerCase,
        Uppercase,
        Digits,
        Symbols
    }

    public class PasswordGenHelper
    {
        public static string GeneratePassword(GenerateConfig generateConfig)
        {
            string generatedPassword = string.Empty;

            List<char> characters = new List<char>();

            if (generateConfig.IsLowerCase)
                characters.AddRange(GetCharacters(CharType.LowerCase));

            if (generateConfig.IsUppercase)
                characters.AddRange(GetCharacters(CharType.Uppercase));

            if (generateConfig.IsDigits)
                characters.AddRange(GetCharacters(CharType.Digits));

            if (generateConfig.IsSymbols)
                characters.AddRange(GetCharacters(CharType.Symbols));

            Random random = new Random(); // Random.cs - 100% Random

            List<char> selectedChars = Enumerable.Range(0, generateConfig.Length).Select(c => characters[random.Next(characters.Count)]).ToList();

            generatedPassword = string.Join("", selectedChars);
            return generatedPassword;
        }

        public static List<char> GetCharacters(CharType charType)
        {
            if (charType == CharType.LowerCase) {
                return Enumerable.Range('a', 'z' - 'a' + 1).Select(i => (char)i).ToList();
            }
            if (charType == CharType.Uppercase)
            {
                return Enumerable.Range('A', 'Z' - 'A' + 1).Select(i => (char)i).ToList();
            }
            if (charType == CharType.Digits)
            {
                return Enumerable.Range('0', '9' - '0' + 1).Select(i => (char)i).ToList();
            }

            return "!@#$%^&*()_+=-{}[]\\|;:'\"<>,.?/~`".Where(c => char.IsSymbol(c)).ToList();
        }
    }
}