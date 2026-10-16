using System.Security.Cryptography;

namespace FitZoneGym.Data
{
    /// <summary>PBKDF2 password hashing. Passwords are never stored in plain text.</summary>
    public static class Security
    {
        public static string NewSalt() => Convert.ToBase64String(RandomNumberGenerator.GetBytes(16));

        public static string Hash(string password, string saltBase64)
        {
            byte[] salt = Convert.FromBase64String(saltBase64);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(password, salt, 100_000, HashAlgorithmName.SHA256, 32);
            return Convert.ToBase64String(hash);
        }

        public static bool Verify(string password, string saltBase64, string expectedHash)
        {
            byte[] a = Convert.FromBase64String(Hash(password, saltBase64));
            byte[] b = Convert.FromBase64String(expectedHash);
            return CryptographicOperations.FixedTimeEquals(a, b);
        }
    }
}
