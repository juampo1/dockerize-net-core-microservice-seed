using Model.Operation;
using Model.Repositories;

namespace Model.Services
{
    public class ProductService : IProductService
    {
        private readonly IRepositoryFactory _repositoryFactory;
        public ProductService(IRepositoryFactory repositoryFactory)
        {
            _repositoryFactory = repositoryFactory;
        }

        public long CreateProduct(Product product)
        {
            //All the validation logic goes here before calling the repo instance that will only connect to the database
            var repo = _repositoryFactory.CreateProductRepository();

            return repo.CreateProduct(product);
        }
    }
}
