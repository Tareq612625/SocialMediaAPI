using OA_DataAccess;
using OA_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Service
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public UserService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void Delete(UserInfo entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _applicationDbContext.UserInfo.Remove(entity);
            _applicationDbContext.SaveChanges();
        }

        public IEnumerable<UserInfo> GetAll()
        {
            return _applicationDbContext.UserInfo.AsEnumerable();
        }

        public UserInfo GetById(string id)
        {
            return _applicationDbContext.UserInfo.FirstOrDefault(c => c.UserId == id);
        }

        public void Insert(UserInfo entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _applicationDbContext.UserInfo.Add(entity);
            _applicationDbContext.SaveChanges();
        }

        public void Remove(UserInfo entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _applicationDbContext.UserInfo.Remove(entity);
        }

        public void SaveChanges()
        {
            _applicationDbContext.SaveChanges();
        }

        public void Update(UserInfo entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _applicationDbContext.UserInfo.Update(entity);
            _applicationDbContext.SaveChanges();
        }
    }
}
