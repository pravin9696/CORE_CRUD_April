using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CORE_CRUD_April.Models
{
    public class Employee
    {

        [Key]
        public int Id { get; set; }
        [Column("EmpName",TypeName ="varchar(100)")]
        public string name { get; set; }
        public string Salary { get; set; }
    }
}
