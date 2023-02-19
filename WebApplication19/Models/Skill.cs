using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication19.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }
        public string? SkillName { get; set; }
        public string? SkillIcon { get; set;}
    }
}
