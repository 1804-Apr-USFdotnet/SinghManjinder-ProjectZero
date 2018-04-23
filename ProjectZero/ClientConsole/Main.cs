using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectZero.Libraries;

namespace ProjectZero.Client
{
    class Console
    {
        static void Main(string[] args)
        {
            Console console = new Console();
            console.Run();
        }

        void Run()
        {
            System.Console.WriteLine("Welcome to Reviews! Select an item from the menu:");
            int input = 0;
            Libraries.Classes.ConsoleIO io = new Libraries.Classes.ConsoleIO();
            while (input != 9)
            {
                System.Console.WriteLine("Select an item from the menu:");
                System.Console.WriteLine(io.MenuOptions());
                input = Convert.ToInt32(System.Console.ReadLine()); // Convert the input from string to an integer
                io.Result(input);
            }

        }

        void Quit()
        {
            System.Console.WriteLine("Thank you for using Reviews, we hope to see you again in the future.");
        }
    }
}
