using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OA_DataAccess;
using OA_Repository;
using OA_Service;

namespace OA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet(nameof(GetProductById))]
        public IActionResult GetProductById(int Id)
        {
            var obj = _productService.GetById(Id);
            if (obj == null)
            {
                return  NotFound();
            }
            else
            {
                return  Ok(obj);
            }
        }
        [HttpGet(nameof(GetAllProduct))]
        public IActionResult GetAllProduct()
        {
            var obj = _productService.GetAll();
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }
        [HttpPost(nameof(CreateProduct))]
        public IActionResult CreateProduct(Product product)
        {
            if (product != null)
            {
                _productService.Insert(product);
                return Ok("Created Successfully");
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }
        }
        [HttpPut(nameof(UpdateProduct))]
        public IActionResult UpdateProduct(Product product)
        {
            if (product != null)
            {
                _productService.Update(product);
                return Ok("Update Successfully");
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }
        }
        [HttpDelete(nameof(CreateProduct))]
        public IActionResult DeleteProduct(Product product)
        {
            if (product != null)
            {
                _productService.Delete(product);
                return Ok("Remove Successfully");
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }
        }
    }
}
