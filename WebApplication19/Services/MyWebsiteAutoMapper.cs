using AutoMapper;
using WebApplication19.Models;
using WebApplication19.ViewModels;

namespace WebApplication19.Services
{
    public class MyWebsiteAutoMapper:Profile
    {
        private byte[] DownloadImg(IFormFile img)
        {
            if (img != null)
            {
                byte[] b = new byte[img.Length];
                img.OpenReadStream().Read(b, 0, b.Length);
                return b;
            }
            return new byte[] { 0 };
        }
        public MyWebsiteAutoMapper()
        {
            CreateMap<About_ViewModels, About>().ReverseMap();
            CreateMap<About_ViewModels, About>().ForMember(x => x.HeroImg, z => z.MapFrom(y => DownloadImg(y.HeroImg)));
            CreateMap<About_ViewModels, About>().ForMember(x => x.ProfileImg, z => z.MapFrom(y => DownloadImg(y.ProfileImg)));
            CreateMap<Contact_ViewModels, Contact>().ReverseMap();
            CreateMap<ContactMessage_ViewModels, ContactMessage>().ReverseMap();
            CreateMap<Example_ViewModels, Example>().ReverseMap();
            CreateMap<Skill_ViewModels, Skill>().ReverseMap();
            CreateMap<Example_ViewModels, Example>().ForMember(x => x.ExampleImg1, z => z.MapFrom(y => DownloadImg(y.ExampleImg1)));
            CreateMap<Example_ViewModels, Example>().ForMember(x => x.ExampleImg2, z => z.MapFrom(y => DownloadImg(y.ExampleImg2)));
            CreateMap<Example_ViewModels, Example>().ForMember(x => x.ExampleImg3, z => z.MapFrom(y => DownloadImg(y.ExampleImg3)));

        }
    }
}
