using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;
using System.ComponentModel.DataAnnotations;

namespace MusicShop.Models
{
    public class Music
    {
        [Key]
        public int SongId { get; set; }
        public string SongName { get; set; }
        public string ArtistName { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        

    }
}
