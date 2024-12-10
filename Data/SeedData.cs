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
                    Name = "Luna",
                    Age = 2,
                    Breed = "Labrador Retriever",
                    Gender = "Female",
                    Location = "Los Angeles",
                    Status = "Available",
                    Description = "A loving and energetic companion",
                    ImageUrl = "/Images/dogb.jpeg"
                },
                new Dog
                {
                    Name = "Charlie",
                    Age = 4,
                    Breed = "Beagle",
                    Gender = "Male",
                    Location = "Chicago",
                    Status = "Adopted",
                    Description = "A curious and affectionate friend",
                    ImageUrl = "/Images/dogc.jpeg"
                },
                new Dog
                {
                    Name = "Daisy",
                    Age = 1,
                    Breed = "Shih Tzu",
                    Gender = "Female",
                    Location = "Miami",
                    Status = "Available",
                    Description = "A small but spunky pup",
                    ImageUrl = "/Images/dogd.jpeg"
                },
                new Dog
                {
                    Name = "Max",
                    Age = 5,
                    Breed = "German Shepherd",
                    Gender = "Male",
                    Location = "Houston",
                    Status = "Available",
                    Description = "A loyal and intelligent protector",
                    ImageUrl = "/Images/doge.jpeg"
                },
                new Dog
                {
                    Name = "Bella",
                    Age = 3,
                    Breed = "Bulldog",
                    Gender = "Female",
                    Location = "Phoenix",
                    Status = "Adopted",
                    Description = "A calm and cuddly companion",
                    ImageUrl = "/Images/dogf.jpeg"
                },
                new Dog
                {
                    Name = "Rocky",
                    Age = 2,
                    Breed = "Boxer",
                    Gender = "Male",
                    Location = "Seattle",
                    Status = "Available",
                    Description = "A strong and playful pup",
                    ImageUrl = "/Images/dogg.jpeg"
                },
                new Dog
                {
                    Name = "Molly",
                    Age = 6,
                    Breed = "Poodle",
                    Gender = "Female",
                    Location = "Denver",
                    Status = "Available",
                    Description = "A smart and elegant dog",
                    ImageUrl = "/Images/dogh.jpeg"
                },
                new Dog
                {
                    Name = "Cooper",
                    Age = 1,
                    Breed = "Cocker Spaniel",
                    Gender = "Male",
                    Location = "San Francisco",
                    Status = "Available",
                    Description = "A cheerful and friendly dog",
                    ImageUrl = "/Images/dogi.jpeg"
                },
                new Dog
                {
                    Name = "Ruby",
                    Age = 4,
                    Breed = "Dachshund",
                    Gender = "Female",
                    Location = "Boston",
                    Status = "Available",
                    Description = "A curious and lively pup",
                    ImageUrl = "/Images/dogj.jpeg"
                },
                new Dog
                {
                    Name = "Zoey",
                    Age = 3,
                    Breed = "Siberian Husky",
                    Gender = "Female",
                    Location = "Salt Lake City",
                    Status = "Available",
                    Description = "A spirited and adventurous dog",
                    ImageUrl = "/Images/dogk.jpeg"
                },
                new Dog
                {
                    Name = "Buster",
                    Age = 7,
                    Breed = "Boston Terrier",
                    Gender = "Male",
                    Location = "Austin",
                    Status = "Available",
                    Description = "An easy-going and cheerful companion",
                    ImageUrl = "/Images/dogl.jpeg"
                },
                new Dog
                {
                    Name = "Sadie",
                    Age = 5,
                    Breed = "Chihuahua",
                    Gender = "Female",
                    Location = "Las Vegas",
                    Status = "Adopted",
                    Description = "A small dog with a big personality",
                    ImageUrl = "/Images/dogm.jpeg"
                },
                new Dog
                {
                    Name = "Finn",
                    Age = 2,
                    Breed = "Border Collie",
                    Gender = "Male",
                    Location = "Portland",
                    Status = "Available",
                    Description = "An energetic and highly intelligent dog",
                    ImageUrl = "/Images/dogn.jpeg"
                },
                new Dog
                {
                    Name = "Roxy",
                    Age = 6,
                    Breed = "Cavalier King Charles Spaniel",
                    Gender = "Female",
                    Location = "Orlando",
                    Status = "Available",
                    Description = "A gentle and affectionate companion",
                    ImageUrl = "/Images/dogo.jpeg"
                }


            );

            context.SaveChanges();
        }
    } 
}
