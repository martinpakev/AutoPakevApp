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
        public async Task<IActionResult> All(int page = 1)
        {
            int partsPerPage = 3;
            var model = await partService.AllAsync(page, partsPerPage);


            return View(model);
        }
    }
}
