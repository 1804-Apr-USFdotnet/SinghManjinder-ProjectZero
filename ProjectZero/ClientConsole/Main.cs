using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ProjectZero.Libraries.Classes;
using DataAccess;
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

                if (input == 1)
                {
                    // Ask if to display in ascending or descending order
                    System.Console.WriteLine("Ascending or Descending order: (A/D)");
                    var order = System.Console.ReadLine();
                    while (order.ToUpper() != "A" && order.ToUpper() != "D")
                    {
                        System.Console.WriteLine("Please enter A or D");
                        order = System.Console.ReadLine();
                    }

                    List<Libraries.Classes.Restaurant> result = new List<Libraries.Classes.Restaurant>();
                    if (order.ToUpper() == "A")
                    {
                        result = io.GetAll("ascending");
                    }
                    else
                        result = io.GetAll("descending");

                    // Output the restaurants
                    int count = 1;
                    foreach (var rest in result)
                    {
                        System.Console.WriteLine(count + ".)\t" +rest.ToString());
                        count++;
                    }

                    System.Console.WriteLine("Select a Restaurant");
                    input = Convert.ToInt32(System.Console.ReadLine());
                    while (input > count || input < 1)
                    {
                        System.Console.WriteLine("Select a Restaurant:");
                        input = Convert.ToInt32(System.Console.ReadLine());
                    }

                    int restID = result[input - 1].RestaurantID;

                    // Display the review options
                    System.Console.WriteLine("Select an option:");
                    System.Console.WriteLine(io.RestaurantOptions());
                    input = Convert.ToInt32(System.Console.ReadLine());

                    if (input != 9)
                    {
                        while (input < 1 || input > 2)
                        {
                            System.Console.WriteLine(io.RestaurantOptions());
                            input = Convert.ToInt32(System.Console.ReadLine());
                            if (input == 9)
                                break;
                        }
                        List<Libraries.Classes.Review> reviews = new List<Libraries.Classes.Review>();
                        if (input != 9)
                            reviews = io.AllReviews(restID, input);
                        else
                            break;

                        // Output all of the reviews
                        foreach (var review in reviews)
                        {
                            System.Console.WriteLine(review.ToString());
                        }
                    }

                }
                else if (input == 2)
                {
                    // Sort the Reviews
                    //AccessHelper ah = new AccessHelper();
                    //ah.UpdateAverageRating();

                    System.Console.WriteLine(func.PrintTopThreeRestaurants());
                }
                else if (input == 3)
                {
                    //AccessHelper ah = new AccessHelper();
                    //var rests = ah.GetAllRestaurants();
                    //var rests = func.AllRestaurants();
                    //int count = 1;
                    //foreach (var r in rests)
                    //{
                    //    System.Console.WriteLine(count + ".)\t" + r.ToString());
                    //    count++;
                    //}
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
