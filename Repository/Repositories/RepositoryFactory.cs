using Microsoft.Extensions.Configuration;
using Model.Repositories;

namespace Persistence.Repositories
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly string _connectionString;

        public RepositoryFactory(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public IProductRepository CreateProductRepository()
        {
            return new ProductRepository(_connectionString);
        }
    }
}
