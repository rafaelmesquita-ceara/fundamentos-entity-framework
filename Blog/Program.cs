using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new DataContext();

            var user = new User
            {
                Name = "André Baltieri",
                Slug = "andrebaltieri",
                Email = "andre@balta.io",
                Image = "https://balta.io",
                Bio = "10x Microsoft MVP",
                PasswordHash = "2132121321"
            };

            var category = new Category
            {
                Name = "Backend",
                Slug = "backend"
            };

            var post = new Post
            {
                Author = user,
                Category = category,
                Body = "<p>Hello World</p>",
                Slug = "Neste artigo vamos aprender EF Core",
                Summary = "Sumário",
                Title = "Começando com EF Core",
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
            };

            context?.Posts?.Add(post);
            context?.SaveChanges();
        }
    }
}