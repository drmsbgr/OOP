namespace LibraryApp.Models;

public class Librarian(int ıd)
{
    public int Id { get; set; } = ıd;

    public void AddBook(Book book)
    {
        Console.WriteLine($"{book.author} adlı kişinin yazdığı {book.title} adlı kitap kütüphaneye eklendi.");
    }

    public void RemoveBook(Book book)
    {
        Console.WriteLine($"{book.author} adlı kişinin yazdığı {book.title} adlı kitap kütüphaneden çıkarıldı.");
    }
}