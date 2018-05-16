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
        DataHandler dh = new DataHandler();

        public Data AddData(string name, int age, int salary)
        {
            return dh.AddData(name, age, salary);
        }

        public List<Data> QueryAllData()
        {
            return dh.QueryAllData();
        }
    }
}
