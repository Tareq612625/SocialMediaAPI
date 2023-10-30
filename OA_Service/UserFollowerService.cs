using OA_DataAccess;
using OA_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Service
{
    public class UserFollowerService : IUserFollowerService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public UserFollowerService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void Delete(UserFollowers entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _applicationDbContext.UserFollowers.Remove(entity);
            _applicationDbContext.SaveChanges();
        }

        public IEnumerable<UserFollowers> GetAll()
        {
            return _applicationDbContext.UserFollowers.AsEnumerable();
        }

        public UserFollowers GetById(string id)
        {
            return _applicationDbContext.UserFollowers.FirstOrDefault(c => c.Id == id);
        }

        public void Insert(UserFollowers entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _applicationDbContext.UserFollowers.Add(entity);
            _applicationDbContext.SaveChanges();
        }

        public void Remove(UserFollowers entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _applicationDbContext.UserFollowers.Remove(entity);
        }

        public void SaveChanges()
        {
            _applicationDbContext.SaveChanges();
        }

        public void Update(UserFollowers entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _applicationDbContext.UserFollowers.Update(entity);
            _applicationDbContext.SaveChanges();
        }
    }
}
