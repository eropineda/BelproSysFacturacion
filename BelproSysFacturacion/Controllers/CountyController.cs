using BelproSysFacturacion.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BelproSysFacturacion.Controllers
{
    public class CountyController : Controller
    {
        private readonly ApplicationDbContext _Context;

        public CountyController(ApplicationDbContext context)
        {
            _Context = context;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _Context.CountyModels.ToListAsync());
        }
    }
}
