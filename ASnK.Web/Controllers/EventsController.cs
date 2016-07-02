using ASnK.Data;
using ASnK.Web.ViewModels;
using NLog;
using System.Web.Mvc;

namespace ASnK.Web.Controllers
{
    public class EventsController : Controller
    {
        private readonly IRepository<tbl_RegisteredEvents, ASnKContext> repository;
        private readonly ILogger logger;

        public EventsController(IRepository<tbl_RegisteredEvents, ASnKContext> repository, ILogger logger)
        {
            this.repository = repository;
            this.logger = logger;
        }

        public ActionResult Registration(UserViewModel user)
        {
            //TODO:  Validate model state

            if (!ModelState.IsValid)
            {
                return View("~/views/home/index.cshtml",user);
            }
                return new Actions.RegisterUserAction<ActionResult>(repository, logger)
                {
                    OnSuccess = () => View("~/views/Events/UserRegestered.cshtml", user),
                    OnFailed = () => View()
                }.Execute(user);
            
        }
    }
}