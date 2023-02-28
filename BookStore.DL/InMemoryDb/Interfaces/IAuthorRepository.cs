using BookStore.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.InMemoryDb.Interfaces
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> GetAll();

        Author GetById(int id);

        void Add(Author author);
    }
}
