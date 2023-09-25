
using RaneFattesingh.DAL.Entities;

namespace RaneFattesingh.DAL
{
    public interface ICustomerOrdersRepository
    {
        IEnumerable<Customer>? GetCustomers();
        IEnumerable<Order>? GetOrdersOfCustomer(Guid customerID);
    }
}
