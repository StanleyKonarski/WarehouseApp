using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn.Classes
{
    class GlobalSettings
    {

        public static uint UserID;
        public static string UserName;
        public static string Name;
        public static string Surname;
        public static byte Permission;
        public static string Hash;
        public static string Salt;
        public enum Position { Kierownik = 2, Magazynier = 1 };

        public static void RestoreDefaults()
        {
            UserID = 0;
            UserName = null;
            Name = null;
            Surname = null;
            Hash = null;
            Salt = null;
            Permission = 0;
        }
    }
}
