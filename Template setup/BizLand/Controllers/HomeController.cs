using BizLand.Models;
using BizLand.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BizLand.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel
            {
                Services = Data.Services,
                Members = Data.Members
            };
            return View(model);
        }

        public IActionResult Contact()
        {
            return View();
        }
    }
}
