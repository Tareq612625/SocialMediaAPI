using OA_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Service
{
    public interface IProductService 
    {
        IEnumerable<Product>  GetAll();
        Product GetById(int Id);
        void Insert(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}
