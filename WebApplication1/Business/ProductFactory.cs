using WebApplication1.Entities;
using WebApplication1.Interfaces;

namespace WebApplication1.Business
{
    public class ProductFactory
    {


        public IProduct CreateProduct(ProductType type)
        {
            switch (type)
            {
                case ProductType.Phone:
                    return new Phone();
                case ProductType.Laptop:
                    return new Laptop();
                case ProductType.Book:
                    return new Book();
                default:
                    throw new ArgumentException("Geçersiz ürün türü.");
            }
        }
    }
}
