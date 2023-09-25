using System.ComponentModel.DataAnnotations.Schema;

namespace RaneFattesingh.Persistance.EntityFramework.Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public Guid CustomerID { get; set; }
        public Customer Customer { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string ItemName { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public double ItemPrice { get; set; }
    }
}
