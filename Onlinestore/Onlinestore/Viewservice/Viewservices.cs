using Microsoft.AspNetCore.Mvc.Rendering;
using Onlinestore.Data;
using Onlinestore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Onlinestore.Viewservice
{
    public class Viewservices
    {
        private readonly ApplicationDbContext _context;
        public Viewservices(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<SelectListItem> GetSelectListItemsForCategories()
        {
            List<Category> listan = _context.Category.ToList();

            var b = new List<SelectListItem>();

            foreach (var item in listan)
            {
                var a = new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                };
                b.Add(a);
            }




            return b;
        }
    }
}

