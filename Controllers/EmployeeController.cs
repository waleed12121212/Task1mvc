using Microsoft.AspNetCore.Mvc;
using task2.Data;

namespace task2.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index( )
        {
            var employees = context.Employee.ToList();
            return View("Index" , employees);
        }
    }
}
