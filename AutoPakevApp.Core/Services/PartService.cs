using AutoPakevApp.Core.Contracts;
using AutoPakevApp.Core.Models.Part;
using AutoPakevApp.Infrastructure.Data.Common;
using AutoPakevApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AutoPakevApp.Core.Services
{
    public class PartService : IPartService
    {
        private readonly IRepository repository;

        public PartService(IRepository repository)
        {
            this.repository = repository;
        }
        public async Task<PartPagingViewModel> AllAsync(int currentPage, int partsPerPage)
        {
            var totalParts = await repository.AllReadOnly<Part>().CountAsync();
            var totalPages = (int)Math.Ceiling(totalParts / (double)partsPerPage);

            var parts = await repository.AllReadOnly<Part>()
              .Include(p => p.Category)
              .OrderBy(p => p.Name)
              .Skip((currentPage - 1) * partsPerPage)
              .Take(partsPerPage)
              .Select(p => new PartViewModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price,
                    Category = p.Category.Name
                })
                .ToListAsync();

            return new PartPagingViewModel
            {
                Parts = parts,
                TotalPages = totalPages,
                CurrentPage = currentPage
            };
        }
    }
}
