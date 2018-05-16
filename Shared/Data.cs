using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
    [DataContract]
    public class Data
    {
        public Data()
        {
        }

        public Data(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Age { get; set; }
        [DataMember]
        public int Salary { get; set; }
    }
}
