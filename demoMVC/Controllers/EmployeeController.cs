using demoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace demoMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Employee ps){
            string strOutput = "Xin chào ! " + ps.PersonId + "- " + ps.fullname ;
            ViewBag.infoEmployee = strOutput;
            return View();
        }
    }
}