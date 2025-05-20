using AutoPakevApp.Core.Contracts;
using AutoPakevApp.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace AutoPakevApp.Controllers
{
    public class ShoppingCartController : Controller
    {

        private readonly IShoppingCartService shoppingCartService;

        public ShoppingCartController(IShoppingCartService shoppingCartService)
        {
            this.shoppingCartService = shoppingCartService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var model = await shoppingCartService.GetShoppingCartItemsAsync(User.Id());

            if (model == null)
            {
                TempData["Message"] = "The cart is empty";
                return RedirectToAction("All", "Part");
            }
            
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(int partId, int quantity = 1)
        {
            await shoppingCartService.AddToCartAsync(User.Id(), partId, quantity);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public async Task<IActionResult> RemoveFromCart(int partId)
        {
            await shoppingCartService.RemoveFromCartAsync(User.Id(), partId);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DecreaseQuantity(int partId, int quantity = 1)
        {
            await shoppingCartService.DecreaseQuantityAsync(User.Id(), partId, quantity);
            return RedirectToAction(nameof(Index));
        }

    }
}
