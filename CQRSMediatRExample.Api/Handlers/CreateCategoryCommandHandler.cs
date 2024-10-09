using CQRSMediatRExample.Api.Commands.Request;
using CQRSMediatRExample.Api.Commands.Response;
using CQRSMediatRExample.DAL;
using MediatR;

namespace CQRSMediatRExample.Api.Handlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest, CreateCategoryCommandResponse>
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public CreateCategoryCommandHandler(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
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
            }catch(Exception ex)
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
