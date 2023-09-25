
using RaneFattesingh.DAL.Entities;

namespace RaneFattesingh.DAL
{
    internal interface ICustomerOrdersRepository
    {
        IEnumerable<Customer>? GetCustomers();
        IEnumerable<Order>? GetOrdersOfCustomer(Guid customerID);
    }
}
