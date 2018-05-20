using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DataRepository;
using Shared;

namespace ServiceProvider
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service_Person : IService_Person
    {
        DataRepository.DataHandler dh = new DataRepository.DataHandler();

        public Data AddData(Guid id, string name, int salary)
        {
            return dh.AddData(id, name, salary);
        }

        public List<Data> QueryAllData()
        {
            return dh.QueryAllData();
        }
    }
}
