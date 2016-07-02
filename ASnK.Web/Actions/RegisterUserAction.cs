using ASnK.Data;
using ASnK.Web.ViewModels;
using NLog;
using System;

namespace ASnK.Web.Actions
{
    public class RegisterUserAction<T> : BaseAction where T : class
    {
        private readonly IRepository<tbl_RegisteredEvents, ASnKContext> repository;

        public RegisterUserAction(IRepository<tbl_RegisteredEvents, ASnKContext> repository, ILogger logger)
            : base(logger)
        {
            this.repository = repository;
        }

        public Func<T> OnSuccess { get; set; }

        public Func<T> OnFailed { get; set; }
        
        public T Execute(UserViewModel model)
        {
            //TODO:  Run rules in domain 

            //TODO:  If have time Use assembler 
            var entity = new tbl_RegisteredEvents()
            {
                EventId = model.EventId,
                Email = model.Email,
                ArivalDate = model.ArrivalDate,
                Country = model.Country,
                Firstname = model.Firstname,
                ArivalTime = model.ArrivalTime,
                Lastname = model.Lastname,
                RegistrationDate = model.RegistrationDate
            };

            var resultModel = TryExecute<BaseViewModel>((result) =>
            {
                repository.Update(entity);

                result.InError = entity.RegisteredEventId > 0 ? false : true;
                
            });


            return resultModel.InError ? OnFailed() : OnSuccess();
        }

        public override void Dispose()
        {
            if(repository != null)
            {
                repository.Dispose();
            }
        }
    }
}
