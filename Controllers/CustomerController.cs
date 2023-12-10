using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using VidlyPrj.Models;


namespace VidlyPrj.Controllers
{
    public class CustomerController : Controller
    {

        public IActionResult Index()
        {
           var customer = GetAllCustomer();
           return  View(customer);
        }

         public ActionResult Dtl(int id)
        {
            var Customer = GetAllCustomer().SingleOrDefault(c => c.Id == id);
     
            return Customer;    
        }


         private IActionResult GetAllCustomer()
        {
            var customers = new List<Customer>()
            {
              new Customer { Id = 1 , Name = "Lola"},
              new Customer { Id = 2, Name = "Tola"},
            };
            return View(customers);
        }



       
    }
}