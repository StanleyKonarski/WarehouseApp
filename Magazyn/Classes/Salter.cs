using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Magazyn.Classes;

namespace Magazyn
{
    class Salter
    {
        
        public String GenerateSalt()
        {
            int length = 32;
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] randomBytes = new byte[length];
            rng.GetBytes(randomBytes);
            return BitConverter.ToString(randomBytes).Replace("-",string.Empty);
        }
    }
}
