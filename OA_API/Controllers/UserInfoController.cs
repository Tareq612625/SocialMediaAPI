using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA_DataAccess;
using OA_Repository;
using OA_Service;

namespace OA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        private readonly IUserService _UserService;
        public UserInfoController(IUserService UserService)
        {
            _UserService = UserService;
        }

        [HttpGet(nameof(GetUserById))]
        public IActionResult GetUserById(string Id)
        {
            var obj = _UserService.GetById(Id);
            if (obj == null)
            {
                return  NotFound();
            }
            else
            {
                return  Ok(obj);
            }
        }
        [HttpGet(nameof(GetAllUser))]
        public IActionResult GetAllUser()
        {
            var obj = _UserService.GetAll();
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }
        [HttpPost(nameof(CreateUser))]
        public IActionResult CreateUser(UserInfo UserInfo)
        {
            if (UserInfo != null)
            {
                _UserService.Insert(UserInfo);
                return Ok("Created Successfully");
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }
        }
        [HttpPut(nameof(UpdateUser))]
        public IActionResult UpdateUser(UserInfo UserInfo)
        {
            if (UserInfo != null)
            {
                _UserService.Update(UserInfo);
                return Ok("Update Successfully");
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }
        }
        [HttpDelete(nameof(CreateUser))]
        public IActionResult DeleteUser(UserInfo UserInfo)
        {
            if (UserInfo != null)
            {
                _UserService.Delete(UserInfo);
                return Ok("Remove Successfully");
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }
        }
    }
}
