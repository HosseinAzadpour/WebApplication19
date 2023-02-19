using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication19.Models
{
    public class Example
    {
        [Key]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Subject { get; set; }
        public string? Website { get; set; }
        public string? NumberOfPage { get; set; }
        public byte[]? ExampleImg1 { get; set; }
        public byte[]? ExampleImg2 { get; set; }

        public byte[]? ExampleImg3 { get; set; }


    }
}
