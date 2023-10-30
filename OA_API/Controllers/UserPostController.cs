using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA_DataAccess;
using OA_Repository;
using OA_Service;

namespace OA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPostController : ControllerBase
    {
        private readonly IUserPostService _UserPostService;
        public UserPostController(IUserPostService UserService)
        {
            _UserPostService = UserService;
        }

        [HttpGet(nameof(GetUserPostById))]
        public IActionResult GetUserPostById(string Id)
        {
            var obj = _UserPostService.GetById(Id);
            if (obj == null)
            {
                return  NotFound();
            }
            else
            {
                return  Ok(obj);
            }
        }
        [HttpGet(nameof(GetAllUserPost))]
        public IActionResult GetAllUserPost()
        {
            var obj = _UserPostService.GetAll();
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }
        [HttpPost(nameof(CreateUserPost))]
        public IActionResult CreateUserPost(UserPost UserPost)
        {
            if (UserPost != null)
            {
                _UserPostService.Insert(UserPost);
                return Ok("Created Successfully");
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }
        }
        [HttpPut(nameof(UpdateUserPost))]
        public IActionResult UpdateUserPost(UserPost UserPost)
        {
            if (UserPost != null)
            {
                _UserPostService.Update(UserPost);
                return Ok("Update Successfully");
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }
        }
        [HttpDelete(nameof(CreateUserPost))]
        public IActionResult DeleteUserPost(UserPost UserPost)
        {
            if (UserPost != null)
            {
                _UserPostService.Delete(UserPost);
                return Ok("Remove Successfully");
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }
        }
    }
}
