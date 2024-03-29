using Dapp1.Models;
using Dapp1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dapp1.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookServices services;
        public BookController(IBookServices services)
        {
            this.services = services;
        }

        // GET: BookController
        public async Task<ActionResult>Index()
        {
            try
            {
                var model = await services.GetBooks();
                return View(model);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: BookController/Details/5
        public async Task<ActionResult> Details(int id)
        {
            try
            {
                var model = await services.GetBookById(id);
                return View(model);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: BookController/Create
        public  ActionResult Create()
        {
            return View();
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Book book)
        {
            try
            {
                int result = await services.AddBook(book);
                if (result >= 1)
                    return RedirectToAction("Index");
                else
                    return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: BookController/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            try
            {
                var model = await services.GetBookById(id);
                return View(model);
            }
            catch (Exception ex)
            {
                return View();
            }
        }
        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Book book)
        {
            try
            {
                int result = await services.UpdateBook(book);
                if (result >= 1)
                    return RedirectToAction("Index");
                else
                    return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // GET: BookController/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var model = await services.GetBookById(id);
                return View(model);
            }
            catch (Exception ex)
            {
                return View();
            }
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirm(int id)
        {
            try
            {
                int result = await services.DeleteBook(id);
                if (result >= 1)
                    return RedirectToAction("Index");
                else
                    return View();
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}
