using ProjectZero.Libraries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZero.Libraries.Classes
{
    public class Review : IReview
    {
        private int _id; // ID of the review
        private decimal _rating; // Rating

        public int ID { get { return _id; } set { _id = value; } }
        public decimal Rating { get { return _rating; } set { _rating = value; } }
    }
}
