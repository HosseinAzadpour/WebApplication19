using AutoMapper;
using WebApplication19.Models;
using WebApplication19.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication19.Controllers
{
    public class ManagerController : Controller
    {
        public IActionResult Index_Home()
        {
            MyWebsiteFirstCode db = new MyWebsiteFirstCode();

            List<About> abt = db.Abouts.ToList();
            ViewData["AboutList"] = abt;

            List<Skill> skl = db.Skills.ToList();
            ViewData["SkillList"] = skl;

            List<Example> exm = db.Examples.ToList();
            ViewData["ExampleList"] = exm;

            List<Contact> cnt = db.Contacts.ToList();
            ViewData["ContactList"] = cnt;
            return View();
        }

        public IActionResult About()
        {
            MyWebsiteFirstCode db = new MyWebsiteFirstCode();
            List<About> abt = db.Abouts.ToList();
            ViewData["AboutList"] = abt;
           return View();
        }
        public IActionResult Skill() 
        {
            MyWebsiteFirstCode db = new MyWebsiteFirstCode();
            List<Skill> skl = db.Skills.ToList();
            ViewData["SkillList"] = skl;
            return View();
        }
        public IActionResult Contact()
        {
            MyWebsiteFirstCode db = new MyWebsiteFirstCode();
            List<Contact> cnt = db.Contacts.ToList();
            ViewData["ContactList"] = cnt;
            return View();
        }
        public IActionResult Example()
        {
            MyWebsiteFirstCode db = new MyWebsiteFirstCode();
            List<Example> exm = db.Examples.ToList();
            ViewData["ExampleList"] = exm;
            return View();
        }
        public IActionResult ContactMessage()
        {
            return View();
        }

        public IActionResult Add_Skill(Skill_ViewModels skill, [FromServices] IMapper mapper)
        {
             MyWebsiteFirstCode db = new MyWebsiteFirstCode();
            Skill skl = mapper.Map<Skill>(skill);     
            db.Add(skl);
            db.SaveChanges();
            return RedirectToAction("Skill");
        }
        public IActionResult Add_Example(Example_ViewModels example, [FromServices] IMapper mapper)
        {
            MyWebsiteFirstCode db = new MyWebsiteFirstCode();
            Example exl = mapper.Map<Example>(example);
            db.Add(exl);
            db.SaveChanges();
            return RedirectToAction("Example");
        }
        public IActionResult Delete_Skill(List<int> DeleteSkillIds)
        {
            
                MyWebsiteFirstCode db = new MyWebsiteFirstCode();
                List<Skill> skl = db.Skills.Where(x => DeleteSkillIds.Contains(x.Id) == true).ToList();
                db.RemoveRange(skl);
                db.SaveChanges();
                return RedirectToAction("Skill");
            
        }
        public IActionResult Delete_Example(List<int> DeleteExampleIds)
        {

            MyWebsiteFirstCode db = new MyWebsiteFirstCode();
            List<Example> exm = db.Examples.Where(x => DeleteExampleIds.Contains(x.Id) == true).ToList();
            db.RemoveRange(exm);
            db.SaveChanges();
            return RedirectToAction("Example");

        }

        public IActionResult Update_About(int id, string Birthday, string Phonenumber, string City, string Website, string Age, string Email)
        {

            MyWebsiteFirstCode db = new MyWebsiteFirstCode();
            About abt = db.Find<About>(id);
            abt.PhoneNumber = Phonenumber;
            abt.Birthday = Birthday;
            abt.Email = Email;
            abt.City = City;
            abt.Age = Age;
            abt.Website = Website;
            db.Update(abt);
            db.SaveChanges(true);
            return RedirectToAction ("About");

        }
        public IActionResult Update_Contact(int id,  string Call, string Location, string MyEmail)
        {
            MyWebsiteFirstCode db = new MyWebsiteFirstCode();
            Contact cnt = db.Find<Contact>(id);
            cnt.Location = Location;
            cnt.Call = Call;
            cnt.MyEmail = MyEmail;
            db.Update(cnt);
            db.SaveChanges(true);
            return RedirectToAction("Contact");

        }

    }
}
