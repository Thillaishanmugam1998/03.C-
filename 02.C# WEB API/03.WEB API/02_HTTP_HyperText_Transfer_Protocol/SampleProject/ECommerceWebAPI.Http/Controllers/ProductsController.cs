using ECommerceWebAPI.Http;
using ECommerceWebAPI.Http.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceWebAPI.Http.Controllers;

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
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult<IEnumerable<Product>> GetAll()
    {
        var products = _productService.GetAll();
        return Ok(products);
    }

    [HttpGet("{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public ActionResult<Product> GetById(int id)
    {
        var product = _productService.GetById(id);

        if (product is null)
        {
            return NotFound($"Product with ID {id} was not found.");
        }

        return Ok(product);
    }

    [HttpHead("{id:int}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult HeadById(int id)
    {
        var product = _productService.GetById(id);

        if (product is null)
        {
            return NotFound();
        }

        return Ok();
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<Product> Create(Product product)
    {
        if (string.IsNullOrWhiteSpace(product.Name))
        {
            return BadRequest("Product name is required.");
        }

        if (product.Price <= 0)
        {
            return BadRequest("Product price must be greater than zero.");
        }

        if (product.StockQuantity < 0)
        {
            return BadRequest("Stock quantity cannot be negative.");
        }

        var createdProduct = _productService.Create(product);
        return CreatedAtAction(nameof(GetById), new { id = createdProduct.Id }, createdProduct);
    }

    [HttpPut("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Update(int id, Product product)
    {
        if (string.IsNullOrWhiteSpace(product.Name))
        {
            return BadRequest("Product name is required.");
        }

        if (product.Price <= 0)
        {
            return BadRequest("Product price must be greater than zero.");
        }

        if (product.StockQuantity < 0)
        {
            return BadRequest("Stock quantity cannot be negative.");
        }

        var isUpdated = _productService.Update(id, product);

        if (!isUpdated)
        {
            return NotFound($"Product with ID {id} was not found.");
        }

        return NoContent();
    }

    [HttpDelete("{id:int}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
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
