
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using GadgetsOnline.Models;
using GadgetsOnline.Services;

namespace GadgetsOnline.ViewComponents
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        private readonly IInventory _inventory;

        public CategoryMenuViewComponent(IInventory inventory)
        {
            _inventory = inventory;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _inventory.GetAllCategories();
            return View(categories);
        }
    }
}