using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITaskDomain.Entites
{
    public class PriorityEntity
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public string Name { get; set; } // e.g., High, Medium, Low
        public int Feasibility { get; set; }
    }
}
