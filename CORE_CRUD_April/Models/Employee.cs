using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORE_CRUD_April.Models
{
    public class Employee
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [Column("EmpName", TypeName = "varchar(100)")]
        public string name { get; set; } = default!;
        [Required]
        public string? Salary { get; set; }
       
        public int DeptID { set; get; }
        [ForeignKey("DeptID")]
        public Department Department { get; set; } = default!;
    }
    public class Department
    {
        [Key]
        public int DeptID { get; set; }
        public string DeptName { get; set; }
    }
    public class Student
    {
        [Key]
        public int Roll { get; set; }
        [Required]
        public string Name { get; set; } = default!;
        [Required]
        public int DeptID { set; get; }
        [ForeignKey("DeptID")]
        [ValidateNever]
        public Department Department { get; set; } = default!;
    }
}
