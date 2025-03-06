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
        public async Task<IEnumerable<PartViewModel>> AllAsync()
        {
              return await repository.AllReadOnly<Part>()
                .Include(p => p.Category)
                .Select(p => new PartViewModel()
                {
                    Name = p.Name,
                    Price = p.Price,
                    Category = p.Category.Name
                })
                .ToListAsync();
        }
    }
}
