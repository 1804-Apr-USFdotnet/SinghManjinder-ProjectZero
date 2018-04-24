using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZero.Libraries.Interfaces
{
    interface IRestaurants
    {
        int ID { get; set; }
        string Name { get; set; }       // The name of the restaurant
        string Address { get; set; }    // The address of the restaurant
        Decimal Rating { get; set; }    // The average rating of the restaurant

        void SortReviews(string criteria);    // Sort through the reviews using the criteria
        Decimal ComputeRating();        // Compute the average rating from the reviews

    }
}
