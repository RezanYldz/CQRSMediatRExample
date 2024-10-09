using CQRSMediatRExample.Api.Queries.Request;
using CQRSMediatRExample.Api.Queries.Response;
using CQRSMediatRExample.DAL;
using MediatR;

namespace CQRSMediatRExample.Api.Handlers.QueryHandlers
{
    public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQueryRequest, List<GetAllCategoryQueryResponse>>
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public GetAllCategoryQueryHandler(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<List<GetAllCategoryQueryResponse>> Handle(GetAllCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            var response = _applicationDbContext.Categories.Select(e =>
            new GetAllCategoryQueryResponse()
            {
                CategoryId = e.CategoryId,
                CategoryName = e.CategoryName,
                Description = e.Description
            }).ToList();
            return response;
        }
    }
}
