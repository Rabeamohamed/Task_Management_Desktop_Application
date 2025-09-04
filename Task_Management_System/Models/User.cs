using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required ,MaxLength(50)]
        public string Name { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public List<TaskItem> TaskItems { get; set; } = new List<TaskItem>();
    }
}
