using Microsoft.AspNetCore.Components;
using RaneFattesingh.WebUI.Models;
using RaneFattesingh.WebUI.State;

namespace RaneFattesingh.WebUI.Pages
{
    public class OrderDetailsBase : ComponentBase
    {
        [Parameter]
        public Guid CustomerID { get; set; }


        [Inject]
        private AppState _appState { get; set; }

        public CustomerOrders SelectedCustomer => _appState.CustomerOrders.FirstOrDefault(customerOrder => customerOrder.Customer.CustomerID == CustomerID) ?? new CustomerOrders();

        public string SelectedCustomerName => $"{SelectedCustomer.Customer.FirstName} {SelectedCustomer.Customer.LastName}";

        public IEnumerable<Order> SelectedCustomerOrders => SelectedCustomer.Orders;
    }
}
