namespace Workshop.Api.Features.Product
{
    public class ProductResponseDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int stock { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
