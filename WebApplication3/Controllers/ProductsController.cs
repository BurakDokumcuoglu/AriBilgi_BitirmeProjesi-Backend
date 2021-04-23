
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace WebApplication3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();
            return Ok(result);
        }

        [HttpGet("getbycategory")]
        public IActionResult GetByCategory(int categoryId)
        {
            var result = _productService.GetAllByCategory(categoryId);
            return Ok(result);
        }



    }
}
