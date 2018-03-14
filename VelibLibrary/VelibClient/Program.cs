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
            
            Console.WriteLine("Type in the city: ");
            string city = Console.ReadLine();
            Console.WriteLine("The stations of " + city + " are: " + client.searchStations(city));
            Console.WriteLine("Type in the station: ");
            string station = Console.ReadLine();
            Console.WriteLine("The number of available bike is: "+ client.searchBikeNum(city,station));
            Console.ReadLine();
        }
    }
}
