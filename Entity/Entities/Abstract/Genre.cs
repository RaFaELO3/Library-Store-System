using Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Entities.Abstract
{
    public class Genre : ITable
    {
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public List<Book> books { get; set; }

    }

}
