using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Ap16WebApplication.ServiceAPI;

namespace Ap16WebApplication.Controllers
{
    public class TaskController : Controller
    {
        private readonly IRestServiceApi _serviceApi;

        public TaskController(IRestServiceApi serviceApi)
        {
            _serviceApi = serviceApi;
        }


        // GET: Task/Details/5
        public async Task<ActionResult> ShowTasks()
        {
            var model = await _serviceApi.GetTaskDetailsAsync();
            return View("ShowTasks", model);
        }

        // GET: Task/Create
        public ActionResult AddTask()
        {
            return View();
        }

        // POST: Task/Create
        [HttpPost]
        public ActionResult AddTask(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("ShowTasks");
            }
            catch
            {
                return View();
            }
        }

        // GET: Task/Edit/5
        public async Task<ActionResult> EditTask(int id)
        {
            var model = await _serviceApi.GetTaskDetailsAsync();

            return View("EditTask", model.SingleOrDefault(x => x.Id==id));
        }

        // POST: Task/Edit/5
        [HttpPost]
        public ActionResult EditTask(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("ShowTasks");
            }
            catch
            {
                return View();
            }
        }

        // GET: Task/Delete/5
        public async Task<ActionResult> DeleteTask(int id)
        {
            var model = await _serviceApi.GetTaskDetailsAsync();

            return View("DeleteTask", model.SingleOrDefault(x => x.Id == id));
        }

        // POST: Task/Delete/5
        [HttpPost]
        public ActionResult DeleteTask(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("ShowTasks");
            }
            catch
            {
                return View();
            }
        }
    }
}
