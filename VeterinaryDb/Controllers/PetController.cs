using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VeterinaryDb.Data;

namespace VeterinaryDb.Controllers
{
    public class PetController : Controller
    {

        private readonly ApplicationDbContext _context;

        public PetController(ApplicationDbContext context)
        {
            _context = context;
        }



        // GET: Class
        public async Task<IActionResult> Index()
        {
            if (_context.Pets == null)
            {
                return NotFound();
            }

            var model = _context.Pets.ToList();
            return View(model);
        }

       
    }
}


