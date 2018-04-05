using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EventLibrary
{
    [ServiceContract(CallbackContract = typeof(IVelibServiceEvents))]
    public interface IVelibService
    {
        [OperationContract]
        void GetBikeNum(string city, string station);

        [OperationContract]
        void SubscribeGottrnBikeNumEvent();

        [OperationContract]
        void SubscribeGottenFinishedEvent();
    }
}
