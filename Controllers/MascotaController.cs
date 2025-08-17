using Microsoft.AspNetCore.Mvc;
using ListaDeCompras.Data;
using ListaDeCompras.Models;

namespace ListaDeCompras.Controllers
{

    public class MascotaController : Controller
    {
        private readonly ApplicationDbContext _context;
        public MascotaController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]

        public async Task<IActionResult> Create(Mascota mascota)
        {

            if (ModelState.IsValid)
            {
                mascota.FechaCompraAlimento = DateTime.Now; 
                _context.Add(mascota);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mascota);
        }
    }
}
