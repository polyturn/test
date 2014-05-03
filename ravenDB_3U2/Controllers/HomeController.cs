using ravenDB_3U2 .Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ravenDB_3U2 .Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var session = MvcApplication.MyStore.OpenSession())
            {
                Employee objEmp = new Employee
                {
                    FirstName = "AAA",
                    LastName = "BBB",
                    EmployeeId = 30,
                    DateJoined = DateTime.Now.AddYears(-1),
                    Department = new Department { Description = "Software services", Name = "IT" },
                    Position = new Position { Name = "Project Lead", Description = "Project Mgmt Role" }
                };
                session.Store(objEmp);
                session.SaveChanges();//To Commit our changes to DB.
                //Get Employee back from DB
                Employee myEmp = session.Query<Employee>().Where(a => a.FirstName == "AAA").First();
                return View(myEmp);
            }
        }
    }
}