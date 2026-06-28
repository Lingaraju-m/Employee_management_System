using System.ComponentModel.DataAnnotations;

namespace Employee_Management_System.Models
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }   

        public string Department { get; set; }
    }
}
