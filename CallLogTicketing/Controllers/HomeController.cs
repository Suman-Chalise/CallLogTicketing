using CallLogTicketing.Data;
using CallLogTicketing.Models;
using CallLogTicketing.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CallLogTicketing.Enum;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CallLogTicketing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _DbContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext DbContext)
        {
            _logger = logger;
            _DbContext = DbContext;
        }

        public IActionResult Index()
        {
            var data = new TicketsViewModel
            {
                assignL = _DbContext.AssignTo.ToList(),
                projectsL = _DbContext.Projects.ToList(), 
                CustomersL = _DbContext.Customers.ToList(),
                ticketTypeL  = _DbContext.TicketTypes.ToList(),
                ticketsL = _DbContext.Tickets.ToList(),
                resellersL = _DbContext.Resellers.ToList()

            };

            return View(data);
        }

        public IActionResult Create()
        {
            var data = new TicketsViewModel
            {
                assignL = _DbContext.AssignTo.ToList(),
                projectsL = _DbContext.Projects.ToList(),
                CustomersL = _DbContext.Customers.ToList(),
                ticketTypeL = _DbContext.TicketTypes.ToList(),
                ticketsL = _DbContext.Tickets.ToList(),
                resellersL = _DbContext.Resellers.ToList()

            };
            return PartialView("_CreateTicket", data);
        }

        [HttpPost]
        public IActionResult Create( TicketsViewModel TVM)
        {

            if (ModelState.IsValid)
            {

                if (TVM.Tickets != null)
                {
                    _DbContext.Tickets.Add(TVM.Tickets);
                    _DbContext.SaveChanges();

                }
                return RedirectToAction("Index");
            }

            return View("_CreateTicket", TVM);
           
        }


        public IActionResult Details(int id)
        {
            var dd = _DbContext.Tickets.Find(id);

            var data = new TicketsViewModel
            {
                assignL = _DbContext.AssignTo.ToList(),
                projectsL = _DbContext.Projects.ToList(),
                CustomersL = _DbContext.Customers.ToList(),
                ticketTypeL = _DbContext.TicketTypes.ToList(),
                ticketsL = _DbContext.Tickets.ToList(),
                resellersL = _DbContext.Resellers.ToList(), 

                Tickets = dd,

            };
            return View(data);
        }


        //EDIT -------------------

        public IActionResult Edit(int id)
        {
            var dd = _DbContext.Tickets.Find(id);

            var data = new TicketsViewModel
            {
                assignL = _DbContext.AssignTo.ToList(),
                projectsL = _DbContext.Projects.ToList(),
                CustomersL = _DbContext.Customers.ToList(),
                ticketTypeL = _DbContext.TicketTypes.ToList(),
                ticketsL = _DbContext.Tickets.ToList(),
                resellersL = _DbContext.Resellers.ToList(),

                Tickets = dd

            };
            return View(data);
        }

        [HttpPost]
        public IActionResult Edit( TicketsViewModel data)
        {

            if (ModelState.IsValid)
            {


                _DbContext.Tickets.Update(data.Tickets);
                _DbContext.SaveChanges();


                return RedirectToAction("Index");
            }

            return View("Details");


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