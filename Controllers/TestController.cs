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
            //var genreQuery = (from x in _context.Music select x.Genre).Distinct().ToList();
            
            List < Music > genreList = _context.Music.ToList();
            ViewBag.ListGenres = new SelectList(genreList, "SongId", "Genre");
            return View();
            
        }
        [HttpPost]
        public IActionResult GetArtistsByGenre(int songId)
        {
            List<Music> artists = new List<Music>();
            artists = _context.Music.Where(m => m.SongId == songId).ToList();
            SelectList artistList = new SelectList(artists, "SongId", "ArtistName");
            return Json(artistList);
        }
        /*private List<SelectListItem> _listofGenres()
        {
            var genreList = (from x in _context.Music
                             select new SelectListItem()
                             {
                                 Text = x.Genre,
                                 Value = x.Genre.ToString()
                             }).Distinct().ToList();
            genreList.Insert(0, new SelectListItem()
            {
                Text = "---Select Genre---",
                Value = string.Empty
            }); 
            return genreList;
        }
        private List<SelectListItem> _listofArtists()
        {
            var artistList = (from x in _context.Music
                              select new SelectListItem()
                              {
                                  Text = x.ArtistName,
                                  Value = x.ArtistName.ToString()
                              }).Distinct().ToList();
            artistList.Insert(0, new SelectListItem()
            {
                Text = "---Select Artist---",
                Value = string.Empty
            });
            return artistList;
        }*/

        /*[HttpPost]
        public IActionResult Index(MusicViewModel musicViewModel)
        {
            var selectedValue = musicViewModel.SongId;
            return View(musicViewModel);
        }*/
    }
}
