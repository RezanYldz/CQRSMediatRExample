using CQRSMediatRExample.Api.Commands.Request;
using CQRSMediatRExample.Api.Queries.Request;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRSMediatRExample.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllCategoryQueryRequest request)
        {
            var result = await _mediator.Send(request);

            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCategoryCommandRequest request)
        {
            var result = await _mediator.Send(request);

            return Ok(result);
        }
    }
}
