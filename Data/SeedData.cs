using DogAdoptionWebsite.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DogAdoptionWebsite.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new DogAdoptionWebsiteContext(
            serviceProvider.GetRequiredService<
            DbContextOptions<DogAdoptionWebsiteContext>>());

            if (context == null || context.Dog == null)
            {
                throw new NullReferenceException("Null DogAdoptionWebsiteContext or Dog DbSet");
            }

            if (context.Dog.Any())
            {
                return;
            }

            // Add seed data here
            context.Dog.AddRange(
                new Dog
                {
                    Name = "Buddy",
                    Age = 3,
                    Breed = "Golden Retriever",
                    Gender = "Male",
                    Location = "New York",
                    Status = "Available",
                    Description = "A friendly and playful dog",
                    ImageUrl = "/Images/doga.jpeg"
                },
                new Dog
                {
                    Name = "Bella",
                    Age = 2,
                    Breed = "Labrador Retriever",
                    Gender = "Female",
                    Location = "California",
                    Status = "Adopted",
                    Description = "Loves to play and cuddle",
                    ImageUrl = "/Images/dogb.jpeg"
                }

                // Add more dogs...!!!!
            );

            context.SaveChanges();
        }
    } 
}
