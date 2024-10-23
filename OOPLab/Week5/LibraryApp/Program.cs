using LibraryApp.Models;

Fiction fic1 = new("Ben Kimim", "Osman Gültekin", "Bılım kurgu");
Fiction fic2 = new("O Kim", "Osman Gültekin", "Polısıye");
NonFiction nfic1 = new("Selanık göcmenlerı", "Aykut Elmas", "Tarıhı");
NonFiction nfic2 = new("Ormanda Bır Kulube", "Aykut Elmas", "Cınayet");

Member member = new(1, "Buğra Durmuş");
Librarian lib = new(1);

lib.AddBook(fic1);
lib.AddBook(fic2);
lib.AddBook(nfic1);
lib.AddBook(nfic2);

member.BorrowBook(nfic2);
lib.RemoveBook(nfic2);

member.ReturnBook(nfic2);
lib.AddBook(nfic2);

