using RaneFattesingh.WebUI.Models;

namespace RaneFattesingh.WebUI.State
{
    public class AppState
    {
        public IEnumerable<CustomerOrders> CustomerOrders { get; set; } = new List<CustomerOrders>();

    }
}
