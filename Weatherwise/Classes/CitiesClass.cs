using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Weatherwise.Classes
{
    public static class CitiesClass
    {
        public static string PathToCitiesData { get; }
        public static string CurrentCityName { get; set; }
        public static List<string> CitiesNames { get => citiesNames; }
        static List<string> citiesNames;
        static CitiesClass()
        {
            string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var path = Path.GetDirectoryName(location);
            PathToCitiesData = path.Substring(0, path.Length - 9) + "Data\\AddedCities.txt";
            CurrentCityName = File.ReadAllLines(PathToCitiesData)[0];

        }
        public static void GetCitiesNamesFromFile()
        {
            string[] lines = File.ReadAllLines(PathToCitiesData);
            citiesNames = lines.ToList();
        }
        public static void AddCityToFile(string city)
        {
            var lines = File.ReadAllLines(PathToCitiesData).ToList();
            lines.Add(city);
            
            File.WriteAllLines(PathToCitiesData, lines);
            citiesNames.Add(city);
        }
        public static List<string> GetFullListOfCities()
        {
            string location = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var path = Path.GetDirectoryName(location);
            string pathToFullCitiesList = path.Substring(0, path.Length - 9) + "Data\\Cities.txt";

            string[] list = File.ReadAllLines(pathToFullCitiesList);
            return list.ToList();
        }
        public static void RemoveCity(string city)
        {
            var lines = File.ReadAllLines(PathToCitiesData).ToList();
            lines.Remove(city);
            File.WriteAllLines(PathToCitiesData, lines);

            if (city==CurrentCityName)
            {
                CurrentCityName = lines[0];
            }
            CitiesNames.Remove(city);

            
        }

    }
}
