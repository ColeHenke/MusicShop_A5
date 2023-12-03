using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MusicShop.Data;
using MusicShop.Models;

namespace MusicShop.Controllers
{
    public class TestController : Controller
    {
        private readonly MusicShopContext _context;

        public TestController(MusicShopContext context)
        {
            _context = context;
        }

        // GET: Musics
        public async Task<IActionResult> Index()
        {
            return View(await _context.Music.ToListAsync());
        }
    }
}
