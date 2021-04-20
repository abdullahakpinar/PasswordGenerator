using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public static class PasswordGenerate
    {
        public static string CreateRandomPassword(PasswordGeneratorRequest request)
        {
            string validChars = string.Empty;
            string upperChars = "ABCDEFGHJKLMNOPQRSTUVWXYZ";
            string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            string numberChars = "0123456789";
            string specialChars = "!@#$%^&*?_-";
            if (request.IsUpperChars)
            {
                validChars = upperChars;
            }
            if (request.IsLowerChars)
            {
                validChars += lowerChars;
            }
            if (request.IsNumberChars)
            {
                validChars += numberChars;
            }
            if (request.IsSpecialChars)
            {
                validChars += specialChars;
            }
            if (!string.IsNullOrEmpty(request.AllowChars))
            {
                validChars += request.AllowChars;
            }
            if (!string.IsNullOrEmpty(request.DenyChars))
            {
                foreach (char itm in request.DenyChars)
                {
                    validChars = validChars.Remove(validChars.IndexOf(itm), 1);
                }
            }
            if (string.IsNullOrEmpty(validChars))
            {
                validChars = upperChars + lowerChars + numberChars + specialChars;
            }
            Random random = new Random();
            int size = random.Next(request.MinLength, request.MaxLength);
            char[] chars = new char[size];
            for (int i = 0; i < size; i++)
            {
                chars[i] = validChars[random.Next(0, validChars.Length)];
            }
            return new string(chars);
        }
    }
}
