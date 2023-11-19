using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DAL;
using WebApplication1.Models;
using WebApplication1.ViewModels;
namespace WebApplication1.Controllers
{
    public class PortfolioController1 : Controller
    { private readonly AppDbContext _context;
        public PortfolioController1(AppDbContext context)
        {
            _context=context;
        }
        

        
        public IActionResult Index()
        {
            PortfolioViewModel model = new PortfolioViewModel()
            {
               Categories=_context.Categories.ToList(),
               Portfolios=_context.Portfolios.ToList(),

            };
            return View(model);

        }
        public IActionResult Detail(int id)
        {
            Portfolio portfolio = _context.Portfolios.Include(x=>x.Category).FirstOrDefault(x => x.Id == id);
            if (portfolio == null) 
            {
                return NotFound();
            }
            return View(portfolio);

        }
    }
}
