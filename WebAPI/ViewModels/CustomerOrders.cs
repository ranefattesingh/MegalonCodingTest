namespace WebAPI.ViewModels
{
    public class CustomerOrders
    {
        public Customer Customer { get; set; } = new Customer();
        public IEnumerable<Order> Orders { get; set; } = new List<Order>();
    }
}
