using ASnK.Data;
using ASnK.Web.ViewModels;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ASnK.Web.Actions
{
    public class LoadEventsAction<T> : BaseAction where T : class
    {
        private readonly IRepository<tbl_Events, ASnKContext> repository;
     
        public LoadEventsAction(IRepository<tbl_Events, ASnKContext> repository, ILogger logger)
        : base(logger)
        {
            this.repository = repository;
        }

        public Func<UserViewModel,T> OnSuccess { get; set; }
        
        public Func<T> OnFailed { get; set; }

        public override void Dispose()
        {
            if(repository != null)
            {
                repository.Dispose();
            }
        }

        public T Execute()
        {
            var model = TryExecute<UserViewModel>((result) =>
                        {
                            result.Events = repository.GetAll().ToList();
                        });


            return model.InError ? OnFailed() : OnSuccess(model);
        }
    }
}
