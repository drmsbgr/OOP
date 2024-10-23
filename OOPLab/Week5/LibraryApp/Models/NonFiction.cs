namespace LibraryApp.Models;

public class NonFiction(string title, string author, string subject) : Book(title, author)
{
    public string? Subject { get; set; } = subject;

    public override string GetDescription()
    {
        return $"{Title} - {Author} - {Subject}";
    }
}