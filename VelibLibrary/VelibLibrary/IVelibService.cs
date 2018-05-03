using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace VelibLibrary
{
    [ServiceContract]
    public interface IVelibService
    {
        [OperationContract]
        string searchStations(string city);

        [OperationContract(AsyncPattern = true)]
        IAsyncResult BeginsearchStations(string city, AsyncCallback callback, object state);
        string EndsearchStations(IAsyncResult asyncResult);

        [OperationContract]
        string searchBikeNum(string city, string station);

        [OperationContract(AsyncPattern = true)]
        IAsyncResult BeginsearchBikeNum(string city, string station, AsyncCallback callback, object state);
        string EndsearchBikeNum(IAsyncResult asyncResult);

        [OperationContract]
        string getCities();

    }
}
