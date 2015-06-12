using Collector.BusinessLogic;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Collector.Web.Helper
{
    public class NInjectDepend : IDependencyResolver
    {
        private readonly IKernel kernel;
        public NInjectDepend()
        {
            this.kernel = new StandardKernel();
            this.Binding();
        }

        /// <summary>
        /// 获取类型
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        public object GetService(Type serviceType)
        {
            return this.kernel.TryGet(serviceType);
        }

        /// <summary>
        /// 获取类型
        /// </summary>
        /// <param name="serviceType"></param>
        /// <returns></returns>
        public IEnumerable<object> GetServices(Type serviceType)
        {
            return this.kernel.GetAll(serviceType);
        }

        private void Binding()
        {
            this.kernel.Bind<UserBusinessLogic>().To<UserBusinessLogic>();
            
        }
    }
}