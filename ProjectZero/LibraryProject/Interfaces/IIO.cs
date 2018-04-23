using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZero.Libraries.Interfaces
{
    interface IIO
    {
        string MenuOptions();
        string Result(int input);
        int ReadInput();
    }
}
