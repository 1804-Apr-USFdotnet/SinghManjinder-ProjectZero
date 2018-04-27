using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProjectZero.Libraries.Classes;
using System.Xml.Serialization;

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
            Functionality func = new Functionality();
            while (input != 9)
            {
                ////Libraries.Classes.DataHandler  dh = new Libraries.Classes.DataHandler();
                //XmlSerializer serializer = new XmlSerializer(typeof(List<Restaurant>));

                //DataHandler dh = new DataHandler();
                //List<Restaurant> restaurants = dh.Read();

                ////List<Restaurant> restaurants = new List<Restaurant>();
                //var rw = new List<Review>();
                //rw.Add(new Review(0, "Singh", 3));
                //rw.Add(new Review(1, "Ott", 2));
                //rw.Add(new Review(2, "Ash", 4));
                //var r = new Restaurant(0, "WendY", "123 W Main St",  "Tampa", "FL", 12345, rw);
                //restaurants.Add(r);
                //r = new Restaurant(1, "BurgerKing", "122 W Main St", "Tampa", "FL", 12345, rw);
                //restaurants.Add(r);
                //TextWriter writer = new StreamWriter("data.xml");

                //serializer.Serialize(writer, restaurants);
                //writer.Close();

                //restaurants[0].SortReviews("descending");

                System.Console.WriteLine("Select an item from the menu:");
                System.Console.WriteLine(io.MenuOptions());
                input = Convert.ToInt32(System.Console.ReadLine()); // Convert the input from string to an integer
                while (input != 9)
                {
                    if (input == 1)
                    {
                        System.Console.WriteLine("Enter the name of the restaurant:");
                        string ins = System.Console.ReadLine();
                        var result = io.Search(ins);
                        System.Console.WriteLine(result[0].ToString());
                    }
                    else if (input == 2)
                    {
                        // Sort the Reviews
                    }
                }

                if (input == 9)
                {
                    Quit();
                }
            }
        }

        void Quit()
        {
            System.Console.WriteLine("Thank you for using Reviews, we hope to see you again in the future.");
        }
    }
}
