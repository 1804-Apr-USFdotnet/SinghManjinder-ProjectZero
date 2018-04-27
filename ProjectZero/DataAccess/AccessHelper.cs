using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectZero.Libraries.Classes;
using PLC = ProjectZero.Libraries.Classes;

namespace DataAccess
{
    public class AccessHelper
    {
        private RestaurantDBEntities db;

        public List<Restaurant> GetAllRestaurants()
        {
            List<Restaurant> restaurants;
            using (db = new RestaurantDBEntities())
            {
                restaurants = db.Restaurants.ToList();
            }

            return restaurants;
        }

        public void AddRestaurant(PLC.Restaurant restaurant)
        {
            using (db = new RestaurantDBEntities())
            {
                db.Restaurants.Add(LibraryToData(restaurant));
                db.SaveChanges();
            }
        }

        public Restaurant LibraryToData(PLC.Restaurant restaurant)
        {
            Restaurant rest = new Restaurant()
            {
                Name = restaurant.Name,
                Address = restaurant.Address,
                City = restaurant.City,
                State = restaurant.State,
                ZipCode = restaurant.Zipcode,
                Rating = restaurant.Rating,
                Reviews = restaurant.ReviewsID
            };

            return rest;
        }

        public PLC.Restaurant DataToLibrary(Restaurant rest)
        {
            PLC.Restaurant r = new PLC.Restaurant()
            {
                RestaurantID = rest.RestaurantID,
                Name = rest.Name,
                Address = rest.Address,
                City = rest.City,
                State = rest.State,
                Zipcode = rest.ZipCode,
                Rating = (double)rest.Rating,
                ReviewsID = (int)rest.Reviews
            };

            return r;
        }
    }
}
