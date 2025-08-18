using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITaskDomain.Entites
{
    public class TaskEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; } // Foreign key to UserEntity
        public string Title { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
