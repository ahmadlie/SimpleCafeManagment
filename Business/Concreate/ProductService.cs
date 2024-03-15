using Business.Abstract;
using DataAccess.Entities;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concreate
{
    public class ProductService : BaseService<ProductDTO,Product> , IProductService
    {
        
    }
}
