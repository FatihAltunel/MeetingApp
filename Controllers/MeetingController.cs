using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller{
        public IActionResult Index(){
            return View();  
        }  
        [HttpGet]
        public IActionResult Apply(){
            return View();  
        }  
        [HttpPost]
        public IActionResult Apply(UserInfo model){
            Repository.AddUser(model);
            ViewBag.UserCount = Repository.Users.Where(u => u.ParticipateStatus==true).Count();
            return View("Thanks", model);  
        }  
        public IActionResult List(){
            return View();  
        }  
    }
}