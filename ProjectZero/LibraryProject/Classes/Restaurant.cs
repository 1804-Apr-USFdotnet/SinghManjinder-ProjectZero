using ProjectZero.Libraries.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZero.Libraries.Classes
{
    public class Restaurant : IRestaurants
    {
        private string _name;
        private string _address;
        private int _id;
        //private List<Review> _reviews;

        public string Name { get { return _name; } set { _name = value; } }

        public string Address { get { return _address; } set { _address = value; } }

        public int ID { get { return _id; } set { _id = value; } }
    }
}
