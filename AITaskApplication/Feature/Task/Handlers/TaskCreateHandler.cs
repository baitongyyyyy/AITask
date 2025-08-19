using AITaskApplication.Feature.Task.Command;
using AITaskDomain.Entites;
using AITaskDomain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITaskApplication.Feature.Task.Handlers
{
    public class TaskCreateHandler : IRequestHandler<CreateTaskCommand, Unit>
    {
        private readonly IRepository<TaskEntity> _repository;

        public TaskCreateHandler(IRepository<TaskEntity> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<Unit> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
        {
            var taskEntity = new TaskEntity
            {
                Title = request.Title,
                Description = request.Description,
                Status = request.Status,
                DueDate = request.DueDate,
                UserId = request.UserId,
                CreatedAt = DateTime.UtcNow
            };

            await _repository.AddAsync(taskEntity);
            return Unit.Value;
        }
    }
}
