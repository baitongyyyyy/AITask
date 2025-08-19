using AITaskApplication.Feature.Priority.Queries;
using AITaskDomain.Entites;
using AITaskDomain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITaskApplication.Feature.Priority.Handlers
{
    public class PriorityGetHandlers : IRequestHandler<PriorityGet, IQueryable<PriorityEntity>>
    {
        readonly IRepository<PriorityEntity> repository;

        public PriorityGetHandlers(IRepository<PriorityEntity> repository)
        {
            this.repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<IQueryable<PriorityEntity>> Handle(PriorityGet request, CancellationToken cancellationToken)
        {
            var priorities = await repository.GetAllAsync();
            return priorities.AsQueryable();
        }
    }
}
