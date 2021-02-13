using Microsoft.AspNetCore.Mvc;

namespace portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet("")]

        public ViewResult Index()
        {
            return View();
        }
        [HttpGet("Projects")]
        public ViewResult Projects()
        {
            return View();
        }

        [HttpGet("Contact")]
        public ViewResult contact()
        {
            return View();
        }
    }
}