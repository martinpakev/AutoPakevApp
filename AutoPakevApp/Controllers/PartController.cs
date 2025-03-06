using AutoPakevApp.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace AutoPakevApp.Controllers
{
    public class PartController : Controller
    {
        private readonly IPartService partService;

        public PartController(IPartService partService)
        {
            this.partService = partService;
        }

        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await partService.AllAsync();


            return View(model);
        }
    }
}
