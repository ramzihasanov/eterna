using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.DAL;
using WebApplication1.Migrations;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context=context;
        }

        public IActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel()
            {
                Sliders=_context.Slider.ToList(),

            };
            return View(homeViewModel);
        }

      
    }
}