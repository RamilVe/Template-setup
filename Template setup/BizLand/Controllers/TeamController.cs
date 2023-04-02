using BizLand.Models;
using Microsoft.AspNetCore.Mvc;

namespace BizLand.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Detail(int id)
        {
            Team member = Data.Members.Find(x => x.Id == id);
            return View(member);
        }

    }
}
