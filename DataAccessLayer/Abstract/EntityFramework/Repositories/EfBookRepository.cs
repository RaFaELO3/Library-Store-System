using DataAccessLayer.Concrete;
using Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract.EntityFramework.Repositories
{
    public class EfBookRepository : EfGenericRepository<Book> , IBookDAL
    {
      
    }
}
