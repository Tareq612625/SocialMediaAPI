using OA_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Service
{
    public interface IUserFollowerService
    {
        IEnumerable<UserFollowers>  GetAll();
        UserFollowers GetById(string Id);
        void Insert(UserFollowers entity);
        void Update(UserFollowers entity);
        void Delete(UserFollowers entity);
    }
}
