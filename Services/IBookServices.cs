using Dapp1.Models;

namespace Dapp1.Services
{
    public interface IBookServices
    {
        Task<IEnumerable<Book>> GetBooks();
        Task<Book> GetBookById(int id);
        Task<int> AddBook(Book book);
        Task<int> DeleteBook(int id);
        Task<int> UpdateBook(Book book);
    }
}
