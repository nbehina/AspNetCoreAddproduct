using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreAddproduct.Models;
using AspNetCoreAddproduct.Services;
using Microsoft.AspNetCore.Mvc;
namespace AspNetCoreAddproduct.Controllers
{
    public class AddproductController : Controller
    {
        private readonly IAddproductItemService _AddproductItemService;
        public AddproductController(IAddproductItemService AddproductItemService)
        {
            _AddproductItemService = AddproductItemService;
        }

        public async Task<IActionResult> Index()
        {
            var items = await _AddproductItemService.GetIncompleteItemsAsync();
            // Get add-product items from database
            // Put items into a model
            // Pass the view to a model and render
            var model = new AddproductViewModel()
            {
                Items = items
            };
            return View(model);
        }
       // [ValidateAntiForgeryToken]
        //public async Task<IActionResult> AddItem(AddproductItem newItem)
        //{
            //if (!ModelState.IsValid)
           // {
               // return RedirectToAction("Index");
            //}
            //var successful = await _AddproductItemService.AddItemAsync(newItem);
           // if (!successful)
            //{
                //return BadRequest("Could not add item.");
            //}
            //return RedirectToAction("Index");
        //}


    }

}





