using BusinessLogicLayer.Abstract;
using BusinessLogicLayer.Concrete;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NTierArchitecture.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace NTierArchitecture.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService _bookService;
        private readonly IGenreService _genreService;
        private readonly IAuthorService _authorService;

        public HomeController(IBookService bookService, IGenreService genreService, IAuthorService authorService)
        {
            _genreService = genreService;
            _authorService = authorService;
            _bookService = bookService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetBooks()
        {
            StoreViewModel viewModel = new StoreViewModel();
            viewModel.books = _bookService.Get();
            foreach (var item in viewModel.books)
            {
                item.author = _authorService.GetById(item.authorID);
                item.genre = _genreService.GetById(item.genreID);
            }
            return View(viewModel);
        }
    }
}
