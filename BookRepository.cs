using System.Linq;
using WebApplication1.Models;

namespace WebApplication1.Repository
{
    public class BookRepository
    {

        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }
        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }
        public List<BookModel> GetBooksWithEvenIds()
        {
            return DataSource().Where( x =>  x.Id % 2 == 0).ToList();
        }
        public List<BookModel> SearchBook(string title,string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }
        private List<BookModel> DataSource()
        {
            return new List<BookModel>()
            {
                new BookModel(){Id=1,Title="MVC",Author="Nitish"},
                new BookModel(){Id=2,Title="MVC",Author="Nitish"},
                new BookModel(){Id=3,Title="MVC",Author="Nitish"},
                new BookModel(){Id=4,Title="MVC",Author="Nitish"},
                new BookModel(){Id=5,Title="MVC",Author="Nitish"},
            };
        }
    }
}
