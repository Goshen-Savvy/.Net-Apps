using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Controllers
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage ="This field is required")]
        [Column(TypeName = "nvarchar(250)")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        [DisplayName("Emp. Code")]
        public string EmpCode { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Position { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Office Location")]
        public string OfficeLocation { get; set; }
    }
}
