﻿using Microsoft.AspNetCore.Mvc;
using RaneFattesingh.BAL;
using WebAPI.ViewModels;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CustomerOrdersController : Controller
    {
        private readonly ILogger<CustomerOrdersController> _logger;
        private readonly ICustomerOrdersService _customerService;

        public CustomerOrdersController(ICustomerOrdersService customerService, ILogger<CustomerOrdersController> logger)
        {
            _customerService = customerService;
            _logger = logger;
        }

        [HttpGet(Name = "FetchCustomerList")]
        public IActionResult FetchCustomerList()
        {
            try
            {
                var customerOrders = new List<CustomerOrders>();
                var customers = _customerService.GetCustomers();
                if (customers != null)
                {
                    
                    foreach (var customer in customers)
                    {
                        var orders = _customerService.GetOrdersOfCustomer(customer.CustomerID);

                        List<Order> orderList = new List<Order>();
                        if (orders != null)
                        {
                            orderList = orders.Select(order => new Order
                            {
                                OrderID = order.OrderID,
                                ItemName = order.ItemName,
                                CustomerID = order.CustomerID,
                                ItemPrice = order.ItemPrice,
                            }).ToList();
                        }

                        var customerOrder = new CustomerOrders
                        {
                            Customer = new Customer
                            {
                                CustomerID = customer.CustomerID,
                                FirstName = customer.FirstName,
                                LastName = customer.LastName,
                                DOB = customer.DOB,
                            },
                            Orders = orderList
                        };

                        customerOrders.Add(customerOrder);
                    }
                }

                return Ok(new { Data = new { Success = true, CustomerOrders = customerOrders, TotalCount = customerOrders.Count } });
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e);

                return StatusCode(500, new { Data = new { Success = false, Error = "server failed to handle request." } });
            }
        }
    }
}
