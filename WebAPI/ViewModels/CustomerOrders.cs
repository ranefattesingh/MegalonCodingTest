namespace WebAPI.ViewModels
{
    public class CustomerOrders
    {
        public Customer Customer { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
