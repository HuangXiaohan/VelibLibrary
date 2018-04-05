using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsClient
{
    class VelibServiceCallbackSink : VelibServiceReference.IVelibServiceCallback
    {
        public void GottenBikeNum(string city, string station, string num)
        {
            Console.WriteLine("City : " + city);
            Console.WriteLine("Station : " + station);
            Console.WriteLine("Bike Number : " + num);
        }

        public void GottenFinished()
        {
            Console.WriteLine("Operation completed");
        }
    }
}
