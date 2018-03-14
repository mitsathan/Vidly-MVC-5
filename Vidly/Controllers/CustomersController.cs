using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customer

        ////mine
        //public ActionResult Index()
        //{
        //    var customers = GetCustomers(FillList());

        //    return View(customers);
        //}

        //public ActionResult Details(int id)
        //{

        //    var result = FillList().Where(c => c.Id == id).ToList();

        //    if (result.Count > 0)
        //    {
        //        var customers = GetCustomers(result);

        //        return View(customers);
        //    }
        //    else
        //    {
        //        return HttpNotFound();
        //    }
        //}

        //private CustomerViewModel GetCustomers(List<Customer> customerList)
        //{
        //    return new CustomerViewModel
        //    {
        //        Customers = customerList
        //    };
        //}

        //private List<Customer> FillList()
        //{
        //    return new List<Customer>
        //        {
        //            new Customer {Name = "J Smith",Id=1},
        //            new Customer {Name = "M Williams",Id=2}
        //    };
        //}

        //mosh
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };
        }
    }
}