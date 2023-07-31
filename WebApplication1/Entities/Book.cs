using WebApplication1.Interfaces;

namespace WebApplication1.Entities
{
    public class Book : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }
    }
}
