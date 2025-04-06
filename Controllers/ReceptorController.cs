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
        var receptor = new Receptor
        {
            DireccionReceptor = new DireccionReceptor() 
        };
        return View(receptor);
    }

    [HttpPost]
    public async Task<IActionResult> Create(Receptor receptor)
    {
        if (!ModelState.IsValid)
        {
            
            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                Console.WriteLine(error.ErrorMessage);
            }
            return View(receptor);
        }

        if (receptor.DireccionReceptor != null)
        {
            receptor.DireccionReceptor.Receptor = receptor;
        }

        _context.Receptores.Add(receptor);
        await _context.SaveChangesAsync();
        return RedirectToAction("Index");
    }
}