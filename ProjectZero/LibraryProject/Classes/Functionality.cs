using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using ProjectZero.Libraries.Interfaces;

namespace ProjectZero.Libraries.Classes
{
    public class Functionality : IFunctionality
    {
        private List<Restaurant> restaurants;
        private DataHandler DataHandler;
        private Logger logger = LogManager.GetCurrentClassLogger();

        public Functionality()
        {
            DataHandler = new DataHandler();
            restaurants = DataHandler.Read();
        }

        public List<Restaurant> AllRestaurants(string order = "")
        {
            if (order != "")
            {
                order.ToLower();
                if (order.Contains("ascen"))
                    restaurants.Sort();
                else
                    restaurants = restaurants.OrderByDescending(x => x.Rating).ToList(); // In descending order based on average rating
                return restaurants;
            }
            return restaurants;
        }

        public Restaurant GetRestaurant(string restaurantName)
        {
            return SearchRestaurantsByName(restaurantName)[0];
        }

        public string RestaurantDetails(string restaurantName)
        {
            // Grab the restaurant
            var rest = SearchRestaurantsByName(restaurantName)[0];

            
            return rest.ToString();
        }

        public List<Restaurant> SearchRestaurantsByName(string searchString)
        {
            List<Restaurant> r = new List<Restaurant>();
            foreach (var restaurant in restaurants)
            {
                if (restaurant.Name.Contains(searchString))
                {
                    r.Add(restaurant);
                }
            }
            return r;
        }

        public List<Restaurant> TopThreeRestaurants()
        {
            List<Restaurant> r = new List<Restaurant>();
            restaurants.Sort();
            for (int i = 0; i < 3; i++)
            {
                r.Add(restaurants[i]);
            }
            return r;
        }
    }
}
