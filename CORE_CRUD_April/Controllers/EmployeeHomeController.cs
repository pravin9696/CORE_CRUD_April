using CORE_CRUD_April.Models;
using Microsoft.AspNetCore.Mvc;

namespace CORE_CRUD_April.Controllers
{
    public class EmployeeHomeController : Controller
    {
        public readonly MyEmpDBcontext dbo;
        public EmployeeHomeController(MyEmpDBcontext dbo1)
        {
                dbo=dbo1;
        }
        public IActionResult Index()
        {
            List<Employee> emps = dbo.Employees.ToList();

            return View(emps);
        }
        public IActionResult Edit(int id)
        {
            Employee e = dbo.Employees.FirstOrDefault(x => x.Id == id);
            return View(e);
        }
        [HttpPost]
        public IActionResult Edit(Employee emp)
        {
            Employee e = dbo.Employees.FirstOrDefault(x => x.Id == emp.Id);
            if (e!=null)
            {
                e.name = emp.name;
                e.Salary = emp.Salary;
                int n=dbo.SaveChanges();
                if (n>0)
                {
                    return RedirectToAction("index");
                }
               
            }
            return View();
        }
    }
}
