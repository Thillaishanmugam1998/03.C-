using ECommerceWebAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceWebAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductsController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetAll()
    {
        var products = _productService.GetAll();
        return Ok(products);
    }

    [HttpGet("{id:int}")]
    public ActionResult<Product> GetById(int id)
    {
        var product = _productService.GetById(id);

        if (product is null)
        {
            return NotFound($"Product with ID {id} was not found.");
        }

        return Ok(product);
    }

    [HttpPost]
    public ActionResult<Product> Create(Product product)
    {
        var createdProduct = _productService.Create(product);
        return CreatedAtAction(nameof(GetById), new { id = createdProduct.Id }, createdProduct);
    }

    [HttpPut("{id:int}")]
    public IActionResult Update(int id, Product product)
    {
        var isUpdated = _productService.Update(id, product);

        if (!isUpdated)
        {
            return NotFound($"Product with ID {id} was not found.");
        }

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    public IActionResult Delete(int id)
    {
        var isDeleted = _productService.Delete(id);

        if (!isDeleted)
        {
            return NotFound($"Product with ID {id} was not found.");
        }

        return NoContent();
    }
}
