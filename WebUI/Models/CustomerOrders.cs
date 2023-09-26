namespace RaneFattesingh.WebUI.Models
{
    public class CustomerOrders
    {
        public Customer Customer { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}
