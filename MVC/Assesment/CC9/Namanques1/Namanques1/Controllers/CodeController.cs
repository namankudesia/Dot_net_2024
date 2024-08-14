using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Namanques1.Models;

namespace Namanques1.Controllers
{
    public class CodeController : Controller
    {
        private northwindEntities northwindDb = new northwindEntities();
        public ActionResult GetCustomersInGermany()
        {
            var germanCustomers = northwindDb.Customers
                                    .Where(c => c.Country == "Germany")
                                    .ToList();
            return View(germanCustomers);
        }
        public ActionResult GetCustomerByOrderId()
        {
            var customerDetails = (from order in northwindDb.Orders
                                   join customer in northwindDb.Customers
                                   on order.CustomerID equals customer.CustomerID
                                   where order.OrderID == 10248
                                   select customer).FirstOrDefault();

            return View(customerDetails);
        }
    }
}