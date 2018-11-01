using MVCGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCGrid.Controllers
{
    public class HomeController : Controller
    {
        string[] cities = { "NYC", "Delhi", "London", "Gurgaon", "Noida", "Faridabad" };
        Random rnd = new Random();
        List<Employee> empCollection;

        // GET: Home
        public ActionResult Index()
        {
            return View(CreateData());
        }

        private string GetRandomCity()
        {
            try
            {
                return cities[rnd.Next(1, 6)];
            }
            catch (Exception)
            {
                return cities[0];
            }
        }

        private List<Employee> CreateData()
        {
            empCollection = new List<Employee>();

            Random rnd1 = new Random(50);

            for (int i = 0; i < 100; i++)
            {
                empCollection.Add(new Employee()
                {
                    Id = i,
                    Name = "Emp " + rnd.Next(5000),
                    City = GetRandomCity(),
                    EmpID = "EMP" + i
                });
            }

            return empCollection;
        }
    }
}