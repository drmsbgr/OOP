using EFCoreConsoleApp;
using EFCoreConsoleApp.Entities;

var context = new AppDbContext();

Console.WriteLine("İşlem seçin\n1->Ürünleri Listele\n2->Ürün Ekle\n3->Ürün Güncelle\n4->Ürün Sil\n5->Stoğa göre filtrele\n6->Fiyata göre filtrele\n7->Çık");
Console.Write("\n->");
string input = Console.ReadLine();

while (true)
{
    switch (input)
    {
        case "1":
            PrintProducts(context.Products);
            break;
        case "2":
            AddProduct(context);
            break;
        case "3":
            UpdateProduct(context);
            break;
        case "4":
            DeleteProduct(context);
            break;
        case "5":
            Console.Write("Minimum stok sayısını girin\n->");
            int minStock = Convert.ToInt32(Console.ReadLine());
            ListProductsByMinStock(context, minStock);
            break;
        case "6":
            Console.Write("Minimum fiyatı girin\n->");
            decimal minPrice = Convert.ToInt32(Console.ReadLine());
            ListProductsByPrice(context, minPrice);
            break;
    }

    if (input == "7") break;
    Console.WriteLine("Devam etmek için herhangi bir tuşa basın");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("İşlem seçin\n1->Ürünleri Listele\n2->Ürün Ekle\n3->Ürün Güncelle\n4->Ürün Sil\n5->Stoğa göre filtrele\n6->Fiyata göre filtrele\n7->Çık");
    Console.Write("\n->");
    input = Console.ReadLine();
}

static void PrintProducts(IEnumerable<Product> collection)
{
    foreach (var item in collection)
    {
        System.Console.WriteLine("-------------");
        Console.WriteLine($"ID:{item.Id,-5}\nNAME:{item.Name,-5} PRICE:{item.Price,-5} STOCK:{item.Stock,-5}");
        System.Console.WriteLine("-------------");
    }
}

static void ListProductsByMinStock(AppDbContext context, int minStock)
{
    var products = context.Products.Where(p => p.Stock >= minStock);
    PrintProducts(products);
}

static void ListProductsByPrice(AppDbContext context, decimal minPrice)
{
    var products = context.Products.Where(p => p.Price >= minPrice);
    PrintProducts(products);
}

static void AddProduct(AppDbContext context)
{
    Console.Write("Ürün adı\n->");
    string pName = Console.ReadLine();
    Console.Write("Ürün Fiyat\n->");
    decimal pPrice = Convert.ToDecimal(Console.ReadLine());
    Console.Write("Ürün Stok Adedi\n->");
    int pStock = Convert.ToInt32(Console.ReadLine());
    context.Products.Add(new Product() { Name = pName, Price = pPrice, Stock = pStock });
    context.SaveChanges();
}

static void UpdateProduct(AppDbContext context)
{
    PrintProducts(context.Products);
    Console.Write("Ürün idsini seçin\n->");
    int id = Convert.ToInt32(Console.ReadLine());
    Console.Write("Yeni Ürün adı\n->");
    string pName = Console.ReadLine();
    Console.Write("Yeni Ürün Fiyat\n->");
    decimal pPrice = Convert.ToDecimal(Console.ReadLine());
    Console.Write("Yeni Ürün Stok Adedi\n->");
    int pStock = Convert.ToInt32(Console.ReadLine());
    var founded = context.Products.Where(p => p.Id == id).First();
    founded.Name = pName;
    founded.Price = pPrice;
    founded.Stock = pStock;
    context.SaveChanges();
}

static void DeleteProduct(AppDbContext context)
{
    PrintProducts(context.Products);
    Console.Write("Ürün idsini seçin\n->");
    int id = Convert.ToInt32(Console.ReadLine());
    context.Products.Remove(context.Products.Find(id));
    context.SaveChanges();
}