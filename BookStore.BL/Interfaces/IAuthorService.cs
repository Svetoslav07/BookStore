﻿using System;
using BookStore.Models.Models;

namespace BookStore.BL.Interfaces
{
	public interface IAuthorService
	{
        IEnumerable<Author> GetAll();

        Author GetById(int id);

        void Add(Author author);
    }
}

