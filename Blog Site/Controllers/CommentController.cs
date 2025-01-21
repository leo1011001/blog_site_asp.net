using Microsoft.AspNetCore.Mvc;

namespace Blog_Site.Controllers
{
    public class CommentController: Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
