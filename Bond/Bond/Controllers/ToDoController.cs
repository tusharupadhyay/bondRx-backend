using Bond.Contracts.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Bond.Controllers
{
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ToDoController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("/{id}")]        
        public async Task<IActionResult> GetToDoByIdAsync(int id)
        {
            var response = await _mediator.Send(new GetToDoByIdQuery { Id = id });
            if (response == null)
                return NotFound();
            else
                return Ok(response);
        }
    }
}
