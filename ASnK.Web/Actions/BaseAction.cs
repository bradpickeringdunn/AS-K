using ASnK.Web.ViewModels;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASnK.Web.Actions
{
    public abstract class BaseAction : IDisposable
    {
        private readonly ILogger logger;

        public BaseAction(ILogger logger)
        {
            this.logger = logger;
        }

        public T TryExecute<T>(Action<T> action) where T : BaseViewModel, new()
        {
            var result = new T();

            try
            {
                action(result);
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                result.InError = true;
            }

            return result;
        }
        
        public abstract void Dispose();
    }
}
