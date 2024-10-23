namespace LibraryApp.Models;

public class Member(int ıd, string? name = null)
{
    public int Id { get; set; } = ıd;
    public string? Name { get; set; } = name;

    public void BorrowBook(Book book)
    {
        Console.WriteLine($"{book.title} adlı kıtap ödünç alındı.");
    }

    public void ReturnBook(Book book)
    {
        Console.WriteLine($"{book.title} adlı kıtap iade edildi.");
    }
}