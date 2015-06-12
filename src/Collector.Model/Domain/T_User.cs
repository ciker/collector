using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collector.Model.Domain
{
    /// <summary>
    /// 用户信息
    /// </summary>
    [Serializable]
    public partial class T_User
    {
        public T_User()
        { }
        #region Model
        private int _id;
        private string _username;
        private string _email = "";
        private string _password = "";
        private DateTime _adddate = DateTime.Now;
        private DateTime _lastlogin = Convert.ToDateTime("1900-1-1");
        private string _photo = "";
        private int _type = 0;
        /// <summary>
        /// ID
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string Password
        {
            set { _password = value; }
            get { return _password; }
        }
        /// <summary>
        /// 注册时间
        /// </summary>
        public DateTime AddDate
        {
            set { _adddate = value; }
            get { return _adddate; }
        }
        /// <summary>
        /// 上次登录时间
        /// </summary>
        public DateTime LastLogin
        {
            set { _lastlogin = value; }
            get { return _lastlogin; }
        }
        /// <summary>
        /// 头像
        /// </summary>
        public string Photo
        {
            set { _photo = value; }
            get { return _photo; }
        }
        /// <summary>
        /// 类型
        /// </summary>
        public int Type
        {
            set { _type = value; }
            get { return _type; }
        }
        #endregion Model

    }
}
