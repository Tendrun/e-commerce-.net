namespace Workshop.Api.Features.Product
{
    public class CreateProductRequestDTO
    {
        public string Name { get; set; }
        public double Price {get; set; }
        public int Stock { get; set; }
    }
}
