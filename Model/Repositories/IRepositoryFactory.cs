using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Repositories
{
    public interface IRepositoryFactory
    {
        IProductRepository CreateProductRepository();
    }
}
