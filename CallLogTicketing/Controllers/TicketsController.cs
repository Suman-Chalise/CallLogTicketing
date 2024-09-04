using CallLogTicketing.Data;
using Microsoft.AspNetCore.Mvc;
using CallLogTicketing.Enum;

namespace CallLogTicketing.Controllers
{
    public class TicketsController : Controller
    {

        private readonly ApplicationDbContext _DbContext;

        public TicketsController(ApplicationDbContext DbContext)
        {
            _DbContext = DbContext;
           
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
