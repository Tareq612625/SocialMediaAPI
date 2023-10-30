using OA_DataAccess;
using OA_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Service
{
    public class ProductService : IProductService
    {
        private  IRepository<Product> _repository;
        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public void Delete(Product entity)
        {
            try
            {
                if (entity != null)
                {
                    _repository.Delete(entity);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Product> GetAll()
        {
            try
            {
                var obj = _repository.GetAll();
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return new List<Product>();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Product GetById(int Id)
        {
            try
            {
                var obj = _repository.GetById(Id);
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return new Product();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Insert(Product entity)
        {
            try {
                if (entity != null)
                {
                    _repository.Insert(entity);
                }
            }
            catch (Exception ex) { 
                throw ex;
            }
        }
        public void Update(Product entity)
        {
            try
            {
                if (entity != null)
                {
                    _repository.Update(entity);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
