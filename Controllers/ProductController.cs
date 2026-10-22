using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using rest_api.Data;
using rest_api.Models;
using rest_api.Models.DTO;

namespace rest_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _dbContext;
        private readonly ResponseDTO _response;
        public ProductController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _response = new ResponseDTO();
        }



        [HttpGet]
        public async Task<ActionResult<ResponseDTO>> GetProducts()
        {
            var products = await _dbContext.products.ToListAsync();
            if (products == null || !products.Any())
            {
                _response.Success = false;
                _response.Message = "No product found";
           
                return NotFound(_response);

            }
                
            _response.Success = true;
            _response.Data = products;
            return Ok(_response);
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<ResponseDTO>> GetproductById(Guid Id)
        {
            var product = await _dbContext.products.FindAsync(Id);
            if(product == null)
            {
                _response.Success = false;
                _response.Message = "product not found";

                return NotFound(_response);
            }
            _response.Success = true;
            _response.Data = product;
            return Ok(_response);
        }

        [HttpPost]
        public async Task<ActionResult<ResponseDTO>> AddProduct(AddProductDTO addProductDTO)
        {
            var newProduct = new Product
            {
                Name=addProductDTO.Name,
                Price=addProductDTO.Price,
                Count=addProductDTO.Count

            };
            if (newProduct == null)
                return BadRequest();

            //await _dbContext.products.Add(newProduct);
             _dbContext.products.Add(newProduct);
            await _dbContext.SaveChangesAsync();
            _response.Success = true;
            _response.Message = "Product created!!!";
            _response.Data = newProduct;


            return CreatedAtAction(
                nameof(GetproductById),
                new { Id = newProduct.Id},
                _response
            );

        }

        [HttpPut("{Id}")]
        public async Task<IActionResult> UpdateProduct(string Id,AddProductDTO updateProductDTO)
        {
            var product = await _dbContext.products.Where(p => p.Id.ToString() == Id).FirstOrDefaultAsync();
            if (product == null)
            {
                _response.Success = false;
                return NotFound(product);
            }

            product.Name = updateProductDTO.Name;
            product.Price = updateProductDTO.Price;
            product.Count = updateProductDTO.Count;

            _response.Success = true;
            _response.Message = "Product updated successfully!!!";
            _response.Data = product;

            await _dbContext.SaveChangesAsync();

            return Ok(_response);


        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> DeleteProduct(Guid Id)
        {
            var product = await _dbContext.products.FindAsync(Id);
            if (product == null)
            {
                return NotFound(product);
            }
             _dbContext.products.Remove(product);
            _response.Success = true;
            _response.Message = "Product deleted successfully!!!";
            await _dbContext.SaveChangesAsync();
            //return Ok();
            return Ok(_response);
        }


        //static private List<Product> products = new List<Product>
        //{
        //    new Product
        //    {
        //        Id  = Guid.NewGuid(),
        //        Name = "Laptop",
        //        Price = 85000.00,
        //        Count = 10,
        //        DateAdded = DateTime.Now
        //    },
        //    new Product
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "Laptop",
        //        Price = 85000.00,
        //        Count = 10,
        //        DateAdded = DateTime.Now
        //    },
        //    new Product
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "Laptop",
        //        Price = 85000.00,
        //        Count = 10,
        //        DateAdded = DateTime.Now
        //    },
        //    new Product
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "Smartphone",
        //        Price = 45000.00,
        //        Count = 25,
        //        DateAdded = DateTime.Now
        //    },
        //    new Product
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "Keyboard",
        //        Price = 2500.00,
        //        Count = 40,
        //        DateAdded = DateTime.Now
        //    },
        //    new Product
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "Mouse",
        //        Price = 1200.00,
        //        Count = 50,
        //        DateAdded = DateTime.Now
        //    },
        //    new Product
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "Monitor",
        //        Price = 18000.00,
        //        Count = 15,
        //        DateAdded = DateTime.Now
        //    },
        //    new Product
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "Headphones",
        //        Price = 3500.00,
        //        Count = 30,
        //        DateAdded = DateTime.Now
        //    },
        //    new Product
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "Printer",
        //        Price = 22000.00,
        //        Count = 8,
        //        DateAdded = DateTime.Now
        //    },
        //    new Product
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "USB Flash Drive",
        //        Price = 800.00,
        //        Count = 100,
        //        DateAdded = DateTime.Now
        //    },
        //    new Product
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "External Hard Drive",
        //        Price = 9500.00,
        //        Count = 20,
        //        DateAdded = DateTime.Now
        //    },
        //    new Product
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "Webcam",
        //        Price = 4000.00,
        //        Count = 12,
        //        DateAdded = DateTime.Now
        //    }

        //};

    }
}
