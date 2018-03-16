using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

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

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context=new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //mosh
        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c=>c.MembershipType).ToList();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c=>c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}