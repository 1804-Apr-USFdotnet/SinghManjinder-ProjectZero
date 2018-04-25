using ProjectZero.Libraries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace ProjectZero.Libraries.Classes
{
    public class Restaurant : IRestaurants, IComparable<Restaurant>
    {
        private string _name;
        private string _address;
        private string _city;
        private string _state;
        private int _zipcode;
        private int _id;
        private Decimal _rating;
        private List<Review> _reviews;
        private Logger logger = LogManager.GetCurrentClassLogger();

        public string Name { get { return _name; } set { _name = value; } }

        public string Address { get { return _address; } set { _address = value; } }

        public string City { get { return _city; } set { _city = value; } }

        public string State { get { return _state; } set { _state = value; } }

        public int Zipcode { get { return _zipcode; } set { _zipcode = value; } }

        public int RestaurantID { get { return _id; } set { _id = value; } }

        public Decimal Rating { get { return _rating; } set { _rating = value; } }
        
        public List<Review> Reviews { get { return _reviews; } set { _reviews = value; } }

        public Restaurant()
        {
            _name = "";
            _address = "";
            _city = "";
            _state = "";
            _zipcode = 00000;
            _id = 0;
            _reviews = new List<Review>();
            _rating = ComputeRating();
        }

        public Restaurant(int id, string name, string address, string city, string state, int zip, List<Review> reviews)
        {
            _id = id;
            _name = name;
            _address = address;
            _city = city;
            _state = state;
            _zipcode = zip;

            if (reviews != null)
            {
                _reviews = reviews;
            }
            else
                _reviews = new List<Review>();

            _rating = ComputeRating();
        }

        // Sort the Restaurants reviews in either Ascending or Descending Order using the Ratings
        public void SortReviews(string criteria)
        {
            if (criteria.ToLower() == "ascending")
            {
                _reviews.Sort();
            }
            else
            {
                _reviews.Sort((a, b) => -1 * (a.CompareTo(b))); // Sort in descending order
            }
        }

        // This method will compute the overall rating for the Restaurant based on all of the reviews
        public decimal ComputeRating()
        {
            decimal rating = 0.0m;

            // Iterate through the reviews to grab each of the ratings
            foreach (var review in _reviews)
            {
                rating += review.Rating; // Add all of the ratings together
            }

            try
            {
                rating = rating / _reviews.Count();
            }
            catch (DivideByZeroException de)
            {
                logger.Error(de.Message);
            }

            return rating;
        }

        // This method is call by the Sort() method to sort the List<Restaurants> in Ascending Order
        public int CompareTo(Restaurant other)
        {
            if (other == null)
                return 1; // this object is greater as the other object isn't instantiated
            else
                return Rating.CompareTo(other.Rating); // Returns the greater one
        }
    }
}
