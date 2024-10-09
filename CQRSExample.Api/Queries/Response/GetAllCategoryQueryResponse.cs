namespace CQRSMediatRExample.Api.Queries.Response
{
    public class GetAllCategoryQueryResponse
    {
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string? Description { get; set; }
    }
}
