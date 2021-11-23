using Entity.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Entities.Abstract
{
    public class Book : ITable
    {       
        public int BookID { get; set; }
        public string BookName { get; set; }
        public double BookPrice { get; set; }
        public int BookCount { get; set; }
        public Genre genre { get; set; }
        public int genreID { get; set; }
        public Author author { get; set; }
        public int authorID { get; set; }
    }
}
