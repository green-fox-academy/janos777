using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ListingTodos.Model;
using ListingTodos.Repositories;

namespace ListingTodos.Controllers
{
    [Route("todo")]
    public class TodoController : Controller
    {
        private IRepository _repository;

        public TodoController(IRepository repository)
        {
            _repository = repository;
        }

        [Route("list")]
        [HttpGet]
        public IActionResult List()
        {
            return View(_repository.Read());
        }

        /*
        [Route("add")]
        [HttpPost]
        public IActionResult add(string title)
        {
            TodoContext.Todos.Add(new Todo());

            return RedirectToAction("list");
        }
        */
    }
}