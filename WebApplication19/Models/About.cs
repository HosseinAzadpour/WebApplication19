using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WebApplication19.Models
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        
        public  string? PhoneNumber { get; set; }
        
        public string? Birthday { get; set; }
        public string? Website { get; set; }
        public string? Age { get; set; }
        public string? City { get; set; }
        public string? Email { get; set; }
        public byte[]? ProfileImg { get; set; }
        public byte[]? HeroImg { get; set; }
    }
}
