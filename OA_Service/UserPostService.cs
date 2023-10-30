using OA_DataAccess;
using OA_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Service
{
    public class UserPostService : IUserPostService
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public UserPostService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void Delete(UserPost entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _applicationDbContext.UserPost.Remove(entity);
            _applicationDbContext.SaveChanges();
        }

        public IEnumerable<UserPost> GetAll()
        {
            return _applicationDbContext.UserPost.AsEnumerable();
        }

        public UserPost GetById(string id)
        {
            return _applicationDbContext.UserPost.FirstOrDefault(c => c.PostId == id);
        }

        public void Insert(UserPost entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _applicationDbContext.UserPost.Add(entity);
            _applicationDbContext.SaveChanges();
        }

        public void Remove(UserPost entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _applicationDbContext.UserPost.Remove(entity);
        }

        public void SaveChanges()
        {
            _applicationDbContext.SaveChanges();
        }

        public void Update(UserPost entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            _applicationDbContext.UserPost.Update(entity);
            _applicationDbContext.SaveChanges();
        }
    }
}
