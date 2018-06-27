using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

/// <summary>
/// Klasa PasswordHash služi kriptiranju lozinki prema RFC2898 standardu
/// Lozinka se hešira 10000 puta (po defaultu) PBKDF2 algoritnom uz HMAC-SHA1
/// Osim samog heširanja lozinke, u klasi se nalaze metode za generiranje salta
/// proizvoljne duljine i verificiranje lozinke
/// </summary>

namespace RashoApp
{
    class PasswordHash
    {
        private const int passwordHashLength = 20;
        private const int numberOfIterations = 10000;
        private const int saltLength = 16;

        public PasswordHash()
        {
            
        }
        public string Hash(string password, byte[] salt)
        {
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, numberOfIterations);
            byte[] passwordHash = pbkdf2.GetBytes(passwordHashLength);

            byte[] hashBytes = new byte[passwordHashLength+saltLength];
            Array.Copy(salt, 0, hashBytes, 0, saltLength);
            Array.Copy(passwordHash, 0, hashBytes, saltLength, passwordHashLength);

            return Convert.ToBase64String(hashBytes);
        }
        public bool Verify(string enteredPassword, string savedPasswordHash)
        {
            byte[] hashBytes = Convert.FromBase64String(savedPasswordHash);

            byte[] salt = new byte[saltLength];
            Array.Copy(hashBytes, 0, salt, 0, saltLength);

            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, salt, numberOfIterations);
            byte[] hash = pbkdf2.GetBytes(passwordHashLength);

            for (int i = 0; i < passwordHashLength; i++)
                if (hashBytes[i + saltLength] != hash[i])
                    return false;
            return true;
        }
        public byte[] GenerateSalt(int length=saltLength)
        {
            byte[] salt = new byte[length];
            RNGCryptoServiceProvider rngCSP = new RNGCryptoServiceProvider();
            rngCSP.GetBytes(salt);
            return salt;
        }
    }
}
