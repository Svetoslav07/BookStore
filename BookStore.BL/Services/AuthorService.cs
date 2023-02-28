using BookStore.DL.InMemoryDb.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Services
{
    public class AuthorServices : IAuthorRepository
    {
        private readonly IAuthorRepository _authorRepository;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public void Add(Author author)
        {
            InMemoryDb.InMemoryDb.Author.Add(author);
        }

        public void Add(Author author)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Author> GetAll()
        {
            return _authorRepository.GetAll();  
        }

        public IEnumerable<Author> GetAll()
        {
            throw new NotImplementedException();
        }

        public Author GetById(int id)
        {
            return _authorRepository.GetById(id);
        }

        public Author GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
