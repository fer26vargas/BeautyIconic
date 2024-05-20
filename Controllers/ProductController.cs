using BackendBeautyIconic.Models;
using BackendBeautyIconic.Services.SProducts;
using Microsoft.AspNetCore.Mvc;

namespace BackendBeautyIconic.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Products>>> GetAllProducts(int pageNumber = 1, int pageSize = 10)
        {
            try
            {
                var productos = await _productService.GetAll(pageNumber, pageSize);
                return Ok(productos);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Error al obtener los productos: {ex.Message}");
            }
        }

    }
}
