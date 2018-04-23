using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZero.Libraries.Interfaces
{
    interface IReview
    {
        int ID { get; set; }
        decimal Rating { get; set; }
    }
}
