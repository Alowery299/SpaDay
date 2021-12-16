using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [Route("/user/add")]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [Route("/user/add")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
           if (newUser.Password == verify)
            {
                ViewBag.user = newUser;
                return View("Index");
            }
            else
            {
                ViewBag.email = newUser.Email;
                ViewBag.userName = newUser.UserName;
                ViewBag.error = "Password must match";
                return View("Add");
            }
        }

    }
}