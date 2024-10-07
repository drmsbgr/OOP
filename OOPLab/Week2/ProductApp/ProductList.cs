namespace ProductApp
{
    class ProductList(string pname, float price, string company)
    {
        private string? _productName = pname;
        private float _price = price;
        private string? _company = company;

        public string ProductName { get { return _productName; } set { _productName = value; } }
        public float Price { get { return _price; } set { _price = value; } }
        public string Company { get { return _company; } set { _company = value; } }

        public override string ToString()
        {
            return $"Ürün:{this.ProductName}\nFiyat:{this.Price}\nMarka:{this.Company}\n";
        }
    }
}