namespace RaneFattesingh.WebUI.Models
{
    public class CustomerOrdersListDataModel : IListDataModel
    {
        public int TotalCount { get; set; }
        public IEnumerable<CustomerOrders> CustomerOrders { get; set; } = new List<CustomerOrders>();
    }
}
