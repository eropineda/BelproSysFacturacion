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

        //Http Get Create 
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Models.CountyModels county)
        {
            if (ModelState.IsValid)
            {
                _Context.CountyModels.Add(county);
                await _Context.SaveChangesAsync();

                TempData["mensaje"] = "Registro Guardado Correctamente";


                return RedirectToAction("Index");
            }

            return View();
        }

        //http get edit
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();

            }

            // //obtener municipio

            var vcustomerType = _Context.CountyModels.Find(id);

            if (vcustomerType == null)
            {
                return NotFound();
            }

            return View(vcustomerType);
            // return View();
        }


        //Http Post Create 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Models.CountyModels county)
        {
            if (ModelState.IsValid)
            {

                _Context.CountyModels.Update(county);
                await _Context.SaveChangesAsync();

                TempData["mensaje"] = "Registro Actualizado Correctamente";


                return RedirectToAction("Index");
            }

            return View();
        }

        //http get edit
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();

            }

            // //obtener municipio

            var vcustomerType = _Context.CountyModels.Find(id);

            if (vcustomerType == null)
            {
                return NotFound();
            }

            return View(vcustomerType);
            // return View();
        }

        //Http Post Delete 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCounty(int? id)
        {
            //obtener el libro por id

            var vDeleteCounty = await _Context.CountyModels.FindAsync(id);


            if (vDeleteCounty == null)
            {
                return NotFound();
            }

            _Context.CountyModels.Remove(vDeleteCounty);
            await _Context.SaveChangesAsync();

            TempData["mensaje"] = "Registro Eliminado Correctamente";
            return RedirectToAction("Index");




        }
    }
}
