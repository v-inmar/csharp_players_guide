using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePoint
{
    static class PasswordValidator
    {
        public static bool IsPassowrdValid(string password) =>
            IsLengthValid(password) &&
            ContainUpperCase(password) &&
            ContainLowerCase(password) &&
            ContainNumber(password) &&
            !ContainCapitalT(password) &&
            !ContainAmpersand(password);




        public static bool IsLengthValid(string password) => password?.Length <= 13 && password?.Length >= 6;
        public static bool ContainNumber(string password)
        {
            foreach(char character in password)
            {

                if (char.IsDigit(character))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ContainUpperCase(string password)
        {
            foreach (char character in password)
            {

                if (char.IsUpper(character))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ContainLowerCase(string password)
        {
            foreach (char character in password)
            {

                if (char.IsLower(character))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ContainCapitalT(string password)
        {
            foreach (char character in password)
            {

                if (character == 'T')
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ContainAmpersand(string password)
        {
            foreach (char character in password)
            {

                if (character == '&')
                {
                    return true;
                }
            }
            return false;
        }
    }
}
