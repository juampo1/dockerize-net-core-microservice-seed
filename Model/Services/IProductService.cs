using Model.Operation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Services
{
    public interface IProductService
    {
        long CreateProduct(Product product);
    }
}
