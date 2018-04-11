using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using SportApp2.Infrastructure.DTO;
using SportApp2.Infrastructure.Services;

namespace SportApp2.Controllers
{
    [Produces("application/json")]
    [Route("api/food")]
    public class FoodTypeController : Controller
    {
        private readonly IFoodTypeService _foodTypeService;
        private readonly IMemoryCache _cache;

        public FoodTypeController(IFoodTypeService foodTypeService, IMemoryCache cache)
        {
            _foodTypeService = foodTypeService;
            _cache = cache;
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> GetFoodTypes()
        {
            var foodTypes = _cache.Get<IEnumerable<FoodTypeDto>>("foodTypes");
            if (foodTypes == null)
            {
                Console.WriteLine("Fetching from service");
                foodTypes = await _foodTypeService.BrowseAsync(null);
                _cache.Set("foodTypes", foodTypes, TimeSpan.FromMinutes(1));
            }
            else
            {
                Console.WriteLine("Fetching from cache");
            }

            return Json(foodTypes);
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> GetFoodType(Guid foodTypeId)
        {
            var @food = await _foodTypeService.GetAsync(foodTypeId);
            if (@food == null)
            {
                return NotFound();
            }

            return Json(@food);
        }

        // GET: Food/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Food/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(GetFoodTypes));
            }
            catch
            {
                return View();
            }
        }

        // GET: Food/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Food/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(GetFoodTypes));
            }
            catch
            {
                return View();
            }
        }

        // GET: Food/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Food/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(GetFoodTypes));
            }
            catch
            {
                return View();
            }
        }
    }
}