using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITaskDomain.Entites
{
    public class UserEntity
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string LoginBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<ActivityLogEntity> ActivityLogs { get; set; } = new List<ActivityLogEntity>();
    }
}