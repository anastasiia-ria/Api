﻿// <auto-generated />
using AnimalShelter.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AnimalShelter.Migrations
{
    [DbContext(typeof(AnimalShelterContext))]
    [Migration("20220401183856_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AnimalShelter.Models.Animal", b =>
                {
                    b.Property<int>("AnimalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Breed")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Color")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Image")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Sex")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Species")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("AnimalId");

                    b.ToTable("Animals");

                    b.HasData(
                        new
                        {
                            AnimalId = 1,
                            Age = 9,
                            Breed = "Domestic Longhair",
                            Color = "Orange",
                            Image = "https://www.ccspca.com/wp-content/uploads/2014/01/William.jpg",
                            Name = "Bella",
                            Sex = "Female",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 2,
                            Age = 8,
                            Breed = "Domestic Medium Hair",
                            Color = "Black",
                            Image = "https://www.rover.com/blog/wp-content/uploads/2019/12/108164429_s.jpg",
                            Name = "Max",
                            Sex = "Male",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 3,
                            Age = 5,
                            Breed = "Domestic Longhair",
                            Color = "Grey",
                            Image = "https://www.mycatsite.com/images/Grey-British_Longhair_by-StuBramley.jpg",
                            Name = "Luna",
                            Sex = "Female",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 4,
                            Age = 6,
                            Breed = "Domestic Short Hair",
                            Color = "White",
                            Image = "https://www.hepper.com/wp-content/uploads/2021/08/white-american-shorthair_Oleksandr-Volchanskyi_Shutterstock.jpg",
                            Name = "Charlie",
                            Sex = "Male",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 5,
                            Age = 1,
                            Breed = "Chihuahua",
                            Color = "Orange",
                            Image = "https://www.thesprucepets.com/thmb/Kh-xt27-hqeQzhyr9288cl_P64I=/1396x1396/smart/filters:no_upscale()/twenty20_f84c633e-705e-4bf8-a724-00cdea750d8d-590b51893df78c92837b18d6.jpg",
                            Name = "Lucy",
                            Sex = "Female",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 6,
                            Age = 4,
                            Breed = "Domestic Short Hair",
                            Color = "Black",
                            Image = "https://images.fineartamerica.com/images/artworkimages/mediumlarge/1/1-portrait-of-a-black-shorthair-cat-the-cat-looks-at-the-camera-with-a-stern-look-aleksandr-tannagashev.jpg",
                            Name = "Milo",
                            Sex = "Male",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 7,
                            Age = 3,
                            Breed = "French Bulldog",
                            Color = "White",
                            Image = "https://petskb.com/wp-content/uploads/2021/10/White-French-Bulldog-seated.jpg.webp",
                            Name = "Daizy",
                            Sex = "Female",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 8,
                            Age = 2,
                            Breed = "Domestic Short Hair",
                            Color = "Orange",
                            Image = "https://allaboutcats.com/wp-content/uploads/2018/08/orange-tabby.jpg",
                            Name = "Leo",
                            Sex = "Male",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 9,
                            Age = 10,
                            Breed = "Shepherd",
                            Color = "Grey",
                            Image = "https://thehappypuppysite.com/wp-content/uploads/2018/12/silver-german-shepherd-long.jpg",
                            Name = "Zoe",
                            Sex = "Female",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 10,
                            Age = 5,
                            Breed = "Hound",
                            Color = "Orange",
                            Image = "https://nationalpurebreddogday.com/wp-content/uploads/2019/10/330.jpeg",
                            Name = "Teddy",
                            Sex = "Male",
                            Species = "Dog"
                        },
                        new
                        {
                            AnimalId = 11,
                            Age = 4,
                            Breed = "Domestic Medium Hair",
                            Color = "Brown",
                            Image = "https://i.pinimg.com/originals/07/5e/05/075e05a9ed1d3d225ced3b19e8b8ee00.jpg",
                            Name = "Molly",
                            Sex = "Female",
                            Species = "Cat"
                        },
                        new
                        {
                            AnimalId = 12,
                            Age = 3,
                            Breed = "Chihuahua",
                            Color = "Black",
                            Image = "https://www.dogster.com/wp-content/uploads/2015/05/shutterstock_1741426311.jpg",
                            Name = "Ollie",
                            Sex = "Male",
                            Species = "Dog"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
