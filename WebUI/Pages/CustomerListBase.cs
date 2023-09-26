using Microsoft.AspNetCore.Components;
using RaneFattesingh.WebUI.Models;
using RaneFattesingh.WebUI.Services;
using RaneFattesingh.WebUI.State;

namespace RaneFattesingh.WebUI.Pages
{
    public class CustomerListBase : ComponentBase
    {
        public IEnumerable<CustomerOrders> CustomerOrders { get; set; } = new List<CustomerOrders>();

        [Inject]
        private AppState appState { get; set; } = new AppState();
        [Inject]
        private ICustomerOrdersService _customerOrdersService { get; set; }
        [Inject]
        private NavigationManager navigationManager { get; set; }
        protected override async Task OnInitializedAsync()
        {
            try
            {
                var response = await _customerOrdersService.GetCustomerOrdersAsync();
                appState.CustomerOrders = response.Data.CustomerOrders;
            }
            catch
            {
                navigationManager.NavigateTo("/webapierror");
            }
        }

        protected IEnumerable<Customer> GetCustomers()
        {
            return appState.CustomerOrders.Select(customerOrder => customerOrder.Customer).ToList();
        }
    }
}
