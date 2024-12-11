using ShoppingApp.Entities;

namespace ShoppingApp;

public static class Extensions
{
    public static string FormatEmail(this Customer c)
    {
        return $"{c.FullName,-10} {c.Email,-10}";
    }
    public static void CalculateTotalPrice(this Order o)
    {
        var totalPrice = o.Products.Sum(p => p.Price);
        o.TotalPrice = totalPrice;
    }

    public static void ApplyDiscount(this Product p, decimal amount)
    {
        p.Price *= (100 - amount) / 100;
    }

    public static List<Product> FilterProductsByPrice(this List<Product> products, decimal minPrice)
    {
        return products.FindAll(p => p.Price >= minPrice);
    }

    public static List<Order> FindCustomerOrders(this GenericRepository<Order> orderRepo, Customer c)
    {
        return orderRepo.GetAll().FindAll(o => o.Customer.Id == c.Id);
    }
}