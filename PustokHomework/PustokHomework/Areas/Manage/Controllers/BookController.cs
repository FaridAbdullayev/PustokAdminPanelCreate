using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokHomework.Areas.Manage.ViewModels;
using PustokHomework.Data;
using PustokHomework.Models;

namespace PustokHomework.Areas.Manage.Controllers
{
    [Area("manage")]
    public class BookController : Controller
    {
        private readonly AppDbContext _context;
        public BookController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public IActionResult Index(int page = 1)
        {
            var query = _context.Books.Include(x => x.Genre).Include(x=>x.Author);
            return View(PaginatedList<Book>.Create(query, page, 2));
        }
    }
}
