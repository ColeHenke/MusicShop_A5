using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;
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
            var genreList = (from x in _context.Music select new SelectListItem()
                            {
                                Text=x.Genre,
                                Value=x.Genre.ToString()
                            }).Distinct().ToList();
            genreList.Insert(0, new SelectListItem()
            {
                Text = "---Select---",
                Value = string.Empty
            });
            ViewBag.ListofGenre = genreList;
            return View();
        }

        [HttpPost]
        public IActionResult Index(MusicViewModel musicViewModel)
        {
            var selectedValue = musicViewModel.SongId;
            return View(musicViewModel);
        }
    }
}
