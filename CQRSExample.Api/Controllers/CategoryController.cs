using CQRSMediatRExample.Api.Commands.Request;
using CQRSMediatRExample.Api.Handlers.CommandHandlers;
using CQRSMediatRExample.Api.Handlers.QueryHandlers;
using CQRSMediatRExample.Api.Queries.Request;
using Microsoft.AspNetCore.Mvc;

namespace CQRSMediatRExample.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly CreateCategoryCommandHandler _createCategoryCommandHandler;
        private readonly GetAllCategoryQueryHandler _getAllCategoryQueryHandler;
        public CategoryController(CreateCategoryCommandHandler createCategoryCommandHandler, GetAllCategoryQueryHandler getAllCategoryQueryHandler)
        {
            _createCategoryCommandHandler = createCategoryCommandHandler;
            _getAllCategoryQueryHandler = getAllCategoryQueryHandler;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll([FromQuery] GetAllCategoryQueryRequest request)
        {
            var result = await _getAllCategoryQueryHandler.GetAll(request);

            return Ok(result);
        }
        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCategoryCommandRequest request)
        {
            var result = await _createCategoryCommandHandler.CreateProduct(request);

            return Ok(result);
        }
    }
}
