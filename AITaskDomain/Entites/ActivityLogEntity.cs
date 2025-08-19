using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITaskDomain.Entites
{
    public class ActivityLogEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public required string Action { get; set; } // e.g., "Move Postit, Add Task"
        public DateTime Timestamp { get; set; } = DateTime.Now;
        public required string Details { get; set; } // Json
        public UserEntity User { get; set; } = null!; // Navigation property to UserEntity
    }
}
