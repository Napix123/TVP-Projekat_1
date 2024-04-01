using System;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;

namespace Dash.Utilities
{
    internal static class Encryption
    {
        private static SHA256 sha256 = SHA256.Create();

        public static string Encrypt(string ogString)
        {
            byte[] ogBytes = Encoding.UTF8.GetBytes(ogString);
            byte[] hashed = sha256.ComputeHash(ogBytes);
            return Convert.ToBase64String(hashed);
        }
    }
}
