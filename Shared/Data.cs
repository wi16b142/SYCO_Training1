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
            Name = "";
        }

        public Data(Guid id, string name, int salary)
        {
            Name = name;
            Id = Guid.NewGuid();
            Salary = salary;
        }

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public int Salary { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
