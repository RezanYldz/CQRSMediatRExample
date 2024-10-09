using CQRSMediatRExample.Api.Queries.Response;
using MediatR;

namespace CQRSMediatRExample.Api.Queries.Request
{
    public class GetAllCategoryQueryRequest : IRequest<List<GetAllCategoryQueryResponse>>
    {
    }
}
