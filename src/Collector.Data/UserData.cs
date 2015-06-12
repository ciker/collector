using Collector.Model.Domain;
using Collector.Model.Search;
using NPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collector.Data
{
    public class UserData:BaseData<T_User>
    {
        public T_User GetUserInfo(string userName, string password)
        {
            Sql where = Sql.Builder.Where("UserName=@0 and Password=@1", userName, password);
            return defaultDB.SingleOrDefault<T_User>(where);
        }

        public Page<T_User> Search(UserInfoSearch search)
        {
            Sql where = Sql.Builder.Where("State=1");
            var pageResult = defaultDB.Page<T_User>(search.page, search.pageSize, where);
            return pageResult;
        }

        public T_User GetUserInfo(string userName)
        {
            Sql where = Sql.Builder.Where("UserName=@0", userName);
            return defaultDB.SingleOrDefault<T_User>(where);
        }
    }
}
