using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Interfaces
{
    internal class IAuthorService
    {
        public interface IAuthorRepository
        {
            IEnumerable<Author> GetAll();

            Author GetById(int id);

            void Add(Author author);
        }
    }
