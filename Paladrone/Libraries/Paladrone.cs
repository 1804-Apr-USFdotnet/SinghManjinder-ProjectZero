using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libraries
{
    public class Paladrone
    {
        private string str;

        public Paladrone()
        {
            str = ""; // empty string
        }

        public Paladrone(string s)
        {
            str = s;
        }

        public bool isPaladrone()
        {
            str.Replace(@"\s+", "");
            str.ToLower();

            for (int i = 0, j = str.Count() - 1; i <= j; i++, j--)
            {
                if (str[i] != str[j])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
