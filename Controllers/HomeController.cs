using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RetailCompanyProject.Models;

namespace RetailCompanyProject.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private readonly MvcLaptopContext _context;


    public HomeController(ILogger<HomeController> logger, MvcLaptopContext context)
    {
      _context = context;
      _logger = logger;
    }

    public IActionResult Index()
    {
      return View();
    }
    public IActionResult Laptops()
    {
      return View( _context.Laptop.ToList());
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
      return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
  }
}
