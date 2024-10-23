namespace LibraryApp.Models;

public abstract class Book(string title, string author)
{
    public string? Title { get; set; } = title;
    public string? Author { get; set; } = author;

    public abstract string GetDescription();
}