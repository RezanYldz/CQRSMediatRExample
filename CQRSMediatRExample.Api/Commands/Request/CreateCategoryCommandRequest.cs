using CQRSMediatRExample.Api.Commands.Response;
using MediatR;

namespace CQRSMediatRExample.Api.Commands.Request
{
    public class CreateCategoryCommandRequest : IRequest<CreateCategoryCommandResponse>
    {
        public string CategoryName { get; set; }
        public string? Description { get; set; }
    }
}
