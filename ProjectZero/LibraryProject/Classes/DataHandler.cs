using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ProjectZero.Libraries.Interfaces;
using System.Configuration;

namespace ProjectZero.Libraries.Classes
{
    public class DataHandler : IDataHandler
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Restaurant>));
        string source = ConfigurationManager.AppSettings.Get("File");

        public List<Restaurant> Read()
        {
            throw new NotImplementedException();
        }

        public void Write(List<Restaurant> restaurants)
        {

            throw new NotImplementedException();
        }
    }
}
