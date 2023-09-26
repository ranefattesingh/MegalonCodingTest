namespace RaneFattesingh.WebUI.Models
{
    public class CustomerOrdersHttpResponseModel : IResponse
    {
        public bool Success { get; set; }
        public CustomerOrdersListDataModel Data { get; set; } = new CustomerOrdersListDataModel();
    }
}
