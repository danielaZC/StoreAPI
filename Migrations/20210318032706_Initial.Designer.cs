﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductsAPI.Models;

namespace ProductsAPI.Migrations
{
    [DbContext(typeof(ProductsAPIContext))]
    [Migration("20210318032706_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.4");

            modelBuilder.Entity("ProductsAPI.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("varchar(60)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Accessories",
                            Description = "The DualSense wireless controller offers immersive haptic feedback, dynamic adaptive triggers and a built-in microphone.",
                            Name = "Playstation DualSense Wireless Controller"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Accessories",
                            Description = "Experience the modernized design of the Xbox Wireless Controller, featuring sculpted surfaces for enhanced comfort during gameplay.",
                            Name = "Xbox Core Controller - Carbon Black"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Accessories",
                            Description = "Take your game sessions up a notch with the Nintendo Switch Pro Controller. Includes motion controls, HD rumble, built-in amiibo functionality, and more.",
                            Name = "Nintendo Switch Pro Controller"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Games",
                            Description = "Lead epic Viking raids against Saxon troops and fortresses",
                            Name = "Assassin’s Creed Valhalla PlayStation 5"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Games",
                            Description = "Black Ops Cold War will drop fans into the depths of the Cold War’s volatile geopolitical battle of the early 1980s.",
                            Name = "Call of Duty: Black Ops Cold War - Xbox One"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Games",
                            Description = "Hit the road with the definitive version of Mario Kart 8 and play anytime, anywhere!",
                            Name = "Mario Kart 8 Deluxe - Nintendo Switch"
                        },
                        new
                        {
                            Id = 7,
                            Category = "Consoles",
                            Description = "Harness the power of a custom CPU, GPU, and SSD with Integrated I/O that rewrite the rules of what a PlayStation console can do.",
                            Name = "PlayStation 5 Console"
                        },
                        new
                        {
                            Id = 8,
                            Category = "Consoles",
                            Description = "Play with friends and family near and far—sitting together on the sofa or around the world on Xbox Live, the fastest, most reliable gaming network",
                            Name = "Xbox Series S"
                        },
                        new
                        {
                            Id = 9,
                            Category = "Consoles",
                            Description = "Play your way with the Nintendo Switch gaming system. Whether you’re at home or on the go, solo or with friends",
                            Name = "Nintendo Switch – Neon Red and Neon Blue Joy-Con"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}