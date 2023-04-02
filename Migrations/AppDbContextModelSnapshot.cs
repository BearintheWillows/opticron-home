﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using optricon_home.Data;

#nullable disable

namespace optricon_home.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("optricon_home.Models.MediaObjects", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ButtonText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageAlt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MediaObjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ButtonText = "New Products",
                            ImageAlt = "Bird catching fish from River",
                            ImagePath = "/images/Bird.png",
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, nunc ut aliquam aliquam, nunc nisl aliquet nisl, eget aliquam nisl nisl sit amet lorem.",
                            Title = "New Products"
                        },
                        new
                        {
                            Id = 2,
                            ButtonText = "View Events",
                            ImageAlt = "Group of Photographers with Long-lens",
                            ImagePath = "/images/Photographers.png",
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, nunc ut aliquam aliquam, nunc nisl aliquet nisl, eget aliquam nisl nisl sit amet lorem.",
                            Title = "Field Events"
                        },
                        new
                        {
                            Id = 3,
                            ButtonText = "Read Article",
                            ImageAlt = "Landscape with Mountains",
                            ImagePath = "/images/Landscape.png",
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, nunc ut aliquam aliquam, nunc nisl aliquet nisl, eget aliquam nisl nisl sit amet lorem.",
                            Title = "Latest News"
                        },
                        new
                        {
                            Id = 4,
                            ButtonText = "View Gallery",
                            ImageAlt = "Bird in tree",
                            ImagePath = "/images/Bird.png",
                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed euismod, nunc ut aliquam aliquam, nunc nisl aliquet nisl, eget aliquam nisl nisl sit amet lorem.",
                            Title = "Gallery"
                        });
                });

            modelBuilder.Entity("optricon_home.Models.ProductCategories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageAlt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryTitle = "Binoculars",
                            ImageAlt = "Binocula 1",
                            ImagePath = "/images/Binocula_1.png"
                        },
                        new
                        {
                            Id = 2,
                            CategoryTitle = "Compact Binoculars",
                            ImageAlt = "Binocula 2",
                            ImagePath = "/images/Binocula_2.png"
                        },
                        new
                        {
                            Id = 3,
                            CategoryTitle = "Telescopes & Eyepieces",
                            ImageAlt = "Binocula 3",
                            ImagePath = "/images/Binocula_3.png"
                        },
                        new
                        {
                            Id = 4,
                            CategoryTitle = "Observation & Marine",
                            ImageAlt = "Binocula 4",
                            ImagePath = "/images/Binocula_4.png"
                        },
                        new
                        {
                            Id = 5,
                            CategoryTitle = "Binoculars",
                            ImageAlt = "Binocula 1",
                            ImagePath = "/images/Binocula_1.png"
                        },
                        new
                        {
                            Id = 6,
                            CategoryTitle = "Compact Binoculars",
                            ImageAlt = "Binocula 2",
                            ImagePath = "/images/Binocula_2.png"
                        },
                        new
                        {
                            Id = 7,
                            CategoryTitle = "Telescopes & Eyepieces",
                            ImageAlt = "Binocula 3",
                            ImagePath = "/images/Binocula_3.png"
                        },
                        new
                        {
                            Id = 8,
                            CategoryTitle = "Observation & Marine",
                            ImageAlt = "Binocula 4",
                            ImagePath = "/images/Binocula_4.png"
                        });
                });

            modelBuilder.Entity("optricon_home.Models.SpecialOffers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ImageAlt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SpecialOffers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImageAlt = "Money",
                            ImagePath = "/images/Money.png",
                            ItemText = "£20 Cashback",
                            ItemTitle = "Discovery WP PC"
                        },
                        new
                        {
                            Id = 2,
                            ImageAlt = "Olympus Camera",
                            ImagePath = "/images/Olympus.png",
                            ItemText = "Free Digiscoping Kit",
                            ItemTitle = "HR ED Fieldscopes"
                        },
                        new
                        {
                            Id = 3,
                            ImageAlt = "Otricon Camera",
                            ImagePath = "/images/Otricon_Cam.png",
                            ItemText = "Save 25%",
                            ItemTitle = "IS 60 WP FieldScope Kits"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
