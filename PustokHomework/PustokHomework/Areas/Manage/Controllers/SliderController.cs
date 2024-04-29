using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokHomework.Areas.Manage.ViewModels;
using PustokHomework.Data;
using PustokHomework.Models;

namespace PustokHomework.Areas.Manage.Controllers
{
    [Area("manage")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        public SliderController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public IActionResult Index(int page =1)
        {
            var query = _context.Sliders;
            return View(PaginatedList<Slider>.Create(query, page, 2));
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Slider slider)
        {
            _context.Sliders.Add(slider);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
    }
}
