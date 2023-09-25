using RaneFattesingh.BAL.Models;
using RaneFattesingh.DAL;

namespace RaneFattesingh.BAL
{
    public class CustomerOrdersService : ICustomerOrdersService
    {
        private readonly CustomerOrdersRepository _customerOrderRepository;
        public CustomerOrdersService(CustomerOrdersRepository customerOrderRepository)
        {
            _customerOrderRepository = customerOrderRepository;
        }
        public IEnumerable<Customer>? GetCustomers()
        {
            var customerList = new List<Customer>();
            var customers = _customerOrderRepository.GetCustomers();
            if (customers != null)
            {
                customerList = customers.Select(customer =>
                new Customer{
                    CustomerID = customer.CustomerID,
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    DOB = customer.DOB,
                }).ToList();
            }

            return customerList;
        }

        public IEnumerable<Order>? GetOrdersOfCustomer(Guid customerID)
        {
            var orderList = new List<Order>();
            var orders = _customerOrderRepository.GetOrdersOfCustomer(customerID);
            if (orders != null)
            {
                orderList = orders.Select(order =>
                new Order
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
