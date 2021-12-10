using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_Bankomex
{
    public class Validation
    {
        public static bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        public static bool IsLettersOnly(string str)
        {
            if (str.Length == 0)
            {
                return false;
            }
            foreach (char c in str.ToLower())
            {
                if (c < 'a' || c > 'z')
                    return false;
            }
            return true;
        }
    }
}
