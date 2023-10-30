using OA_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Service
{
    public interface IUserPostService
    {
        IEnumerable<UserPost>  GetAll();
        UserPost GetById(string Id);
        void Insert(UserPost entity);
        void Update(UserPost entity);
        void Delete(UserPost entity);
    }
}
