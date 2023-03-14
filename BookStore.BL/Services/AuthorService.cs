using AutoMapper;
using BookStore.BL.Interfaces;
using BookStore.DL.Interfaces;
using BookStore.Models.Models;
using BookStore.Models.Requests;

namespace BookStore.BL.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorService(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public void Add(AddAuthorRequest authorRequest)
        {
            // automapper
            //_authorRepository.Add(authorRequest);
            var author = _mapper.Map<Author>(authorRequest);

            _authorRepository.Add(author);
        }

        public void Delete(int id)
        {
            _authorRepository.Delete(id);
        }

        public IEnumerable<Author> GetAll()
        {
            return _authorRepository.GetAll();


        }
        public Author GetById(int id)
        {
            return _authorRepository.GetById(id);
        }

        public void Update(UpdateAuthorRequest author)
        {
            var author = _mapper.Map<Author>(UpdateAuthorRequest);
            _authorRepository.Update(author);
        }

        
    }
}

