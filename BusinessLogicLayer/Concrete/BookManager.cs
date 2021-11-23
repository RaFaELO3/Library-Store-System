using BusinessLogicLayer.Abstract;
using DataAccessLayer.Concrete;
using Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Concrete
{
    public class BookManager : IBookService
    {
        private readonly IBookDAL _bookRepository;

        public BookManager(IBookDAL bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Add(Book entity)
        {
            _bookRepository.Add(entity);
        }

        public void Delete(Book entity)
        {
            _bookRepository.Delete(entity);

        }

        public List<Book> Get()
        {
            return _bookRepository.Get();
            
        }

        public Book GetById(int id)
        {
            return _bookRepository.GetById(id);

        }

        public void Update(Book entity)
        {
            _bookRepository.Update(entity);

        }
    }
}
 