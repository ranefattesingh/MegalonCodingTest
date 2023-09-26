using RaneFattesingh.WebUI.Models;

namespace RaneFattesingh.WebUI.Services
{
    public interface ICustomerOrdersService
    {
        Task<CustomerOrdersHttpResponseModel> GetCustomerOrdersAsync();
    }
}
