using BusinessLogicLayer.Abstract;
using DataAccessLayer.Concrete;
using Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogicLayer.Concrete
{
    public class GenreManager : IGenreService
    {
        private readonly IGenreDAL _genreRepository;

        public GenreManager(IGenreDAL genreRepository)
        {
            _genreRepository = genreRepository;
        }
        public void Add(Genre entity)
        {
            _genreRepository.Add(entity);
        }

        public void Delete(Genre entity)
        {
            _genreRepository.Delete(entity);
        }

        public List<Genre> Get()
        {
            return _genreRepository.Get();
        }

        public Genre GetById(int id)
        {
            return _genreRepository.GetById(id);
        }

        public void Update(Genre entity)
        {
            _genreRepository.Update(entity);
        }
    }
}
