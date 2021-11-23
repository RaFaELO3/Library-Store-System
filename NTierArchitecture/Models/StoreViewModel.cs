using Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTierArchitecture.Models
{
    public class StoreViewModel
    {
        public List<Book> books { get; set; }
        public Book book { get; set; }
        public List<Genre> genres { get; set; }
        public Genre genre { get; set; }
        public List<Author> authors { get; set; }
        public Author author { get; set; }
    }
}
