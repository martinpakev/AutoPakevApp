using AutoPakevApp.Core.Models.ShoppingCart;
using AutoPakevApp.Infrastructure.Data.Models;

namespace AutoPakevApp.Core.Contracts
{
    public interface IShoppingCartService
    {
        Task<List<ShoppingCartItemViewModel>> GetShoppingCartItemsAsync(string userId);
        Task AddToCartAsync(string userId, int partId, int quantity = 1);

        Task RemoveFromCartAsync(string userId, int itemId);

        Task<decimal> GetTotalPriceAsync(string  userId);

        Task DecreaseQuantityAsync(string userId, int partId, int quantity);

    }
}
