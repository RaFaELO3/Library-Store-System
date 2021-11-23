using BusinessLogicLayer.Abstract;
using Entity.Entities.Abstract;
using Microsoft.AspNetCore.Mvc;
using NTierArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NTierArchitecture.Controllers
{
    public class GenreController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IGenreService _genreService;
        private readonly IAuthorService _authorService;

        public GenreController(IBookService bookService, IGenreService genreService, IAuthorService authorService)
        {
            _genreService = genreService;
            _authorService = authorService;
            _bookService = bookService;
        }
        public  IActionResult GetGenres()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SearchByGenre(string gName)
        {
            if (gName != null)
            {
                StoreViewModel viewModel = new StoreViewModel();
                List<Book> Books = new List<Book>();
                viewModel.genres = _genreService.Get().Where(I => I.GenreName.ToLower() == gName.ToLower()).ToList();
                if (viewModel.genres == null)
                {
                    return RedirectToAction("Error", "Home");
                }
                foreach (var item in viewModel.genres)
                {
                    Books = _bookService.Get().Where(I => I.genreID == item.GenreId).ToList();
                    item.books = Books;
                }
                foreach (var item in Books)
                {
                    item.genre = _genreService.GetById(item.genreID);
                    item.author = _authorService.GetById(item.authorID);
                }
                viewModel.books = Books;

                return View(viewModel);
            }
            return RedirectToAction("Error", "Home");

        }
    }
}
