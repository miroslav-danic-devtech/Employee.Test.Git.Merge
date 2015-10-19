using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employee.Test.Git.Merge.Repositories;
using Employee.Test.Git.Merge.Services;

namespace Employee.Test.Git.Merge.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITestService _testService;

        public HomeController()
        {
            _testService = new TestService(new TestRepository());
        }
        public HomeController(ITestService testService)
        {
            _testService = testService;
        }

        public ActionResult Index()
        {
            var testData = _testService.GetData();
            return View(testData);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}