using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProductsAPI.Models
{
    public class ProductsAPIContext : DbContext
    {
        public ProductsAPIContext(DbContextOptions<ProductsAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ProductsAPI.Models.Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>(product => { product.Property(p => p.Id).IsRequired(); });

            #region ProductsSeed
            modelBuilder.Entity<Products>().HasData(new Products
            {
                Id = 1,
                Name = "Playstation DualSense Wireless Controller",
                Description = "The DualSense wireless controller offers immersive haptic feedback, dynamic adaptive triggers and a built-in microphone.",
                Category = "Accessories"
            },
            new Products
            {
                Id = 2,
                Name = "Xbox Core Controller - Carbon Black",
                Description = "Experience the modernized design of the Xbox Wireless Controller, featuring sculpted surfaces for enhanced comfort during gameplay.",
                Category = "Accessories"
            },
            new Products
            {
                Id = 3,
                Name = "Nintendo Switch Pro Controller",
                Description = "Take your game sessions up a notch with the Nintendo Switch Pro Controller. Includes motion controls, HD rumble, built-in amiibo functionality, and more.",
                Category = "Accessories"
            },
             new Products
             {
                 Id = 4,
                 Name = "Assassin’s Creed Valhalla PlayStation 5",
                 Description = "Lead epic Viking raids against Saxon troops and fortresses",
                 Category = "Games"
             },
              new Products
              {
                  Id = 5,
                  Name = "Call of Duty: Black Ops Cold War - Xbox One",
                  Description = "Black Ops Cold War will drop fans into the depths of the Cold War’s volatile geopolitical battle of the early 1980s.",
                  Category = "Games"
              },
               new Products
               {
                   Id = 6,
                   Name = "Mario Kart 8 Deluxe - Nintendo Switch",
                   Description = "Hit the road with the definitive version of Mario Kart 8 and play anytime, anywhere!",
                   Category = "Games"
               },
                new Products
                {
                    Id = 7,
                    Name = "PlayStation 5 Console",
                    Description = "Harness the power of a custom CPU, GPU, and SSD with Integrated I/O that rewrite the rules of what a PlayStation console can do.",
                    Category = "Consoles"
                },
                new Products
                {
                    Id = 8,
                    Name = "Xbox Series S",
                    Description = "Play with friends and family near and far—sitting together on the sofa or around the world on Xbox Live, the fastest, most reliable gaming network",
                    Category = "Consoles"
                },
                new Products
                {
                    Id = 9,
                    Name = "Nintendo Switch – Neon Red and Neon Blue Joy-Con",
                    Description = "Play your way with the Nintendo Switch gaming system. Whether you’re at home or on the go, solo or with friends",
                    Category = "Consoles"
                }
            );
            #endregion
        }
    }
}
