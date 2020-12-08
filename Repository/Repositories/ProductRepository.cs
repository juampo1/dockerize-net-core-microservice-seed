using Model.Operation;
using Model.Repositories;
using Dapper;
using System.Data;

namespace Persistence.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(string connectionString) : base(connectionString) { }

        public long CreateProduct(Product product)
        {
            return Query(c =>
            {
                var param = new DynamicParameters(new {
                    Id = (long?)null,
                    Name = product.Name,
                    Quantity = product.Quantity
                });

                var sql = "INSERT INTO PRODUCT(NANE, QUANTITY) VALUES (:Nane, :Quantity)";
                c.Execute(sql, param);

                return param.Get<long>("Id");
            });
        }
    }
}
