using Model.Operation;

namespace Model.Repositories
{
    public interface IProductRepository
    {
        long CreateProduct(Product product);
    }
}
