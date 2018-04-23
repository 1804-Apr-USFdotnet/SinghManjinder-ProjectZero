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
            Palindrome Palindrome = new Palindrome("never Odd, or Even.");
            Console.WriteLine(Palindrome.isPalindrome());
            Console.ReadKey();
        }
    }
}
