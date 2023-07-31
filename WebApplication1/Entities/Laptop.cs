using WebApplication1.Interfaces;

namespace WebApplication1.Entities
{
    public class Laptop : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Processor { get; set; }
    }
}
