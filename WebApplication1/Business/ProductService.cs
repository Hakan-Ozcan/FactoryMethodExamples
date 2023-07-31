using WebApplication1.Entities;
using WebApplication1.Interfaces;

namespace WebApplication1.Business
{
    public class ProductService
    {
        private readonly ProductFactory _productFactory;

        public ProductService(ProductFactory productFactory)
        {
            _productFactory = productFactory;
        }

        public IProduct CreateProduct(ProductType type, int id, string name, decimal price)
        {
            IProduct product = _productFactory.CreateProduct(type);
            product.Id = id;
            product.Name = name;
            product.Price = price;
            return product;
        }
    }
}
