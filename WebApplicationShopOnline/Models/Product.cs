namespace WebApplicationShopOnline.Models
{
    public class Product
    {
        static int IDCount = 0;
        public string Name { get; }
        public string Description { get; }
        public int ProductId { get; }
        public decimal Price { get; }
        public Product(string name, string description, decimal price)
        {
            ProductId = IDCount;
            Name = name;
            Description = description;
            Price = price;
            IDCount++;
        }
        public override string ToString()
        {
            return $"{ProductId}\n{Name}\n{Description}\n{Price}";
        }
    }
}
