using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using WebAppSAT.Models;

public class ReceptorController : Controller
{
    private readonly ApplicationDbContext _context;

    public ReceptorController(ApplicationDbContext context)
    {
        _context = context;
    }

    
    public async Task<IActionResult> Index(string termino)
    {
        List<Receptor> receptores = new List<Receptor>();

        if (!string.IsNullOrEmpty(termino))
        {
            receptores = await _context.Receptores
                .Where(r => r.Nombre.Contains(termino) || r.RFC.Contains(termino))
                .ToListAsync();
        }

        ViewBag.Termino = termino;
        return View("Index", receptores);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Create(Receptor receptor)
    {
        if (ModelState.IsValid)
        {
            _context.Receptores.Add(receptor);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        return View(receptor);
    }
}