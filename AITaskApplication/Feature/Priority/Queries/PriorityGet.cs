using AITaskDomain.Entites;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITaskApplication.Feature.Priority.Queries
{
    public class PriorityGet : IRequest<IQueryable<PriorityEntity>>
    {

    }
}
