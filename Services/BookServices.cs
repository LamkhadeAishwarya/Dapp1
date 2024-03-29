using Dapp1.Models;
using Dapp1.Repositories;

namespace Dapp1.Services
{
    public class BookServices : IBookServices
    {
        private readonly IBookRepository repo;
        public BookServices(IBookRepository repo)
        {
            this.repo = repo;
        }

        public async Task<int> AddBook(Book book)
        {
         return await repo.AddBook(book);
        }

        public Task<int> DeleteBook(int id)
        {
           return repo.DeleteBook(id);  
        }

        public Task<Book> GetBookById(int id)
        {
          return repo.GetBookById(id);
        }

        public Task<IEnumerable<Book>> GetBooks()
        {
            return repo.GetBooks();
        }

        public Task<int> UpdateBook(Book book)
        {
            return repo.UpdateBook(book);
        }
    }
}
