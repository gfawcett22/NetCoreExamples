using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace RazorPagesExample.Models
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }
        [Required, MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Address { get; set; }
        public string Country { get; set; }
    }
}