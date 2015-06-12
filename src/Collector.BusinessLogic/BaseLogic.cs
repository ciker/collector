using Collector.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collector.BusinessLogic
{
    public class BaseLogic<T>
        where T:class
    {
        protected readonly BaseData<T> data;
        public BaseLogic(BaseData<T> baseData)
        {
            data = baseData;
        }

        

        public bool IsNew(T item)
        {
            return data.IsNew(item);
        }

        public void Save(T item)
        {
            data.Save(item);
        }

        public int Insert(T item)
        {
            return Convert.ToInt32(data.Insert(item));
        }

        public int Update(T item)
        {
           return data.Update(item);
        }

        public T Get(int id)
        {
            return data.Single(id);
        }

        public bool Delete(int id)
        {
           return data.Delete(id)>0;
        }


    }
}
