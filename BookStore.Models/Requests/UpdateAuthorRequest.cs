using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.Requests
{
    public class UpdateAuthorRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
    }
}
