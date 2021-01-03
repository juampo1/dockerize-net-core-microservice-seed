using Microsoft.Extensions.Configuration;
using Model.Repositories;

namespace Persistence.Repositories
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly string _connectionString;
        private dynamic a;

        public RepositoryFactory(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
            a = configuration;
        }

        public IProductRepository CreateProductRepository()
        {
            return new ProductRepository(_connectionString);
        }
    }
}
