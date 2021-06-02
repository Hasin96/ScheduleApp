using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Schedule.Models;
using Schedule.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Schedule.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IWebHostEnvironment _environment;
        private ScheduleContext _context = new ScheduleContext();

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment environment)
        {
            _logger = logger;
            _environment = environment;
        }

        public async Task<IActionResult> Index()
        {
            var wwwPath = _environment.WebRootPath;

            var tasks = await _context.Tasks
            .Select(t => new TasksViewModel()
            {
                Title = t.Title,
                Time = t.DateAndTime.TimeOfDay,
                Color = t.Color.Color,
                //IconHTML = FileHelper.GetSvgFromFile(wwwPath, t.Icon.FolderUrl, t.Icon.FileName)
            })
            .ToListAsync();

            return View(tasks);
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
