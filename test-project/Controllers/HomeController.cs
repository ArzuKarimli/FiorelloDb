using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using test_project.Data;
using test_project.Models;
using test_project.ViewModels;

namespace test_project.Controllers
{
  

    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController( AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            SliderInfo sliderInfo = await _context.SlidersInfo.FirstOrDefaultAsync();
            List<Category> categories= await _context.Categories.ToListAsync();
            List<Product> products= await _context.Products.Include(m=>m.ProductImages).ToListAsync();
            SupriseVideo supriseVideo= await _context.SupriseVideo.FirstOrDefaultAsync();
            SupriseInfo supriseInfo= await _context.SupriseInfos.FirstOrDefaultAsync();
            List<InfosItem> infosItems= await _context.InfoItems.ToListAsync();
            List<Expert> experts= await _context.Experts.ToListAsync();
            List<Position> positions= await _context.Positions.ToListAsync();

            HomeVM model = new()
            {
                Sliders = sliders,
                SliderInfo=sliderInfo,
                Categories=categories,
                Products=products,
                SupriseVideo=supriseVideo,
                SupriseInfo=supriseInfo,
                Infos=infosItems,
                Experts=experts,

            };
            
            return View(model);
        }

    
    }
}