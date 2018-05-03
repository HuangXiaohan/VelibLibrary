using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VelibLibrary
{
    class VelibService : IVelibService
    {
        public const int DelayMilliseconds = 10000;

        public static Dictionary<string, Dictionary<string, StationProp>> cache = new Dictionary<string,Dictionary<string, StationProp>>();

        public string searchStations(string city)
        {
            string stationList = "";
            string str = "https://api.jcdecaux.com/vls/v1/stations/?contract=" + city + "&apiKey=a326de14efef37ca365b64ee6b061b12437fb07d";
            WebRequest request = WebRequest.Create(str);
            //Get the response.
            WebResponse response;

            if (!cache.ContainsKey(city))
            {
                try
                {
                    response = request.GetResponse();
                    // Get the stream containing content returned by the server.
                    Stream dataStream = response.GetResponseStream();
                    // Open the stream using a StreamReader for easy access.
                    StreamReader reader = new StreamReader(dataStream);
                    // Read the content.
                    string responseFromServer = reader.ReadToEnd();


                    JArray jarray = JArray.Parse(responseFromServer);

                    Dictionary<string, StationProp> stationDic = new Dictionary<string, StationProp>();
                    foreach (JObject item in jarray)
                    {
                        string station = (string)item.GetValue("name");
                        string stationName = station.Split('-')[1];
                        stationList = stationList + stationName + ",";
                        stationDic.Add(station, new StationProp());
                    }
                    cache.Add(city, stationDic);
                    
                }
                catch (WebException webEx)
                {
                    stationList = "-1";
                }
            }else
            {
                Dictionary<string, StationProp> dic = cache[city];
                foreach(var item in dic)
                {
                    stationList = stationList + item.Key.Split('-')[1]+",";
                }
            }

            return stationList;
            
        }

        public string searchBikeNum(string city, string station)
        {
            string bikeNum = "-1";
            string str = "https://api.jcdecaux.com/vls/v1/stations/?contract=" + city + "&apiKey=a326de14efef37ca365b64ee6b061b12437fb07d";
            WebRequest request;

            StationProp stationCurrent = new StationProp();
            foreach (var item in cache[city])
            {
                if (item.Key.Contains(station))
                {
                    stationCurrent = item.Value;
                    Debug.WriteLine(stationCurrent.getBikeNum());
                    Debug.WriteLine(stationCurrent.getTimeUpdate());
                }
                    
            }

            
            // if the property of the station has not been set or the update time has passed more than 5 min
            if (stationCurrent.getBikeNum() == -1 || stationCurrent.getTimeUpdate().AddMinutes(5).CompareTo(DateTime.Now) < 0)
            {
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
                            stationCurrent.setBikeNum(Convert.ToInt32(bikeNum));
                            stationCurrent.setTimeUpdate(DateTime.Now);
                        }
                    }
                }
                catch (WebException webEx)
                {
                    bikeNum = "-1";
                }
            }
            else
            {
                bikeNum = stationCurrent.getBikeNum().ToString();
                //bikeNum += "cahce";
            }
            
                
            return bikeNum;
        }

        public string getCities()
        {
            string cityList = "";
            string str = "https://api.jcdecaux.com/vls/v1/contracts?apiKey=a326de14efef37ca365b64ee6b061b12437fb07d";
            WebRequest request = WebRequest.Create(str);
            //Get the response.
            WebResponse response;

            response = request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();


            JArray jarray = JArray.Parse(responseFromServer);

            Dictionary<string, StationProp> stationDic = new Dictionary<string, StationProp>();
            foreach (JObject item in jarray)
            {
                string city = (string)item.GetValue("name");
                cityList = cityList + city + ",";
            }
            
            return cityList;
        }

        public IAsyncResult BeginsearchStations(string city, AsyncCallback callback, object state)
        {
            var asyncResult = new SimpleAsyncResult<string>(state);

            var timer = new System.Timers.Timer(DelayMilliseconds);
            timer.Elapsed += (_, args) =>
            {
                asyncResult.Result = searchStations(city);
                asyncResult.IsCompleted = true;
                callback(asyncResult);
                timer.Enabled = false;
                timer.Close();
            };
            timer.Enabled = true;
            return asyncResult;
        }

        public string EndsearchStations(IAsyncResult asyncResult)
        {
            return ((SimpleAsyncResult<string>)asyncResult).Result;
        }

        public IAsyncResult BeginsearchBikeNum(string city, string station, AsyncCallback callback, object state)
        {
            var asyncResult = new SimpleAsyncResult<string>(state);

            var timer = new System.Timers.Timer(DelayMilliseconds);
            timer.Elapsed += (_, args) =>
            {
                asyncResult.Result = searchBikeNum(city,station);
                asyncResult.IsCompleted = true;
                callback(asyncResult);
                timer.Enabled = false;
                timer.Close();
            };
            timer.Enabled = true;
            return asyncResult;
        }

        public string EndsearchBikeNum(IAsyncResult asyncResult)
        {
            return ((SimpleAsyncResult<string>)asyncResult).Result;
        }
    }



    public class SimpleAsyncResult<T> : IAsyncResult
    {
        private readonly object accessLock = new object();
        private bool isCompleted = false;
        private T result;

        public SimpleAsyncResult(object asyncState)
        {
            AsyncState = asyncState;
        }

        public T Result
        {
            get
            {
                lock (accessLock)
                {
                    return result;
                }
            }
            set
            {
                lock (accessLock)
                {
                    result = value;
                }
            }
        }

        public bool IsCompleted
        {
            get
            {
                lock (accessLock)
                {
                    return isCompleted;
                }
            }
            set
            {
                lock (accessLock)
                {
                    isCompleted = value;
                }
            }
        }

        // WCF seems to use the async callback rather than checking the wait handle
        // so we can safely return null here.
        public WaitHandle AsyncWaitHandle { get { return null; } }

        // We will always be doing an async operation so completed synchronously should always
        // be false.
        public bool CompletedSynchronously { get { return false; } }

        public object AsyncState { get; private set; }
    }
}
