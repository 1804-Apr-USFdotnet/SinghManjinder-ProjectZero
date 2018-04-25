﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using ProjectZero.Libraries.Interfaces;
using System.Configuration;
using NLog;

namespace ProjectZero.Libraries.Classes
{
    public class DataHandler : IDataHandler
    {
        XmlSerializer serializer;
        ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;
        string source;
        private Logger logger = LogManager.GetCurrentClassLogger();

        public List<Restaurant> Read()
        {
            List<Restaurant> restaurants = new List<Restaurant>();
            source = settings[0].ConnectionString;
            
            TextReader reader;
            try
            {
                reader = new StreamReader(source); // Create a Reader

                serializer = new XmlSerializer(typeof(List<Restaurant>));
                restaurants = (List<Restaurant>) serializer.Deserialize(reader); // Deserialize and store the list

                // Close the Reader
                reader.Close();
            }
            catch (FileNotFoundException fe)
            {
                // File not found
                logger.Error(fe.Message);
            }
            catch (Exception ex)
            {
                // Handle general exception
                logger.Error(ex.Message);
            }

            return restaurants;
        }

        public void Write(List<Restaurant> restaurants)
        {
            source = settings[0].ConnectionString;
            // Create a Writer
            TextWriter writer;

            try
            {
                writer = new StreamWriter(source);

                serializer = new XmlSerializer(typeof(List<Restaurant>));

                serializer.Serialize(writer, restaurants);
                writer.Close();
            }
            catch (FileNotFoundException fe)
            {
                // File not found
                logger.Error(fe.Message);
            }
            catch (Exception ex)
            {
                // Handle general exception
                logger.Error(ex.Message);
            }
        }
    }
}
