using DataHandler;
using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public class DataHandler
    {
        #region Using Static Lists
        /*public static List<Data> repoA;
        
        public  static List<Data> GetInstance()
        {
            if( repoA == null)
            {
                repoA = new List<Data>();
                repoA.Add(new Data("Sascha",30,3000));
                repoA.Add(new Data("Tina", 44, 3321));
                repoA.Add(new Data("Andi", 21, 2211));
                repoA.Add(new Data("Gerhard", 61, 1122));
                repoA.Add(new Data("Herbert", 53, 1224));
            }

            return repoA;
        }
        
        public List<Data> QueryAllData()
        {
            return GetInstance();
        }

        public Data AddData(string name, int age, int salary)
        {
            Data newData = new Data(name, age, salary);
            repoA.Add(newData);
            return newData;
        }
        */
        #endregion

        #region Using DB
        syco_trainingEntities dbmodel = new syco_trainingEntities();

        public List<Data> QueryAllData()
        {
            return dbmodel.wi16b142_training01.Select(result => new Data() {
                Id = (Guid)result.Id,
                Name = result.Name,
                Salary = (int)result.Salary
            }).ToList();
        }

        public Data AddData(Guid id, string name, int salary)
        {
            return null;
        }


        #endregion
    }
}
