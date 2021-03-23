using MediatR;

namespace Bond.Contracts.Queries
{
    // Query 
    public class GetToDoByIdQuery : IRequest<Response>
    {
        public int Id { get; set; }
    }
    
    // Response

    public class Response
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Completed { get; set; }
    }
    
}
