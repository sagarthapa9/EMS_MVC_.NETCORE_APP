using System.ComponentModel.DataAnnotations;

namespace EMSApp.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
