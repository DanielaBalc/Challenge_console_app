using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_CodeCrafters
{
    class Password
    {
        public static void GeneratePass()
        {
            string password = "";

            password = GenerateToken();

            Console.WriteLine("Your password will be generated.... ");

            Console.WriteLine("Password: " + password);
        }

        public static string GenerateToken()
        {
            Random random = new Random();
            int length = random.Next(8, 16) - 4;
            using (RNGCryptoServiceProvider cryptRNG = new RNGCryptoServiceProvider())
            {
                byte[] tokenBuffer = new byte[length];
                cryptRNG.GetBytes(tokenBuffer);
                object token = Convert.ToBase64String(tokenBuffer);
                return token.ToString();
            }
        }

       
    }

}
