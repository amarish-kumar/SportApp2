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
    public class FoodController : ApiControllerBase
    {
        private readonly IFoodService _foodService;
        private readonly IMemoryCache _cache;

        public FoodController(IFoodService foodService, IMemoryCache cache)
        {
            _foodService = foodService;
            _cache = cache;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Json(_foodService.GetAllAsync());
        }

        //[HttpGet]
        //public async Task<IActionResult> Get(string name)
        //{
        //    var foods = _cache.Get<IEnumerable<FoodDto>>("foods");
        //    if(foods == null)
        //    {
        //        Console.WriteLine("Fetching from service");
        //        foods = await _foodService.BrowseAsync(name);
        //        _cache.Set("events", foods, TimeSpan.FromMinutes(1));
        //    }
        //    else
        //    {
        //        Console.WriteLine("Fetching from cache");
        //    }

        //    return Json(foods);
        //}

        [HttpGet("{foodId}")]
        public async Task<IActionResult> Get(Guid foodId)
        {
            var @food = await _foodService.GetAsync(foodId);
            if(@food == null)
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

                return RedirectToAction(nameof(Get));
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

                return RedirectToAction(nameof(Get));
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

                return RedirectToAction(nameof(Get));
            }
            catch
            {
                return View();
            }
        }
    }
}