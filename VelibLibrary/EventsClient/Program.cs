using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EventsClient
{
    class Program
    {
        static void Main(string[] args)
        {
            VelibServiceCallbackSink objsink = new VelibServiceCallbackSink();
            InstanceContext iCntxt = new InstanceContext(objsink);

            VelibServiceReference.VelibServiceClient objClient = new VelibServiceReference.VelibServiceClient(iCntxt);
            objClient.SubscribeGottrnBikeNumEvent();
            objClient.SubscribeGottenFinishedEvent();

            String city1 = "Toulouse", station1 = "POMME";
            objClient.GetBikeNum (city1, station1);

            Console.WriteLine("Press any key to close ...");
            Console.ReadKey();
        }
    }
}
