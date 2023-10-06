using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ZipperMate.Data; // Adjust the namespace to match your project's structure
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
                // Look for any data in your context.
                if (context.Zippers.Any())
                {
                    return;   // Data has been seeded
                }

                context.Zippers.AddRange(
                new Zippers
                {
                    Name = "Sample Test 1",
                    Material = "Sample Material 1",
                    Use = "Sample Use 1",
                    Durabilty = "Sample Durabilty 1",
                    Price = 19.99M,
                    Colours = "Sample Colour 1"
                },
                new Zippers
                {
                    Name = "Sample Test 2",
                    Material = "Sample Material 2",
                    Use = "Sample Use 2",
                    Durabilty = "Sample Durabilty 2",
                    Price = 24.99M,
                    Colours = "Sample Colour 2"
                },
                new Zippers
                {
                    Name = "Sample Test 3",
                    Material = "Sample Material 3",
                    Use = "Sample Use 3",
                    Durabilty = "Sample Durabilty 3",
                    Price = 14.99M,
                    Colours = "Sample Colour 3"
                }
            );

                context.SaveChanges();
            }
        }
    }
}
