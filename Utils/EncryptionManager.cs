using System;
using System.Linq;
using System.Security.Cryptography;

namespace MoviesOnDemand.Utils
{
    public static class EncryptionManager
    {
        public static string GetHashedPassword(string password)
        {
            string hashedPassword;
            // TODO: implement password encryption
            //hashedPassword = GenerateSaltedHash()

            // TODO: Remove below line once encryption is implemented
            hashedPassword = password;

            return hashedPassword;
        }

        static string GenerateSaltedHash(byte[] plainText, byte[] salt)
        {
            HashAlgorithm algorithm = new SHA256Managed();

            byte[] plainTextWithSaltBytes =
              new byte[plainText.Length + salt.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainText[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[plainText.Length + i] = salt[i];
            }

            return Convert.ToBase64String(algorithm.ComputeHash(plainTextWithSaltBytes));
        }

        public static bool CompareByteArrays(byte[] array1, byte[] array2)
        {
            return array1.Length == array2.Length && !array1.Where((t, i) => t != array2[i]).Any();
        }
    }
}