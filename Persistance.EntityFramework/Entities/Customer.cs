using System.ComponentModel.DataAnnotations.Schema;

namespace RaneFattesingh.Persistance.EntityFramework.Entities
{
    public class Customer
    {
        public Guid CustomerID { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string FirstName { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
