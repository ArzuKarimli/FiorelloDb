using test_project.Models;

namespace test_project.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public SliderInfo SliderInfo { get; set; }
        public List<Category> Categories { get; set; }
        public List<Product> Products { get; set; }
        public SupriseVideo SupriseVideo { get; set; }
        public SupriseInfo SupriseInfo { get; set; }
        public List<InfosItem> Infos { get; set; }
       public List<Expert> Experts { get; set; }
       public List<Position> Positions { get; set; }

    }
}
