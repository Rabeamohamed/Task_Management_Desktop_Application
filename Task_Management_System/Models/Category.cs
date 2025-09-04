﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Management_System.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required ,MaxLength(100)]
        public string Name { get; set; }
        public List<TaskItem> TaskItems { get; set; } = new List<TaskItem>();
    }
}





