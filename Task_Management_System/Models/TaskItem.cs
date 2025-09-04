using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System.Models
{
    public enum TaskStatus
    {
        Pending,
        In_Progress,
        Completed
    }
    public enum PriorityLevel
    { 
        Low = 0,
        Medium = 1,
        High = 2
    }
    public class TaskItem
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Title { get; set; }
        [Required , MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public DateTime DueDate { get; set; } 
        public PriorityLevel Priority { get; set; } // Low, Medium, High
        public TaskStatus Status { get; set; } // Pending, In Progress, Completed

        [Required]
        public DateTime CreatedDate { get; set; } = DateTime.Now; // Creating Time of Task
        public DateTime? CompletedDate { get; set; }              // Compelete Time of Task
        [Required]
        public int UserId { get; set; } // Fk To Class User
        public User User { get; set; }
        [Required]
        public int CategoryId { get; set; } // Fk To Class Category
        public Category Category { get; set; }

    }
}



