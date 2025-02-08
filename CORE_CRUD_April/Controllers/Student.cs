using CORE_CRUD_April.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CORE_CRUD_April.Controllers
{
    public class Student : Controller
    {
        public MyEmpDBcontext dbo { set; get; } 
        public Student(MyEmpDBcontext dbo)
        {
            this.dbo = dbo;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddStudent()
        {
            List<Department> departmentList = dbo.Departments.ToList();

            SelectList depts = new SelectList(departmentList, "DeptID", "DeptName");
            ViewBag.depts = depts;
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent(Models.Student std)
        {
            if (ModelState.IsValid)
            {
                dbo.Studenttbl.Add(std);
                int n = dbo.SaveChanges();
                return RedirectToAction("Index");
            }

            List<Department> departmentList = dbo.Departments.ToList();

            SelectList depts = new SelectList(departmentList, "DeptID", "DeptName");
            ViewBag.depts = depts;
            return View();
        }
    }
}
