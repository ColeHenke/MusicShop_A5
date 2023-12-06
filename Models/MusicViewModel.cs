using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MusicShop.Models
{
    public class MusicViewModel
    {
        [DisplayName("Select Item")]
        public int SongId { get; set; }
        public string Genre { get; set; }
        public string ArtistName { get; set; }
        public List<SelectListItem> ListofGenres { get; set; }
        public List<SelectListItem> ListofArtists { get; set; }
    }
}
