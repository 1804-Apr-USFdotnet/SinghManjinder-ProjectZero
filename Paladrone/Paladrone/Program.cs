using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libraries;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Paladrone paladrone = new Paladrone("racecar");
            Console.WriteLine(paladrone.isPaladrone());

        }
    }
}
