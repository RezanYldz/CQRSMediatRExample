namespace CQRSMediatRExample.Api.Commands.Request
{
    public class CreateCategoryCommandRequest
    {
        public string CategoryName { get; set; }
        public string? Description { get; set; }
    }
}
