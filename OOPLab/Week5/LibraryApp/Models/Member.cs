namespace LibraryApp.Models;

public class Member(int ıd, string? name = null)
{
    public int Id { get; set; } = ıd;
    public string? Name { get; set; } = name;

    public void BorrowBook(Book book)
    {
        Console.WriteLine($"{book.Title} adlı kıtap ödünç alındı.");
    }

    public void ReturnBook(Book book)
    {
        Console.WriteLine($"{book.Title} adlı kıtap iade edildi.");
    }
}