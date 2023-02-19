using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebApplication19.Models;
using WebApplication19.ViewModels;

namespace WebApplication19.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index_Eng()
        {
            MyWebsiteFirstCode db= new MyWebsiteFirstCode();

            List<About> abt= db.Abouts.ToList();
            ViewData["AboutList"]=abt;

            List<Skill> skl = db.Skills.ToList();
            ViewData["SkillList"] = skl;

            List<Example> exm = db.Examples.ToList();
            ViewData["ExampleList"] = exm;

            List<Contact> cnt = db.Contacts.ToList();
            ViewData["ContactList"] = cnt;
            return View();
        }
        public IActionResult Index_Per()
        {
            //MyWebsiteFirstCode db = new MyWebsiteFirstCode();

            //List<About> abt = db.Abouts.ToList();
            //ViewData["AboutList"] = abt;

            //List<Skill> skl = db.Skills.ToList();
            //ViewData["SkillList"] = skl;

            //List<Example> exm = db.Examples.ToList();
            //ViewData["ExampleList"] = exm;

            //List<Contact> cnt = db.Contacts.ToList();
            //ViewData["ContactList"] = cnt;
            return View();
        }
        public IActionResult SendMessage(ContactMessage_ViewModels msg, [FromServices] IMapper mapper)
        {
            MyWebsiteFirstCode db= new MyWebsiteFirstCode();
            ContactMessage cnt_msg= mapper.Map<ContactMessage>(msg);
            db.Add(cnt_msg);
            db.SaveChanges();
            return RedirectToAction("Index_Eng");
        }
    }
}
