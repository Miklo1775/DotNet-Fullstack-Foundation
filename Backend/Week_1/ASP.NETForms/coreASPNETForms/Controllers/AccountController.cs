using Microsoft.AspNetCore.Mvc;
using coreASPNETForms.Models;

namespace coreASPNETForms.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult WeaklyTypedLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPost(string username, string password)
        {
            ViewBag.Username = username;
            ViewBag.Password = password;
            return View();
        }

        public IActionResult StronglyTypedLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginSuccess(LoginView login)
        {
            ViewBag.Username = login.Username;
            ViewBag.Password = login.Password;
            return View();
        }

        public IActionResult UserDetail()
        {
            var user = new LoginView()
            {
                Username = "Miklo",
                Password = "123456"
            };
            return View(user);
        }

        public IActionResult UserList()
        {
            List<LoginView> userList = new List<LoginView>()
            {
                new LoginView() {Username = "Chichi", Password = "12121212"},
                new LoginView() { Username = "Cheddar", Password = "13131313"},
                new LoginView() { Username = "Squishy", Password = "1414141414"}
            };

            return View(userList);
        }

        public IActionResult GetAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PostAccount(Account account)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Username = account.Username;
                ViewBag.Password = account.Password;
                return View("PostSuccess");
            }
            return RedirectToAction("GetAccount");
        }
    }
}
