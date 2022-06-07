using BelproSysFacturacion.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BelproSysFacturacion.Controllers
{
    public class CountryController : Controller
    {
        private readonly ApplicationDbContext _Context;

        public CountryController(ApplicationDbContext context)
        {
            _Context = context;
        }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await _Context.CountryModels.ToListAsync());
        }

        //Http Get Create 
        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Models.CountryModels country)
        {
            if (ModelState.IsValid)
            {
                _Context.CountryModels.Add(country);
                await _Context.SaveChangesAsync();

                TempData["mensaje"] = "Registro Guardado Correctamente";


                return RedirectToAction("Index");
            }

            return View();
        }



        //http get edit
        [HttpGet]
        public async Task<IActionResult> Edit(string? CountryISO)
        {
            if (CountryISO == null)
            {
                return NotFound();

            }

            //obtener Pais

            var vCountry= await _Context.CountryModels.FindAsync(CountryISO);

            if (vCountry == null)
            {
                return NotFound();
            }

            return View(vCountry);
            // return View();
        }



        ////Http Post Create 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Models.CountryModels country)
        {
            if (ModelState.IsValid)
            {
                _Context.CountryModels.Update(country);
                await _Context.SaveChangesAsync();

                TempData["mensaje"] = "Registro Actualizado Correctamente";


                return RedirectToAction("Index");
            }

            return View();
        }


        //http get edit
        [HttpGet]
        public async Task<IActionResult> Delete(string? CountryISO)
        {
            if (CountryISO == null)
            {
                return NotFound();

            }

            //obtener Pais

            var vCountry = await _Context.CountryModels.FindAsync(CountryISO);

            if (vCountry == null)
            {
                return NotFound();
            }

            return View(vCountry);
            // return View();
        }

        //Http Post Delete 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteCountry(string? CountryISO)
        {
            //obtener el libro por id

            var vDeleteCounty = await _Context.CountryModels.FindAsync(CountryISO);


            if (vDeleteCounty == null)
            {
                return NotFound();
            }

            _Context.CountryModels.Remove(vDeleteCounty);
            await _Context.SaveChangesAsync();

            TempData["mensaje"] = "Registro Eliminado Correctamente";
            return RedirectToAction("Index");




        }


    }
}
