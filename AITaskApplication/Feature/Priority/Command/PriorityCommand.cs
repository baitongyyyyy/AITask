using AITaskDomain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITaskApplication.Feature.Priority.Command
{
    public class PriorityCommand : IRequest<Unit>
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Feasibility { get; set; }
    }
}
