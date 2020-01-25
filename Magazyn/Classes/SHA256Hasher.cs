using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Magazyn
{
    class SHA256Hasher
    {
        public String GenerateHash(string salt, string password)
        {
            byte[] saltedPassword = Encoding.UTF8.GetBytes(salt + password);
            SHA256Managed sha256hash = new SHA256Managed();
            byte[] hash = sha256hash.ComputeHash(saltedPassword);
            return BitConverter.ToString(hash).Replace("-", string.Empty);
        }
    }
}
