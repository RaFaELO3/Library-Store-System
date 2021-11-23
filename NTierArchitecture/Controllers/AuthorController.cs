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
    public class AuthorController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IGenreService _genreService;
        private readonly IAuthorService _authorService;

        public AuthorController(IBookService bookService, IGenreService genreService, IAuthorService authorService)
        {
            _genreService = genreService;
            _authorService = authorService;
            _bookService = bookService;
        }
        public IActionResult GetAuthors()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SearchByAuthor(string aName)
        {
            if (aName != null)
            {
                StoreViewModel viewModel = new StoreViewModel();
                List<Book> Books = new List<Book>();
                viewModel.authors = _authorService.Get().Where(I => I.AuthorName.ToLower() == aName.ToLower()).ToList();
                if (viewModel.authors ==null)
                {
                    return RedirectToAction("Error", "Home");
                }
                foreach (var item in viewModel.authors)
                {
                    Books = _bookService.Get().Where(I => I.authorID == item.AuthorId).ToList();
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
