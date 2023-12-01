using System.ComponentModel.DataAnnotations;

namespace MusicShop.Models
{
    public class Music
    {
        [Key]
        public required int SongId { get; set; }
        public required string SongName { get; set; }
        public required string ArtistName { get; set; }
        public required string Genre { get; set; }
        public required decimal Price { get; set; }

    }
}
