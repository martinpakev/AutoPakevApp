using AutoPakevApp.Core.Models.Part;

namespace AutoPakevApp.Core.Contracts
{
    public interface IPartService
    {
        Task<IEnumerable<PartViewModel>> AllAsync();
    }
}
