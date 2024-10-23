namespace LibraryApp.Models;

public class Fiction(string title, string author, string genre) : Book(title, author)
{
    public string? Genre { get; set; } = genre;

    public override string GetDescription()
    {
        return "";
    }
}