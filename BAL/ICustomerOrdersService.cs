using RaneFattesingh.BAL.Models;

namespace RaneFattesingh.BAL
{
    public interface ICustomerOrdersService
    {
        IEnumerable<Customer>? GetCustomers();
        IEnumerable<Order>? GetOrdersOfCustomer(Guid customerID);
    }
}
