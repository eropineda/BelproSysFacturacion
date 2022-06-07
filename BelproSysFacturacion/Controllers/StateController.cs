using BelproSysFacturacion.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BelproSysFacturacion.Controllers
{
    public class StateController : Controller
    {
        private readonly ApplicationDbContext _Context;

        public StateController(ApplicationDbContext context)
        {
            _Context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _Context.StateModels.ToListAsync());
        }
    }
}
