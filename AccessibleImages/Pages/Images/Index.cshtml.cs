using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AccessibleImages.Data;
using AccessibleImages.Models;

namespace AccessibleImages.Pages.Images
{
    public class IndexModel : PageModel
    {
        private readonly AccessibleImages.Data.AccessibleImagesContext _context;

        public IndexModel(AccessibleImages.Data.AccessibleImagesContext context)
        {
            _context = context;
        }

        public IList<Image> Image { get;set; }

        public async Task OnGetAsync()
        {
            Image = await _context.Image.ToListAsync();
        }
    }
}
