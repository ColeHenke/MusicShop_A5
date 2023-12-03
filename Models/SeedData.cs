using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MusicShop.Data;
using System;
using System.Linq;

namespace MusicShop.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MusicShopContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MusicShopContext>>()))
        {
            // Look for any movies.
            if (context.Music.Any())
            {
                return;   // DB has been seeded
            }
            context.Music.AddRange(
                new Music
                {
                    SongName = "Sing for the Moment",
                    ArtistName = "Eminem",
                    Genre = "Rap",
                    Price = 1.99M
                },
                new Music
                {
                    SongName = "The Real Slim Shady",
                    ArtistName = "Eminem",
                    Genre = "Rap",
                    Price = 1.99M
                },
               new Music
               {
                   SongName = "Thunderstruck",
                   ArtistName = "AC/DC",
                   Genre = "Rock",
                   Price = 1.59M
               },
                new Music
                {
                    SongName = "Highway to Hell",
                    ArtistName = "AC/DC",
                    Genre = "Rock",
                    Price = 1.59M
                },
                new Music
                {
                    SongName = "90210",
                    ArtistName = "Travis Scott",
                    Genre = "Rap",
                    Price = 1.99M
                },
                new Music
                {
                    SongName = "SICKO MODE",
                    ArtistName = "Eminem",
                    Genre = "Rap",
                    Price = 1.99M
                },
                new Music
                {
                    SongName = "Animals",
                    ArtistName = "Architects",
                    Genre = "Rock",
                    Price = 1.59M
                },
                new Music
                {
                    SongName = "Doomsday",
                    ArtistName = "Architects",
                    Genre = "Rock",
                    Price = 1.59M
                },
                new Music
                {
                    SongName = "Whiskey Glasses",
                    ArtistName = "Morgan Wallen",
                    Genre = "Country",
                    Price = 1.89M
                },
                new Music
                {
                    SongName = "Wasted on You",
                    ArtistName = "Morgan Wallen",
                    Genre = "Country",
                    Price = 1.89M
                },
                new Music
                {
                    SongName = "Burn",
                    ArtistName = "Ellie Goulding",
                    Genre = "Pop",
                    Price = 1.59M
                },
                new Music
                {
                    SongName = "Love Me Like You Do",
                    ArtistName = "Ellie Goulding",
                    Genre = "Pop",
                    Price = 1.59M
                },
                new Music
                {
                    SongName = "Shake It Off",
                    ArtistName = "Taylor Swift",
                    Genre = "Pop",
                    Price = 1.99M
                },
                new Music
                {
                    SongName = "Love Story",
                    ArtistName = "Taylor Swift",
                    Genre = "Country",
                    Price = 1.59M
                },
                new Music
                {
                    SongName = "Let It Happen",
                    ArtistName = "Tame Impala",
                    Genre = "Alternative",
                    Price = 1.49M
                },
                new Music
                {
                    SongName = "Borderline",
                    ArtistName = "Tame Impala",
                    Genre = "Alternative",
                    Price = 1.49M
                },
                new Music
                {
                    SongName = "Crooked Soul",
                    ArtistName = "Dayseeker",
                    Genre = "Rock",
                    Price = 1.49M
                },
                new Music
                {
                    SongName = "Crash and Burn",
                    ArtistName = "Dayseeker",
                    Genre = "Rock",
                    Price = 1.49M
                },
                new Music
                {
                    SongName = "Surround Sound",
                    ArtistName = "JID",
                    Genre = "Rap",
                    Price = 1.99M
                },
                new Music
                {
                    SongName = "NEVER",
                    ArtistName = "JID",
                    Genre = "Rap",
                    Price = 1.59M
                }
            );
            context.SaveChanges();
        }
    }
}
