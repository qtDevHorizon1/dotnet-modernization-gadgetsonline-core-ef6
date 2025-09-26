
using System.Threading.Tasks;
using GadgetsOnline.Models;
using GadgetsOnline.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GadgetsOnline.ViewComponents
{
    public class CategoryMenuViewComponent : ViewComponent
    {
        private readonly IInventory _inventory;

        public CategoryMenuViewComponent(IInventory inventory)
        {
            _inventory = inventory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // TODO: Replace with the correct method from IInventory when available
            // The GetCategories method doesn't exist in IInventory interface
            IEnumerable<Category> categories = new List<Category>(); // Empty collection as fallback
            return View(categories);
        }
    }
}
