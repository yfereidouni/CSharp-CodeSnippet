using iSecurity.CSRF.GoodSite.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace iSecurity.CSRF.GoodSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICustomerRepository customerRepository;

        public HomeController(ILogger<HomeController> logger, ICustomerRepository customerRepository)
        {
            _logger = logger;
            this.customerRepository = customerRepository;
        }

        public IActionResult Index()
        {
            var customers = customerRepository.GetCustomers();
            return View(customers);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(int customerId)
        {
            ///Wrong
            Response.Cookies.Append("CustomerId", customerId.ToString());

            ///Correction-1
            //Response.Cookies.Append("CustomerId", customerId.ToString(),new CookieOptions 
            //{
            //    // LAX:
            //    // if method was POST then coockie should not be transfer but
            //    // if method was GET then cookie can be transfer.
            //    SameSite = SameSiteMode.Strict
            //});
            return RedirectToAction("ViewEmtiaz");
        }

        public IActionResult ViewEmtiaz()
        {
            var customerId = int.Parse(Request.Cookies["CustomerId"]);
            var customer = customerRepository.GetCustomer(customerId);
            return View(customer);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken] ///Correction-2
        public IActionResult Transfer(int destinationCustomerId)
        {
            var customerId = int.Parse(Request.Cookies["CustomerId"]);
            var customer = customerRepository.GetCustomer(customerId);
            var destinationCustomer = customerRepository.GetCustomer(destinationCustomerId);
            var newEmtiaz = destinationCustomer.Emtiaz + customer.Emtiaz;

            customerRepository.SetEmtiaz(customerId, 0);
            customerRepository.SetEmtiaz(destinationCustomerId, newEmtiaz);

            return RedirectToAction("ViewEmtiaz");

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}