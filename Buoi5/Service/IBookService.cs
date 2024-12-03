using Buoi5.Models;

namespace Buoi5.Service
{
    public interface IBookService
    {
        Task<List<Book>> GetBooksAsync();
        Task<Book> GetBookByIdAsync(int id);
        Task CreateBookAsync(Book book);
        Task EditBookAsync(Book book);
        Task DeleteBookAsync(int id);
    }

}
