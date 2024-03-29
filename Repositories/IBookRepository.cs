using Dapp1.Models;

namespace Dapp1.Repositories
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetBooks();
        Task<Book> GetBookById(int id);
        Task<int> AddBook(Book book);
        Task<int> DeleteBook(int id);
        Task<int> UpdateBook(Book book);
    }
}
