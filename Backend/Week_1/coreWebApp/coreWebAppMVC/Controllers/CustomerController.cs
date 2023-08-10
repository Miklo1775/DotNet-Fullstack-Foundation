using Microsoft.AspNetCore.Mvc;
using coreWebAppMVC.Models;

namespace coreWebAppMVC.Controllers
{
    public class CustomerController : Controller
    {
        public static List<Customer> customer = new List<Customer>()
        {
            new Customer() {Id = 101, Name = "Miklo", Amount = 50}
        };
        public IActionResult Index()
        {
            ViewBag.Message = "Customer Management System";
            ViewBag.CustomerCount = customer.Count();
            ViewBag.CustomerList = customer;
            return View();
        }

        [Route("~/")]
        public IActionResult Details()
        {
            return View();
        }


        public IActionResult Message()
        {
            return View();
        }


    }
}
