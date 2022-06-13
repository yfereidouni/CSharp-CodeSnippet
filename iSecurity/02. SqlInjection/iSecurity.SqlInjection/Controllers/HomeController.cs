using iSecurity.SqlInjection.Entities;
using iSecurity.SqlInjection.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace iSecurity.SqlInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string searchTerm = "Taheri")
        {
            //SqlInjection Query:
            //a' or 1=1;--
            //a' OR 1=1 UNION ALL SELECT '1','1','1';--
            //a' OR 1=1 UNION ALL SELECT object_id, name, '1' from sys.tables;--
            //a' OR 1=1; DELETE customers;--
            //a' OR 1=1; DROP TABLE customers;--
            var searchTest = $"SELECT Id,FirstName, Lastname FROM Customers WHERE Lastname like N'%{searchTerm}%'";
            var sqlConnection = new SqlConnection("Server=.;Initial Catalog=SqlInjection_DB;User Id=dbuser;Password=1qaz!QAZ;");
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand(searchTest, sqlConnection);
            var reader = cmd.ExecuteReader();

            List<Customer> customers = new List<Customer>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    var customer = new Customer
                    {
                        Id = reader.GetInt32(0),
                        FirstName = reader.GetString(1),
                        Lastname = reader.GetString(2),
                    };
                    customers.Add(customer);
                }
            }
            return View(customers);
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