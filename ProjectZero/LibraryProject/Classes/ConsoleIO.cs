using ProjectZero.Libraries.Interfaces;
using System;
using NLog;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectZero.Libraries.Classes
{
    public class ConsoleIO : IIO
    {

        public static Logger logger = LogManager.GetCurrentClassLogger();

        public string MenuOptions()
        {
            string options = "1 - Search for Restaurants    2 - Sort reveiws    9 - Quit";
            return options;
        }

        public int ReadInput()
        {
            throw new NotImplementedException();
        }

        public string Result(int input)
        {
            throw new NotImplementedException();
        }
    }
}
