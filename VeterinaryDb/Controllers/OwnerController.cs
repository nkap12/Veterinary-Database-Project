using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VeterinaryDb.Data;

namespace VeterinaryDb.Controllers
{

    public class OwnerController : Controller
    {

        private readonly ApplicationDbContext _context;

        public OwnerController(ApplicationDbContext context)
        {
            _context = context;
        }



        // GET: Class
        public async Task<IActionResult> Index()
        {
            if (_context.Owners == null)
            {
                return NotFound();
            }

            var model = _context.Owners.ToList();
            return View(model);
        }

    }

}