using System;
using System.Security.Cryptography;
using System.Text;

namespace Models
{
    public class MAccount
    {
        public string Usename { get; set; }
        public string Password { get; set; } 
        
        public string ComputeHash(string input, HashAlgorithm algorithm)
        {
            Byte[] inputBytes = Encoding.UTF8.GetBytes(input);

            Byte[] hashedBytes = algorithm.ComputeHash(inputBytes);

            return BitConverter.ToString(hashedBytes);
        }
    }
}
