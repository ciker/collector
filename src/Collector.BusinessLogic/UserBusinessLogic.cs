using Collector.Data;
using Collector.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collector.BusinessLogic
{
    public class UserBusinessLogic:BaseLogic<T_User>
    {
        public UserBusinessLogic(UserData userData) :
            base(userData)
        {
           
        }

        private UserData Data()
        {
            return ((UserData)this.data);
        }

        


    }
}
