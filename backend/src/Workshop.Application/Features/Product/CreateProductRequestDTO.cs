namespace Workshop.Application.Features.Product
{
    public class CreateProductRequestDTO
    {
        public string Name { get; set; }
        public decimal Price {get; set; }
        public int Stock { get; set; }
    }
}
