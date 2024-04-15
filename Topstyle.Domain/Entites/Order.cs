using System.ComponentModel.DataAnnotations;

namespace Topstyle.Domain.Entites
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }

        public DateTime OrderDate { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public virtual User User { get; set; }
    }
}
