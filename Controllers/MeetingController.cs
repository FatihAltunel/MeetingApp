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
            if (ModelState.IsValid){
            Repository.AddUser(model);
            ViewBag.UserCount = Repository.Users.Where(u => u.ParticipateStatus==true).Count();
            return View("Thanks", model);  
            }else{
                return View(model);
            }
        }  
        
        [HttpGet]
        public IActionResult List(){
            return View(Repository.Users);  
        }  
        [HttpGet]
        public IActionResult Details(int id){
            var user = Repository.Users.FirstOrDefault(user => user.Id==id);
            return View(user);
        }
    }
}