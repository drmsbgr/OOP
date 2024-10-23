namespace LibraryApp.Models;

public abstract class Book(string title, string author)
{
    public string? title = title;
    public string? author = author;

    public abstract string GetDescription();
}