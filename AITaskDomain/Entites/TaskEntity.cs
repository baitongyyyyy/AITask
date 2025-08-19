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
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string Status { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
