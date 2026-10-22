namespace rest_api.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public DateTime DateAdded { get; set; } = DateTime.Now;
    }
}
