namespace RaneFattesingh.BAL.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public Guid CustomerID { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
    }
}
