using Microsoft.VisualBasic;

namespace WebApplication19.ViewModels
{
    public class About_ViewModels
    {
        public string PhoneNumber { get; set; }
        public string Birthday { get; set; }
        public string Website { get; set; }
        public string Age { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public IFormFile ProfileImg { get; set; }
        public IFormFile HeroImg { get; set; }
    }
}
