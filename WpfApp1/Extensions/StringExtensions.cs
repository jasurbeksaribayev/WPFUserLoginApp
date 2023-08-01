using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XSystem.Security.Cryptography;

namespace WpfApp1.Extensions
{
    public static class StringExtensions
    {
        public static string Encrypt(this string password)
        {
            var sha256 = new SHA256Managed();

            byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

            return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
        }
    }
}
