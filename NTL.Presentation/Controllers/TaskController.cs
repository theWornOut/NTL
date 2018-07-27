using System.Linq;
using System.Web.Mvc;
using NTL.Business.Interfaces;
using NTL.Presentation.Models;

namespace NTL.Presentation.Controllers
{
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        // GET: Task
        public ActionResult Index()
        {
            return View(_taskService.GetAll().ToList().ToModel());
        }

        // GET: Task/Details/5
        public ActionResult Details(int id)
        {
            var taskModels = _taskService.GetById(id);
            if (taskModels == null)
            {
                return HttpNotFound();
            }
            return View(taskModels.ToModel());
        }

        // GET: Task/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Task/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TaskModels taskModels)
        {
            if (ModelState.IsValid)
            {
                _taskService.Insert(taskModels.ToEntity());
                return RedirectToAction("Index");
            }

            return View(taskModels);
        }

        // GET: Task/Edit/5
        public ActionResult Edit(int id)
        {
            var taskModels = _taskService.GetById(id);
            if (taskModels == null)
            {
                return HttpNotFound();
            }
            return View(taskModels.ToModel());
        }

        // POST: Task/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TaskModels taskModels)
        {
            if (ModelState.IsValid)
            {
                _taskService.Update(taskModels.ToEntity());
                return RedirectToAction("Index");
            }
            return View(taskModels);
        }

        [HttpPost]
        public JsonResult Delete(int id)
        {
            var taskModels = _taskService.GetById(id);
            _taskService.Delete(taskModels);
            return Json(Url.Action("Index", "Task"), JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _taskService.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
