// See https://aka.ms/new-console-template for more information
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System.Windows;

Console.WriteLine("Aplicação BIO");

using (var context = new DataContext())
{
    // //Create
    // var tag = new Tag { Name = "ASP.NET", Slug = "asp-net" };
    // context.Tags.Add(tag);
    // context.SaveChanges();
    // Console.WriteLine("Os dados foram salvos!");



    // //Update
    // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
    // tag.Name = "ASP.NET Core";
    // tag.Slug = "dotnet";

    // context.Update(tag);
    // context.SaveChanges();

    // //Delete
    // var tag = context.Tags.FirstOrDefault(x => x.Id == 2);

    // context.Remove(tag);
    // context.SaveChanges();
    // System.Console.WriteLine("Os dados foram removidos!");

    // List
    // var tags = context
    //     .Tags
    //     .AsNoTracking()
    //     .ToList();

    // foreach (var tag in tags)
    // {
    //     Console.WriteLine(tag.Name);
    // }

    var tag = context
        .Tags
        .AsNoTracking()
        .FirstOrDefault(x => x.Id == 5);

    System.Console.WriteLine(tag?.Name);
};




