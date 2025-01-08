using BlogApp;
using BlogApp.Entities;
using Microsoft.EntityFrameworkCore;

var context = new RepositoryContext();

await context.Contents.ForEachAsync(c => Console.WriteLine(c + "\n"));
var contents = new List<Content>()
{
new (-1,"naber","asdsadsadsasasasadsa"){CategoryId=1,Category= new Category(1,"Oyun")},
new (-1,"COMING SOON","deneme 123123123123123"){CategoryId=2,Category= new Category(2,"Sinema")},
};

await context.Contents.AddRangeAsync(contents);
await context.SaveChangesAsync();
