// See https://aka.ms/new-console-template for more information
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Aplicação BIO");

using (var context = new DataContext())
{
    var tag = new Tag { Name = "ASP.NET", Slug = "asp-net" };
    context.Tags.Add(tag);


    context.SaveChanges();
    Console.WriteLine("Os dados foram salvos!");
};




