using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller{
        public IActionResult Index(){

            var meetingInfo = new MeetingInfo(){
                Id=1,
                Location="Istanbul ABC Kongre Merkezi",
                Date=new DateTime(2024,01,20,20,0,0),
                NumberOfPeople=93,
            };

            return View(meetingInfo);
        }
    }
}