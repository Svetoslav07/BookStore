using BookStore.DL.InMemoryDb.Interfaces;
using BookStore.Models.Base;

namespace BookStore.DL.InMemoryDb.Repositories.InMemoryRepositories
{
    public class AuthorInMemoryRepositories : IAuthorRepository
    {
       
      
        public void Add(Author author)
        {
            InMemoryDb.InMemoryDb.Author.Add(author);
        }

        public IEnumerable<Author> GetAll()
        {
            return InMemoryDb.InMemoryDb.Authors;
        }

        public Author GetById(int id)
        {
            return InMemoryDb.InMemoryDb.Author.FirstOrDefault(ax=>x.ID == id);
        }
    }
}
