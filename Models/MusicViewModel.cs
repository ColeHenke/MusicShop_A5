using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MusicShop.Models
{
    public class MusicViewModel
    {
        [DisplayName("Genre")]
        public int SongId { get; set; }
        public string Genre { get; set; }
        public List<SelectListItem> ListofGenres { get; set; }
    }
}
