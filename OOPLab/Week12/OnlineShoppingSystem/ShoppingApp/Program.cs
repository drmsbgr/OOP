using ShoppingApp;
using ShoppingApp.Entities;

var customerRepo = new GenericRepository<Customer>();
var productRepo = new GenericRepository<Product>();
var orderRepo = new GenericRepository<Order>();

var customer1 = customerRepo.Add(new Customer(1, "Ali Yılmaz", "ali@gmail.com"));
var customer2 = customerRepo.Add(new Customer(2, "Mustafa Haktan", "mhaktan@gmail.com"));
var customer3 = customerRepo.Add(new Customer(3, "Osman Gültekin", "osmangultekin@gmail.com"));

var product1 = productRepo.Add(new Product(1, "Telefon", 13000));
var product2 = productRepo.Add(new Product(2, "TV", 32000));
var product3 = productRepo.Add(new Product(3, "Buzdolabı", 24000));
var product4 = productRepo.Add(new Product(4, "Tost Makinesi", 3000));
var product5 = productRepo.Add(new Product(5, "Tablet", 16000));
var product6 = productRepo.Add(new Product(6, "Laptop", 42000));

productRepo.Remove(product6);

var order1 = orderRepo.Add(new Order()
{
    Id = 1,
    Customer = customer1,
    Products = [product1, product2]
});

var order2 = orderRepo.Add(new Order()
{
    Id = 2,
    Customer = customer1,
    Products = [product3, product4, product5]
});

customer1.Email = customer1.FormatEmail();
customer2.Email = customer2.FormatEmail();
customer3.Email = customer3.FormatEmail();

order1.Products.ForEach(p => p.ApplyDiscount(10));

order1.CalculateTotalPrice();
order2.CalculateTotalPrice();

var total = order1.TotalPrice + order2.TotalPrice;

Console.WriteLine("18000 TL ve üzeri ürünler");
productRepo.GetAll().FilterProductsByPrice(18000).ForEach(p => Console.WriteLine(p));
System.Console.WriteLine();
Console.WriteLine($"{customer1.FullName} 'e ait siparişler");
orderRepo.FindCustomerOrders(customer1).ForEach(o => Console.WriteLine(o));