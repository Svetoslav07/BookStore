using BookStore.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.InMemoryDb
{
    public static class InMemoryDb
    {
        public static List<Author> Authors = new List<Author>()
        {
            new Author()
         {
            ID = 1,
            Name = "Pesho"

         },
            new Author()
         {
            ID= 2 ,
            Name = "Stamat"

         }

        };

        public static object InMemoryDb { get; internal set; }
    }
