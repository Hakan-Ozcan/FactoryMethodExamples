using WebApplication1.Interfaces;

namespace WebApplication1.Entities
{
    public class Phone : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string OS { get; set; }
    }
}
