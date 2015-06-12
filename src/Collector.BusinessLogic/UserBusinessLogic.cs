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
        private readonly UserData userData;
        public UserBusinessLogic(UserData userData) :
            base(userData)
        {
            userData = ((UserData)this.data);
        }

        
    }
}
