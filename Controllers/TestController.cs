using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
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
            var distinctGenres = await _context.Music.Select(x => x.Genre).Distinct().ToListAsync();
            ViewBag.ListGenres = new SelectList(distinctGenres);

            //List < Music > genreList = _context.Music.ToList();
            //ViewBag.ListGenres = new SelectList(genreList, "SongId", "Genre");
            return View();

        }
        [HttpPost]
        public IActionResult GetArtistsByGenre(string genre)
        {
            //List<Music> artists = new List<Music>();
            //artists = _context.Music.Where(m => m.Genre == genre).Distinct().ToList();
            var distinctArtists = _context.Music
        .Where(m => m.Genre == genre)
        .Select(m => new { m.Genre, m.ArtistName })
        .Distinct()
        .ToList();
            SelectList artistList = new SelectList(distinctArtists, "Genre", "ArtistName");
            return Json(artistList);
        }

        [HttpPost]
        public IActionResult GetMusicByArtist(string genre)
        {
            var musicList = _context.Music
                .Where(m => m.Genre == genre).Select(m => new { m.SongName, m.ArtistName, m.Genre, m.Price })
                .ToList();

            return Json(musicList);
        }
    }
}