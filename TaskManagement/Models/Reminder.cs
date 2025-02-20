using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Models
{
    public class Reminder
    {
        public int Id { get; set; }
        public DateTime ReminderDate { get; set; }
        [ForeignKey("Task")]
        public int TaskId { get; set; }
        public bool IsRead { get; set; } = false;

        //Relations
        public Task Task { get; set; }
    }
}
