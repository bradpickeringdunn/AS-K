using ASnK.Data;
using ASnK.Web.Actions;
using NLog;
using System.Web.Mvc;

namespace AS_K.Web.Controllers
{
    public class HomeController : Controller
    {
        ILogger logger;
        IRepository<tbl_Events, ASnKContext> repository;

        public HomeController(ILogger logger, IRepository<tbl_Events, ASnKContext> repository)
        {
            this.logger = logger;
            this.repository = repository;
        }

        public ActionResult Index()
        {
            return new LoadEventsAction<ActionResult>(repository, logger)
            {
                OnSuccess = (m) => View(m)
            }.Execute();
        }
        
    }
}