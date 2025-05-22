using AutoPakevApp.Core.Contracts;
using AutoPakevApp.Core.Models.ShoppingCart;
using AutoPakevApp.Infrastructure.Data.Common;
using AutoPakevApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoPakevApp.Core.Services
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IRepository repository;

        public ShoppingCartService(IRepository repository)
        {
            this.repository = repository;
        }

        public async Task<bool> AddToCartAsync(string userId, int partId, int quantity = 1)
        {
            var part = repository.AllReadOnly<Part>()
                .FirstOrDefault(p => p.Id == partId);

            if (part == null)
            {
                return false;
            }

            var existingItem = await repository.All<ShoppingCarItem>()
                .FirstOrDefaultAsync(i => i.ApplicationUserId == userId && i.PartId == partId);

            int currentQuantity = existingItem?.Quantity ?? 0;
            int newQuantity = currentQuantity + quantity;

            if (newQuantity > part.StockQuantity)
            {
                return false;
            }
           

            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                var newItem = new ShoppingCarItem
                {
                    ApplicationUserId = userId,
                    PartId = partId,
                    Quantity = quantity
                };
                await repository.AddAsync(newItem);
            }

            await repository.SaveChangesAsync();
            return true;
        }

        public async Task DecreaseQuantityAsync(string userId, int partId, int quantity)
        {
            var existingItem = await repository.All<ShoppingCarItem>()
                .FirstOrDefaultAsync(i => i.ApplicationUserId == userId && i.PartId == partId);

            if (existingItem != null)
            {
                existingItem.Quantity -= quantity;

                if (existingItem.Quantity <= 0)
                {
                    await repository.DeleteAsync<ShoppingCarItem>(existingItem.Id);
                }

                await repository.SaveChangesAsync();
            }
        }

        public async Task<List<ShoppingCartItemViewModel>> GetShoppingCartItemsAsync(string userId)
        {
            return await repository.AllReadOnly<ShoppingCarItem>()
                .Where(i => i.ApplicationUserId == userId)
                .Include(i => i.Part)
                .Select(i => new ShoppingCartItemViewModel
                {
                    ItemId = i.Id,
                    PartId = i.PartId,
                    PartName = i.Part.Name,
                    Quantity = i.Quantity,
                    Price = i.Part.Price
                })
                .ToListAsync();
        }

        public async Task<decimal> GetTotalPriceAsync(string userId)
        {
            var total = await repository.AllReadOnly<ShoppingCarItem>()
                .Where(i => i.ApplicationUserId == userId)
                .SumAsync(i => i.Quantity * i.Part.Price);

            return total;
        }

        public async Task RemoveFromCartAsync(string userId, int itemId)
        {
            var items = await repository.All<ShoppingCarItem>()
                .FirstOrDefaultAsync(i => i.ApplicationUserId == userId && i.PartId == itemId);

            if(items != null)
            {
                await repository.DeleteAsync<ShoppingCarItem>(items.Id);
                await repository.SaveChangesAsync();
            }

           
        }
    }
}
