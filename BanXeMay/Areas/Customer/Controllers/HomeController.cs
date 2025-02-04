﻿using BanXeMay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BanXeMay.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index(int? page)

        {  //var productList = _db.Products.Include(x => x.Category).ToList();
           //    return View(productList);
            var pageIndex = (int)(page != null ? page : 1);
            var pageSize = 8;

            var dsSanPham = _db.Products.Include(x => x.Category).ToList();

            var pageSum = dsSanPham.Count() / pageSize + (dsSanPham.Count() % pageSize > 0 ? 1 : 0);

            ViewBag.PageSum = pageSum;
            ViewBag.PageIndex = pageIndex;
            return View(dsSanPham.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }


    }
}
