using HttpProtocolSample.BAL;
using HttpProtocolSample.Models;
using Microsoft.AspNetCore.Mvc;

namespace HttpProtocolSample.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BooksController(BookBAL bookBAL) : ControllerBase
{
    #region 01. GET ALL BOOKS

    // Route: GET /api/books
    // This method shows how HTTP GET is used to fetch all records.
    [HttpGet]
    public ActionResult<IEnumerable<Book>> GetBooks()
    {
        return Ok(bookBAL.GetAll());
    }

    #endregion

    #region 02. GET BOOK BY ID

    // Route: GET /api/books/{id}
    // This method shows how HTTP GET is used to fetch one record by id.
    [HttpGet("{id:int}")]
    public ActionResult<Book> GetBookById(int id)
    {
        var book = bookBAL.GetById(id);

        if (book is null)
        {
            return NotFound(new { message = $"Book with id {id} was not found." });
        }

        return Ok(book);
    }

    #endregion

    #region 03. CREATE BOOK

    // Route: POST /api/books
    // This method shows how HTTP POST is used to create a new record.
    [HttpPost]
    public ActionResult<Book> CreateBook(CreateBookRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Title) ||string.IsNullOrWhiteSpace(request.Author) ||string.IsNullOrWhiteSpace(request.Category) ||request.Price <= 0)
        {
            return BadRequest(new { message = "Title, Author, Category, and valid Price are required." });
        }

        var book = bookBAL.Add(request);

        return CreatedAtAction(nameof(GetBookById), new { id = book.Id }, book);
    }

    #endregion

    #region 04. UPDATE BOOK

    // Route: PUT /api/books/{id}
    // This method shows how HTTP PUT is used to replace the full record.
    [HttpPut("{id:int}")]
    public ActionResult<Book> UpdateBook(int id, UpdateBookRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.Title) ||
            string.IsNullOrWhiteSpace(request.Author) ||
            string.IsNullOrWhiteSpace(request.Category) ||
            request.Price <= 0)
        {
            return BadRequest(new { message = "Title, Author, Category, and valid Price are required." });
        }

        var book = bookBAL.Update(id, request);

        if (book is null)
        {
            return NotFound(new { message = $"Book with id {id} was not found." });
        }

        return Ok(book);
    }

    #endregion

    #region 05. UPDATE BOOK PRICE

    // Route: PATCH /api/books/{id}/price
    // This method shows how HTTP PATCH is used to update only one part of the record.
    [HttpPatch("{id:int}/price")]
    public ActionResult<Book> UpdateBookPrice(int id, PatchBookPriceRequest request)
    {
        if (request.Price <= 0)
        {
            return BadRequest(new { message = "Valid Price is required." });
        }

        var book = bookBAL.UpdatePrice(id, request);

        if (book is null)
        {
            return NotFound(new { message = $"Book with id {id} was not found." });
        }

        return Ok(book);
    }

    #endregion

    #region 06. DELETE BOOK

    // Route: DELETE /api/books/{id}
    // This method shows how HTTP DELETE is used to remove a record.
    [HttpDelete("{id:int}")]
    public IActionResult DeleteBook(int id)
    {
        var isDeleted = bookBAL.Delete(id);

        if (!isDeleted)
        {
            return NotFound(new { message = $"Book with id {id} was not found." });
        }

        return Ok(new { message = $"Book with id {id} deleted successfully." });
    }

    #endregion
}
