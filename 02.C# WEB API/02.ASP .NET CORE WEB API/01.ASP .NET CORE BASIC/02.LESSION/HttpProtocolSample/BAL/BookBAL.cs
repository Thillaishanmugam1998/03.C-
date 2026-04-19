using HttpProtocolSample.Models;

namespace HttpProtocolSample.BAL;

public class BookBAL
{
    private readonly List<Book> _books =
    [
        new Book { Id = 1, Title = "C# Basics", Author = "Arun", Price = 450, Category = "Programming" },
        new Book { Id = 2, Title = "ASP.NET Core", Author = "Divya", Price = 650, Category = "Web Development" }
    ];

    private int _nextId = 3;

    #region 01. GET ALL BOOKS

    public List<Book> GetAll()
    {
        return _books;
    }

    #endregion

    #region 02. GET BOOK BY ID

    public Book? GetById(int id)
    {
        return _books.FirstOrDefault(book => book.Id == id);
    }

    #endregion

    #region 03. ADD BOOK

    public Book Add(CreateBookRequest request)
    {
        var book = new Book
        {
            Id = _nextId++,
            Title = request.Title,
            Author = request.Author,
            Price = request.Price,
            Category = request.Category
        };

        _books.Add(book);
        return book;
    }

    #endregion

    #region 04. UPDATE BOOK

    public Book? Update(int id, UpdateBookRequest request)
    {
        var book = _books.FirstOrDefault(item => item.Id == id);

        if (book is null)
        {
            return null;
        }

        book.Title = request.Title;
        book.Author = request.Author;
        book.Price = request.Price;
        book.Category = request.Category;

        return book;
    }

    #endregion

    #region 05. UPDATE BOOK PRICE

    public Book? UpdatePrice(int id, PatchBookPriceRequest request)
    {
        var book = _books.FirstOrDefault(item => item.Id == id);

        if (book is null)
        {
            return null;
        }

        book.Price = request.Price;
        return book;
    }

    #endregion

    #region 06. DELETE BOOK

    public bool Delete(int id)
    {
        var book = _books.FirstOrDefault(item => item.Id == id);

        if (book is null)
        {
            return false;
        }

        _books.Remove(book);
        return true;
    }

    #endregion
}
