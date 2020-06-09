﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Covid19.Models;

using Microsoft.EntityFrameworkCore;
using MvcTips.Data;

using APIConsume.Models;
using Newtonsoft.Json;
using System.Net.Http;

namespace Covid19.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MvcTipsContext _context;


        public HomeController(ILogger<HomeController> logger, MvcTipsContext context)
        {
            _logger = logger;
            _context = context;
        }
        
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tips.ToListAsync());
        }

        public IActionResult Details(int? id) => Redirect("/Tips/Details/" + id);

        public async Task<IActionResult> Tracker()
        {
            List<Cases> Cases = new List<Cases>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://covid19-brazil-api.now.sh/api/report/v1/Brazil"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Cases = JsonConvert.DeserializeObject<List<Cases>>(apiResponse);
                }
            }
            return View(Cases); 
        }
        public IActionResult Privacy => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
