using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;


namespace MVC_Application_2_.Helpers
{

    public class PasswordHelper
    {
        public static string HashPassword(string password)
        {
            byte[] salt = new byte[16];

            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            byte[] hash;

            using (var pbkdf2 = new Rfc2898DeriveBytes(
                password,
                salt,
                100000))
            {
                hash = pbkdf2.GetBytes(32);
            }

            return Convert.ToBase64String(salt)
                   + ":"
                   + Convert.ToBase64String(hash);
        }

        public static bool VerifyPassword(
            string password,
            string storedHash)
        {
            string[] parts = storedHash.Split(':');

            if (parts.Length != 2)
            {
                return false;
            }

            byte[] salt = Convert.FromBase64String(parts[0]);
            byte[] storedPasswordHash =
                Convert.FromBase64String(parts[1]);

            byte[] passwordHash;

            using (var pbkdf2 = new Rfc2898DeriveBytes(
                password,
                salt,
                100000))
            {
                passwordHash = pbkdf2.GetBytes(32);
            }

            return SlowEquals(
                storedPasswordHash,
                passwordHash);
        }

        private static bool SlowEquals(
            byte[] a,
            byte[] b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            int result = 0;

            for (int i = 0; i < a.Length; i++)
            {
                result |= a[i] ^ b[i];
            }

            return result == 0;
        }
    }
}