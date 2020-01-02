using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        List<Customer> customer = new List<Customer>()
            {
                new Customer(){Name="John Smith",Id=1},
                new Customer(){Name="Sher Khan",Id=2}
            };

        // GET: Customer
        public ActionResult Index()
        {
            //var customer = new List<Customer>()
            //{
            //    new Customer(){Name="John Smith",Id=1},
            //    new Customer(){Name="Sher Khan",Id=2}
            //};

            var customers = new CustomerViewModel()
            {
                Customers = customer
            };
            return View(customers);
        }

        
        public ActionResult CustomerDetails(int id)
        {
            //if (customer.Contains() )
            //{

            //}
            return View();
        }
    }
}