using E_CommerceManageMentSystem.Data;
using E_CommerceManageMentSystem.Data.ViewModels;
using E_CommerceManageMentSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace E_CommerceManageMentSystem.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }


        public async Task<IActionResult> Index(int page = 1, int pageSize = 3)
        {
            var products =  _context.Products
           .OrderBy(p => p.Name)
           .Skip((page - 1) * pageSize)
           .Take(pageSize)
           .ToList();

            var categories = _context.Products.Select(p => p.Category).Distinct().ToList();

            var totalProducts = _context.Products.Count();

            var viewModel = new ProductsViewModel
            {
                Products = products,
                Categories = categories,
                PageNumber = page,
                TotalPages = (int)Math.Ceiling(totalProducts / (double)pageSize)
            };

            return View(viewModel);

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
