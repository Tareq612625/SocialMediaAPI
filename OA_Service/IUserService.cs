using OA_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OA_Service
{
    public interface IUserService
    {
        IEnumerable<UserInfo>  GetAll();
        UserInfo GetById(string Id);
        void Insert(UserInfo entity);
        void Update(UserInfo entity);
        void Delete(UserInfo entity);
    }
}
