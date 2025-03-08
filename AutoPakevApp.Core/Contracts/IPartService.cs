using AutoPakevApp.Core.Models.Part;

namespace AutoPakevApp.Core.Contracts
{
    public interface IPartService
    {
        Task<PartPagingViewModel> AllAsync(int currentPage, int partsPerPage);
    }
}
