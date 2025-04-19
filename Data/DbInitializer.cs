using BookStore.Models;

namespace BookStore.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            // Check if database has any categories
            if (context.Categories.Any())
            {
                return; // DB has been seeded
            }

            var categories = new Category[]
            {
                new Category { Name = "Fiction" },
                new Category { Name = "Science Fiction" },
                new Category { Name = "Mystery" },
                new Category { Name = "Romance" },
                new Category { Name = "Biography" }
            };

            context.Categories.AddRange(categories);
            context.SaveChanges();

            var books = new Book[]
            {
                new Book
                {
                    Title = "The Great Gatsby",
                    Description = "A story of the fabulously wealthy Jay Gatsby and his love for the beautiful Daisy Buchanan.",
                    Author = "F. Scott Fitzgerald",
                    Price = 12.99m,
                    ViewCount = 0,
                    Created = DateTime.Now,
                    CategoryId = categories[0].Id // Fiction
                },
                new Book
                {
                    Title = "Dune",
                    Description = "A science fiction novel about the son of a noble family entrusted with the protection of the most valuable asset in the galaxy.",
                    Author = "Frank Herbert",
                    Price = 15.99m,
                    ViewCount = 0,
                    Created = DateTime.Now,
                    CategoryId = categories[1].Id // Science Fiction
                },
                new Book
                {
                    Title = "The Girl with the Dragon Tattoo",
                    Description = "A journalist and a young computer hacker investigate a 40-year-old disappearance.",
                    Author = "Stieg Larsson",
                    Price = 14.99m,
                    ViewCount = 0,
                    Created = DateTime.Now,
                    CategoryId = categories[2].Id // Mystery
                },
                new Book
                {
                    Title = "Pride and Prejudice",
                    Description = "A romantic novel of manners that follows the emotional development of Elizabeth Bennet.",
                    Author = "Jane Austen",
                    Price = 11.99m,
                    ViewCount = 0,
                    Created = DateTime.Now,
                    CategoryId = categories[3].Id // Romance
                },
                new Book
                {
                    Title = "Steve Jobs",
                    Description = "The authorized biography of Apple co-founder Steve Jobs.",
                    Author = "Walter Isaacson",
                    Price = 16.99m,
                    ViewCount = 0,
                    Created = DateTime.Now,
                    CategoryId = categories[4].Id // Biography
                }
            };

            context.Books.AddRange(books);
            context.SaveChanges();
        }
    }
} 