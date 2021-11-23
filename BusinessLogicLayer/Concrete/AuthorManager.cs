using BusinessLogicLayer.Abstract;
using DataAccessLayer.Concrete;
using Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Concrete
{
    public class AuthorManager : IAuthorService
    {
        private readonly IAuthorDAL _authorRepository;
        public AuthorManager(IAuthorDAL authorRepository)
        {
            _authorRepository = authorRepository;
        }
        public void Add(Author entity)
        {
            _authorRepository.Add(entity);
        }

        public void Delete(Author entity)
        {
            _authorRepository.Delete(entity);

        }

        public List<Author> Get()
        {
            return _authorRepository.Get();
        }

        public Author GetById(int id)
        {
            return _authorRepository.GetById(id);
        }

        public void Update(Author entity)
        {
            _authorRepository.Update(entity);

        }
    }
}
