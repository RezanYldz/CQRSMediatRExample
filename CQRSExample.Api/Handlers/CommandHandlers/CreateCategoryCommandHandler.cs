using CQRSMediatRExample.Api.Commands.Request;
using CQRSMediatRExample.Api.Commands.Response;
using CQRSMediatRExample.DAL;

namespace CQRSMediatRExample.Api.Handlers.CommandHandlers
{
    public class CreateCategoryCommandHandler
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public CreateCategoryCommandHandler(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<CreateCategoryCommandResponse> CreateProduct(CreateCategoryCommandRequest request)
        {
            try
            {
                var result = _applicationDbContext.Categories.Add(new()
                {
                    CategoryName = request.CategoryName,
                    Description = request.Description
                });
                _applicationDbContext.SaveChanges();

                return new CreateCategoryCommandResponse()
                {
                    CategoryId = result.Entity.CategoryId,
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                return new CreateCategoryCommandResponse()
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }
        }
    }
}
