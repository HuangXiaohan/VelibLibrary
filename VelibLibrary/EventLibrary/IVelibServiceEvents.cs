using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EventLibrary
{
    public interface IVelibServiceEvents
    {
        [OperationContract(IsOneWay = true)]
        void GottenBikeNum(string city, string station, string num);

        [OperationContract(IsOneWay = true)]
        void GottenFinished();
    }
}
