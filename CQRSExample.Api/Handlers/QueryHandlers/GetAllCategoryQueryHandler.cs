using CQRSMediatRExample.Api.Queries.Request;
using CQRSMediatRExample.Api.Queries.Response;
using CQRSMediatRExample.DAL;

namespace CQRSMediatRExample.Api.Handlers.QueryHandlers
{
    public class GetAllCategoryQueryHandler
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public GetAllCategoryQueryHandler(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<List<GetAllCategoryQueryResponse>> GetAll(GetAllCategoryQueryRequest request)
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
