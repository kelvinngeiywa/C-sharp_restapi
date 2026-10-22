using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using rest_api.Models;
using rest_api.Models.DTO;

namespace rest_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ResponseDTO _response;
        public ProductController()
        {
            _response = new ResponseDTO();
        }

        static private List<Product> products = new List<Product>
        {
            new Product
            {
                Id  = Guid.NewGuid(),
                Name = "Laptop",
                Price = 85000.00,
                Count = 10,
                DateAdded = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Laptop",
                Price = 85000.00,
                Count = 10,
                DateAdded = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Laptop",
                Price = 85000.00,
                Count = 10,
                DateAdded = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Smartphone",
                Price = 45000.00,
                Count = 25,
                DateAdded = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Keyboard",
                Price = 2500.00,
                Count = 40,
                DateAdded = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Mouse",
                Price = 1200.00,
                Count = 50,
                DateAdded = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Monitor",
                Price = 18000.00,
                Count = 15,
                DateAdded = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Headphones",
                Price = 3500.00,
                Count = 30,
                DateAdded = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Printer",
                Price = 22000.00,
                Count = 8,
                DateAdded = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "USB Flash Drive",
                Price = 800.00,
                Count = 100,
                DateAdded = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "External Hard Drive",
                Price = 9500.00,
                Count = 20,
                DateAdded = DateTime.Now
            },
            new Product
            {
                Id = Guid.NewGuid(),
                Name = "Webcam",
                Price = 4000.00,
                Count = 12,
                DateAdded = DateTime.Now
            }

        };

        [HttpGet]
        public ActionResult<ResponseDTO> GetProducts()
        {
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
        public ActionResult<ResponseDTO> GetproductById(string Id)
        {
            var product = products.FirstOrDefault(p => p.Id.ToString() == Id);
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
        public ActionResult<Product> AddProduct(AddProductDTO addProductDTO)
        {
            var newProduct = new Product
            {
                Name=addProductDTO.Name,
                Price=addProductDTO.Price,
                Count=addProductDTO.Count

            };
            if (newProduct == null)
                return BadRequest();

            products.Add(newProduct);
            return CreatedAtAction(
                nameof(GetproductById),
                new { Id = newProduct.Id},
                newProduct
            );

        }

        [HttpPut("{Id}")]
        public IActionResult UpdateProduct(string Id,AddProductDTO updateProductDTO)
        {
            var product = products.FirstOrDefault(p => p.Id.ToString() == Id);
            if (product == null)
            {
                return NotFound(product);
            }

            product.Name = updateProductDTO.Name;
            product.Price = updateProductDTO.Price;
            product.Count = updateProductDTO.Count;

            return NoContent();


        }

        [HttpDelete("{Id}")]
        public IActionResult DeleteProduct(string Id)
        {
            var product = products.FirstOrDefault(p => p.Id.ToString() == Id);
            if (product == null)
            {
                return NotFound(product);
            }
            products.Remove(product);
            //return Ok();
            return NoContent();
        }

    }
}
