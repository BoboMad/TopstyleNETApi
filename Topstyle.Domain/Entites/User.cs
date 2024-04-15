using System.ComponentModel.DataAnnotations;

namespace Topstyle.Domain.Entites
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public virtual ICollection<Order> Orders { get; set;}

    }
}
