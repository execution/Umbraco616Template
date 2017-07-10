using Umbraco616.Umbraco;
using System;
using System.Web.Mvc;
using Umbraco.Core;

namespace Umbraco616.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Initialize the application
            var application = new FoundationApplicationBase();
            application.Start(application, new EventArgs());
            Console.WriteLine("Application Started");

            Console.WriteLine("--------------------");
            //Write status for ApplicationContext
            var context = ApplicationContext.Current;
            Console.WriteLine("ApplicationContext is available: " + (context != null).ToString());
            //Write status for DatabaseContext
            var databaseContext = context.DatabaseContext;
            Console.WriteLine("DatabaseContext is available: " + (databaseContext != null).ToString());
            //Write status for Database object
            var database = databaseContext.Database;
            Console.WriteLine("Database is available: " + (database != null).ToString());
            Console.WriteLine("--------------------");

            //Get the ServiceContext and the two services we are going to use
            var serviceContext = context.Services;
            var contentService = serviceContext.ContentService;
            var contentTypeService = serviceContext.ContentTypeService;




            var items = contentService.GetById(1077);



            return View();
        }
    }
}
