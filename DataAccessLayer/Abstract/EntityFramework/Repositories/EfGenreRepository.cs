using DataAccessLayer.Abstract.EntityFramework.Context;
using DataAccessLayer.Concrete;
using Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccessLayer.Abstract.EntityFramework.Repositories
{
    public class EfGenreRepository : EfGenericRepository<Genre> , IGenreDAL
    {
      
    }
}
