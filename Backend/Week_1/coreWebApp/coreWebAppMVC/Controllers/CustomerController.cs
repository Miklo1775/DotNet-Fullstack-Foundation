using Microsoft.AspNetCore.Mvc;
using coreWebAppMVC.Models;

namespace coreWebAppMVC.Controllers
{
    public class CustomerController : Controller
    {
        public static List<Customer> customer = new List<Customer>()
        {
            new Customer() {Id = 101, Name = "Miklo", Amount = 50},
            new Customer() {Id = 102, Name = "Chichi", Amount = 100}
        };
        public IActionResult Index()
        {
            ViewBag.Message = "Customer Management System";
            ViewBag.CustomerCount = customer.Count();
            ViewBag.CustomerList = customer;
            return View();
        }

        public IActionResult Details()
        {
            ViewData["Message"] = "Details Pagerino";
            ViewData["CustomerCount"] = customer.Count();
            ViewData["CustomerList"] = customer;
            return View();
        }

        [Route("~/")]
        public IActionResult Temp()
        {
            TempData["Message"] = "Details Pagerino";
            TempData["CustomerCount"] = customer.Count();
            TempData["CustomerList"] = customer;
            return View();
        }

        public IActionResult Method2()
        {
            if (TempData["Message"] == null) {
                return RedirectToAction("Index");
            }

            ViewBag.Message = TempData["Message"].ToString();
            return View();
        }

        public IActionResult Message()
        {
            return View();
        }

        public IActionResult Login()
        {
            HttpContext.Session.SetString("username", "Miklo");
            return RedirectToAction("Success");

        }

        public IActionResult Success()
        {
            ViewBag.Username = HttpContext.Session.GetString("username");
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("Index");
        }

        public IActionResult QueryTest()
        {
            string name = "Miklo";
            if (!String.IsNullOrEmpty(HttpContext.Request.Query["name"])) { 
                name = HttpContext.Request.Query["name"];
            }
            ViewBag.Name = name;
            return View();
        }
    }
}
