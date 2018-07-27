using System.Linq;
using System.Web.Mvc;
using NTL.Business.Interfaces;
using NTL.Presentation.Models;

namespace NTL.Presentation.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoService _todoService;
        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        // GET: Todo
        public ActionResult Index()
        {
            return View(_todoService.GetAll().ToList().ToModel());
        }

        // GET: Todo/Details/5
        public ActionResult Details(int id)
        {
            var todoModels = _todoService.GetById(id);
            if (todoModels == null)
            {
                return HttpNotFound();
            }
            return View(todoModels.ToModel());
        }

        // GET: Todo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Todo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TodoModels todoModels)
        {
            if (ModelState.IsValid)
            {
                _todoService.Insert(todoModels.ToEntity());
                return RedirectToAction("Index");
            }

            return View(todoModels);
        }

        // GET: Todo/Edit/5
        public ActionResult Edit(int id)
        {
            var todoModels = _todoService.GetById(id);
            if (todoModels == null)
            {
                return HttpNotFound();
            }
            return View(todoModels.ToModel());
        }

        // POST: Todo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TodoModels todoModels)
        {
            if (ModelState.IsValid)
            {
                _todoService.Update(todoModels.ToEntity());
                return RedirectToAction("Index");
            }
            return View(todoModels);
        }

        [HttpPost]
        public JsonResult Delete(int id)
        {
            var todoModels = _todoService.GetById(id);
            _todoService.Delete(todoModels);
            return Json(Url.Action("Index", "Todo"), JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _todoService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
