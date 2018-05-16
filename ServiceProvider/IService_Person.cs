using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceProvider
{
    [ServiceContract]
    public interface IService_Person
    {
        [OperationContract]
        List<Data> QueryAllData();

        [OperationContract]
        Data AddData(string name, int age, int salary);
    }
}
