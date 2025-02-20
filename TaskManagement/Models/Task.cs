using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DueDate { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Complexity Complexity { get; set; }
        public Priority Priority { get; set; }
        public TaskStatus TaskStatus { get; set; }

        //Relations
        public Category Category { get; set; }
        public User User { get; set; }

        public List<Reminder> Reminders { get; set; }

    }
}
