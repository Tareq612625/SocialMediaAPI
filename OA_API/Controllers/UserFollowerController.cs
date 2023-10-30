using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA_DataAccess;
using OA_Repository;
using OA_Service;

namespace OA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserFollowerController : ControllerBase
    {
        private readonly IUserFollowerService _UserFollowerService;
        public UserFollowerController(IUserFollowerService UserService)
        {
            _UserFollowerService = UserService;
        }

        [HttpGet(nameof(GetUserFollowerById))]
        public IActionResult GetUserFollowerById(string Id)
        {
            var obj = _UserFollowerService.GetById(Id);
            if (obj == null)
            {
                return  NotFound();
            }
            else
            {
                return  Ok(obj);
            }
        }
        [HttpGet(nameof(GetAllUserFollower))]
        public IActionResult GetAllUserFollower()
        {
            var obj = _UserFollowerService.GetAll();
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }
        [HttpPost(nameof(CreateUserFollower))]
        public IActionResult CreateUserFollower(UserFollowers UserFollowers)
        {
            if (UserFollowers != null)
            {
                _UserFollowerService.Insert(UserFollowers);
                return Ok("Created Successfully");
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }
        }
        [HttpPut(nameof(UpdateUserFollower))]
        public IActionResult UpdateUserFollower(UserFollowers UserFollowers)
        {
            if (UserFollowers != null)
            {
                _UserFollowerService.Update(UserFollowers);
                return Ok("Update Successfully");
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }
        }
        [HttpDelete(nameof(CreateUserFollower))]
        public IActionResult DeleteUserFollower(UserFollowers UserFollowers)
        {
            if (UserFollowers != null)
            {
                _UserFollowerService.Delete(UserFollowers);
                return Ok("Remove Successfully");
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }
        }
    }
}
