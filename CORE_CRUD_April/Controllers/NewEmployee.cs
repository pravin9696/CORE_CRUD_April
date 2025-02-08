using CORE_CRUD_April.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CORE_CRUD_April.Controllers
{
    public class NewEmployee : Controller
    {
        private readonly MyEmpDBcontext dbo;

        public NewEmployee(MyEmpDBcontext dbo)
        {
            this.dbo = dbo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddEmp()
        {
            List<Department> departmentList = dbo.Departments.ToList();
            SelectList depts = new SelectList(departmentList, "DeptID", "DeptName");
            ViewBag.Depts = depts;
            return View();
        }
        [HttpPost]
        public IActionResult AddEmp(Employee emp)
        {
           // if (ModelState.IsValid)
            {
                dbo.Employees.Add(emp);
                int n = dbo.SaveChanges();
                if (n>0)
                {
                    return RedirectToAction("Index");
                }
            }
            List<Department> departmentList = dbo.Departments.ToList();
            SelectList depts = new SelectList(departmentList, "DeptID", "DeptName");
            ViewBag.Depts = depts;
            return View();
        }
    }
}
