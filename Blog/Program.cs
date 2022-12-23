using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DataContext())
            {
                //Create(context);
                //Update(context);
                Read(context);
            }
        }

        static void Create(DataContext context)
        {
            var tag = new Tag { Name = "ASP.NET", Slug = "aspnet" };
            context?.Tags?.Add(tag);
            context?.SaveChanges();
        }
        static void Update(DataContext context)
        {
            var tag = context?.Tags?.FirstOrDefault(x => x.Id == 3);
            if (tag is not null)
            {
                tag.Name = ".NET";
                tag.Slug = "dotnet";
                context?.Tags?.Update(tag);
                context?.SaveChanges();
            }
        }
        static void Delete(DataContext context)
        {
            var tag = context?.Tags?.FirstOrDefault(x => x.Id == 3);
            if (tag is not null)
            {
                context?.Tags?.Remove(tag);
                context?.SaveChanges();
            }
        }
        static void Read(DataContext context)
        {
            var tags = context?.Tags?.AsNoTracking().ToList();
            if (tags is not null)
            {
                foreach (var tag in tags)
                {
                    Console.WriteLine(tag.Name);
                }
            }
        }
    }
}