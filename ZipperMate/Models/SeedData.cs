using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ZipperMate.Data; 
using System;
using System.Linq;

namespace ZipperMate.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ZipperMateContext(
                serviceProvider.GetRequiredService<DbContextOptions<ZipperMateContext>>()))
            {
                
                if (context.Zippers.Any())
                {
                    return;  
                }

                context.Zippers.AddRange(
                    new Zippers
                    {
                        Name = "Waterproof Nylon Zipper",
                        Material = "Waterproof Nylon",
                        Use = "Raincoats and Outdoor Gear",
                        Durabilty = "High Water Resistance",
                        Price = 29.99M,
                        Colours = "Various Colors",
                        Review = 4
                    },
                    new Zippers
                    {
                        Name = "Closed-End Plastic Zipper",
                        Material = "Plastic",
                        Use = "Pants and Skirts",
                        Durabilty = "Everyday Wear",
                        Price = 12.99M,
                        Colours = "Basic Colors",
                        Review = 5
                    },
                    new Zippers
                    {
                        Name = "Coil Zipper for Sportswear",
                        Material = "Plastic Coil",
                        Use = "Sportswear and Backpacks",
                        Durabilty = "Flexible and Lightweight",
                        Price = 9.99M,
                        Colours = "Assorted Colors",
                        Review = 4
                    },
                    new Zippers
                    {
                        Name = "Fashionable Nylon Zipper",
                        Material = "Nylon",
                        Use = "Casual Clothing and Accessories",
                        Durabilty = "Lightweight and Colorful",
                        Price = 7.99M,
                        Colours = "Various Vibrant Colors",
                        Review = 4
                    },
                    new Zippers
                    {
                        Name = "Heavy-Duty Metal Zipper",
                        Material = "Metal Teeth",
                        Use = "Jeans and Heavy-Duty Clothing",
                        Durabilty = "Durable and Sturdy",
                        Price = 16.99M,
                        Colours = "Metallic Finishes",
                        Review = 5
                    },
                    new Zippers
                    {
                        Name = "Invisible Zipper for Dresses",
                        Material = "Plastic",
                        Use = "Dresses and Formal Wear",
                        Durabilty = "Seamless Appearance",
                        Price = 14.99M,
                        Colours = "Concealed Zipper",
                        Review = 3
                    },
                    new Zippers
                    {
                        Name = "Decorative Zipper with Patterns",
                        Material = "Plastic",
                        Use = "Fashion Accessories",
                        Durabilty = "Unique Pattern Options",
                        Price = 8.99M,
                        Colours = "Patterned Designs",
                        Review = 2
                    },
                    new Zippers
                    {
                        Name = "Double-Sided Two-Way Zipper",
                        Material = "Nylon",
                        Use = "Jackets and Sleeping Bags",
                        Durabilty = "Dual Opening",
                        Price = 18.99M,
                        Colours = "Double-Sided Design",
                        Review = 4
                    },
                    new Zippers
                    {
                        Name = "Luggage Zipper for Travel",
                        Material = "Plastic",
                        Use = "Suitcases and Travel Bags",
                        Durabilty = "Travel-Ready",
                        Price = 11.99M,
                        Colours = "Durable Travel Zippers",
                        Review = 5
                    },
                    new Zippers
                    {
                        Name = "Fire-Resistant Zipper",
                        Material = "Fire-Resistant Material",
                        Use = "Protective Clothing and Gear",
                        Durabilty = "Safety First",
                        Price = 22.99M,
                        Colours = "Safety Colors",
                        Review = 4
                    }
                );


                context.SaveChanges();
            }
        }
    }
}
