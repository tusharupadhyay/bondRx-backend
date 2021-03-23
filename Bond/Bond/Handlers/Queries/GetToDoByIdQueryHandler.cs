using Bond.Contracts.Queries;
using Bond.Database;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Bond.Handlers.Queries
{
    public class GetToDoByIdQueryHandler : IRequestHandler<GetToDoByIdQuery, Response>
    {
        private readonly Repository _repository;
        public GetToDoByIdQueryHandler(Repository repository)
        {
            _repository = repository;
        }
        public async Task<Response> Handle(GetToDoByIdQuery request, CancellationToken cancellationToken)
        {
            // All the business logic
            var todo = _repository.Todos.FirstOrDefault(x => x.Id == request.Id);
            return todo == null ? null : new Response { Id = todo.Id, Name = todo.Name, Completed = todo.Completed };
        }
    }
    
}
