using RaneFattesingh.DAL.Entities;
using RaneFattesingh.Persistance.EntityFramework;

namespace RaneFattesingh.DAL
{
    public class CustomerOrdersRepository : ICustomerOrdersRepository
    {
        private readonly CustomerContext _context;
        public CustomerOrdersRepository(CustomerContext context)
        {
            _context = context;
        }
        public IEnumerable<Customer>? GetCustomers()
        {
            var customers = _context.Customers.Select(customer => new Customer
            {
                CustomerID = customer.CustomerID,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                DOB = customer.DOB,
            }).ToList();

           return customers;
        }

        public IEnumerable<Order>? GetOrdersOfCustomer(Guid customerID)
        {
            var orders = _context.Orders.Where(order => order.CustomerID == customerID).ToList();

            var orderList = new List<Order>();
            if(orders.Any())
            {
                orderList = orders.Select(order => new Order
                {
                    OrderID = order.OrderID,
                    CustomerID = order.CustomerID,
                    ItemName = order.ItemName,
                    ItemPrice = order.ItemPrice,
                }).ToList();
            }

            return orderList;
        }
    }
}
