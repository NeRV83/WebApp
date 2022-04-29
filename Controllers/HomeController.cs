using BusinessLayer;
using DataLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RailParts___WebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RailParts___WebApp.Controllers
{
    public class HomeController : Controller
    {
        private EFDBContext _context;
        private readonly ILogger<HomeController> _logger;
        private IStorageAreaRep _StorageAreaRep;
        private DataManager _dataManager;

        public HomeController(EFDBContext context, ILogger<HomeController> logger, IStorageAreaRep StorageAreaRep, DataManager dataManager)
        {
            _context = context;
            _logger = logger;
            _StorageAreaRep = StorageAreaRep;
            _dataManager = dataManager;
        }

        public IActionResult Index()
        {
            //List<StorageArea> _stor = _context.StorageArea.Include(x=>x.Details).ToList();
            //List<StorageArea> _stor = _StorageAreaRep.GetAllStorAreas().ToList();
            List<StorageArea> _stor = _dataManager.StorageArea.GetAllStorAreas(true).ToList();
            return View(_stor);
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
