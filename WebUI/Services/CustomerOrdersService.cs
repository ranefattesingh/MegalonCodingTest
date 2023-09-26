using RaneFattesingh.WebUI.Models;

namespace RaneFattesingh.WebUI.Services
{
    public class CustomerOrdersService : ICustomerOrdersService
    {
        private readonly HttpClient _httpClient;
        public CustomerOrdersService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<CustomerOrdersHttpResponseModel> GetCustomerOrdersAsync() => await _httpClient.GetFromJsonAsync<CustomerOrdersHttpResponseModel>("/api/v1/CustomerOrders");
    }
}
