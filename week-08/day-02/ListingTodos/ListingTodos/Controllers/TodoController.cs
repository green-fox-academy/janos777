using Microsoft.AspNetCore.Mvc;
using ListingTodos.Repositories;
using ListingTodos.Model;

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
        public IActionResult List()
        {
            return View(_repository.Read());
        }

        [Route("list/{isActive}")]
        public IActionResult List(bool isActive)
        {
            return View(_repository.Read(isActive));
        }

        [Route("add")]
        public IActionResult Add(string title, bool isUrgent, bool isDone)
        {
            _repository.Create(title, isUrgent, isDone);

            return RedirectToAction("list");
        }

        [Route("{Id}/edit")]
        public IActionResult Edit([FromRoute] int id)
        {
            return View(_repository.SelectRow(id));
        }

        [Route("{Id}/update")]
        public IActionResult Update(int id, string title, string isUrgent, string isDone)
        {
            _repository.Update(id, title, isUrgent, isDone);
            return RedirectToAction("list");
        }

        [Route("{Id}/delete")]
        public IActionResult Delete([FromRoute] int id)
        {
            _repository.Delete(id);
            return RedirectToAction("list");
        }
    }
}
