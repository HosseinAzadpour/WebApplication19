using System.ComponentModel.DataAnnotations;

namespace WebApplication19.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        
        public string? MyEmail { get; set; }
        public string? Call { get; set; }
        public string? Location { get; set; }
    }
}
