using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProcessManager.Services;

namespace ProcessManager.Controllers
{
    public class ProcessesController : Controller
    {
        public ProcessesList Processes { get; }

        public ProcessesController(ProcessesList processes)
        {
            Processes = processes;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(Processes.ProcessList);
        }

        public IActionResult ProcessesView()
        {
            return PartialView(Processes.ProcessList);
        }

        public async Task<IActionResult> Sort(int id)
        {
            Processes.SortId = id;
            Processes.Sort = HttpContext.Request.Form[$"Sort{id}"];

            await Processes.SortAsync();
            return View("Index", Processes.ProcessList);
        }

        public IActionResult Remove(int id)
        {
            Processes.Remove(id);

            return View("Index", Processes.ProcessList);
        }

        public IActionResult OpenFolder(int id)
        {
            Processes.OpenFolder(id);

            return View("Index", Processes.ProcessList);
        }

        public IActionResult Modules(int id)
        {
            var process = Processes.ProcessList.Find(p => p.Id == id);
            return View(process);
        }

        public IActionResult Threads(int id)
        {
            var process = Processes.ProcessList.Find(p => p.Id == id);
            return View(process);
        }
    }
}