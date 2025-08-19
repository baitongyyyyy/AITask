using AITaskDomain.Interfaces;
using MediatR;
using AITaskDomain.Entites;
using AITaskApplication.Feature.Priority.Command;

namespace AITaskApplication.Feature.Priority.Handlers
{
    public class PriorityCreateHandler : IRequestHandler<PriorityCommand, Unit>
    {
        readonly IRepository<PriorityEntity> _repository;

        public PriorityCreateHandler(IRepository<PriorityEntity> repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(PriorityCommand request, CancellationToken cancellationToken)
        {
            var priority = new PriorityEntity
            {
                Id = request.Id,
                Name = request.Name,
            };

            await _repository.AddAsync(priority);
            return Unit.Value;
        }
    }
}
