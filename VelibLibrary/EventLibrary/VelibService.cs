using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EventLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class VelibService : IVelibService
    {
        static Action<string, string, string> m_Event1 = delegate { };

        static Action m_Event2 = delegate { };

        public void GetBikeNum(string city, string station)
        {
            string bikeNum = "-1";
            string str = "https://api.jcdecaux.com/vls/v1/stations/?contract=" + city + "&apiKey=a326de14efef37ca365b64ee6b061b12437fb07d";
            WebRequest request;

            /*StationProp stationCurrent = new StationProp();
            foreach (var item in cache[city])
            {
                if (item.Key.Contains(station))
                {
                    stationCurrent = item.Value;
                    Debug.WriteLine(stationCurrent.getBikeNum());
                    Debug.WriteLine(stationCurrent.getTimeUpdate());
                }

            }*/


            // if the property of the station has not been set or the update time has passed more than 5 min
            //if (stationCurrent.getBikeNum() == -1 || stationCurrent.getTimeUpdate().AddMinutes(5).CompareTo(DateTime.Now) < 0)
            //{
                try
                {
                    request = WebRequest.Create(str);
                    //Get the response.
                    WebResponse response = request.GetResponse();
                    // Get the stream containing content returned by the server.
                    Stream dataStream = response.GetResponseStream();
                    // Open the stream using a StreamReader for easy access.
                    StreamReader reader = new StreamReader(dataStream);
                    // Read the content.
                    string responseFromServer = reader.ReadToEnd();

                    JArray jarray = JArray.Parse(responseFromServer);
                    foreach (JObject item in jarray)
                    {
                        string name = (string)item.GetValue("name");
                        if (name.Contains(station))
                        {
                            bikeNum = (string)item.GetValue("available_bikes");
                            //stationCurrent.setBikeNum(Convert.ToInt32(bikeNum));
                            //stationCurrent.setTimeUpdate(DateTime.Now);
                        }
                    }
                }
                catch (WebException webEx)
                {
                    bikeNum = "-1";
                }
            //}
            //else
            // {
            //     bikeNum = stationCurrent.getBikeNum().ToString();
            //bikeNum += "cahce";
            //}

            m_Event1(city, station, bikeNum);
            m_Event2();

        }

        public void SubscribeGottenFinishedEvent()
        {
            IVelibServiceEvents subscriber =
            OperationContext.Current.GetCallbackChannel<IVelibServiceEvents>();
            m_Event2 += subscriber.GottenFinished;
        }

        public void SubscribeGottrnBikeNumEvent()
        {
            IVelibServiceEvents subscriber =
            OperationContext.Current.GetCallbackChannel<IVelibServiceEvents>();
            m_Event1 += subscriber.GottenBikeNum;
        }
    }
}
