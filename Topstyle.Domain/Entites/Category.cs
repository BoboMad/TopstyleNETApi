using System.ComponentModel.DataAnnotations;

namespace Topstyle.Domain.Entites
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public virtual ICollection<Product>? Categories { get; set; }
    }
}
