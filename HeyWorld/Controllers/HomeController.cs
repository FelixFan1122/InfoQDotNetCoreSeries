using Microsoft.AspNetCore.Mvc;

namespace HeyWorld.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public string SayHey()
        {
            return "Hey, world.";
        }
    }
}