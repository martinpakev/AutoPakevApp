namespace AutoPakevApp.Core.Models.Part
{
    public class PartPagingViewModel
    {
        public IEnumerable<PartViewModel> Parts { get; set; } = new List<PartViewModel>();

        public int CurrentPage { get; set; }

        public int TotalPages { get; set; }

    }
}
