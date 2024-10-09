namespace CQRSMediatRExample.Api.Commands.Response
{
    public class CreateCategoryCommandResponse
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public int? CategoryId { get; set; }
    }
}
