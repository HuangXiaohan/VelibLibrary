using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VelibClient.ServiceReference1;

namespace VelibClient
{
    class Program
    {
        static void Main(string[] args)
        {
            VelibServiceClient client = new VelibServiceClient();
            string help = "This application is for searching the velib information of each city. "
                + "\nInput the name of a city you'll get all the stations of this city"
                + "\nInput the name of a station in this city you'll get the number of available bikes of this station";

            do
            {
                Console.WriteLine(help);
            } while (String.Compare(Console.ReadLine(), "help", true) == 0);

            string cities = client.getCities();
            Console.WriteLine("There are those contracts: " + cities);
 
            Console.WriteLine("\n\nInput the city:");
            string city = Console.ReadLine();
            string stationResponse = client.SearchStations(city);
            if (stationResponse == "-1")
            {
                Console.WriteLine("No such city.");
            }
            else
            {
                Console.WriteLine(stationResponse.Length);
                Console.WriteLine("The stations of " + city + " are: " + stationResponse);
            }

            Console.WriteLine("Input the station: ");
            string station = Console.ReadLine();
            string bikeResponse = client.SearchBikeNum(city, station);
            if (bikeResponse == "-1")
            {
                Console.WriteLine("No such station.");
            }
            else
            {
                Console.WriteLine("The number of available bike is: " + bikeResponse);
            }
            Console.ReadLine();
            
        }
    }
}
