using AITaskDomain.Entites;
using MediatR;

namespace AITaskApplication.Feature.Task.Queries
{
    public class TaskGet : IRequest<IQueryable<TaskEntity>>
    {
    }
}
