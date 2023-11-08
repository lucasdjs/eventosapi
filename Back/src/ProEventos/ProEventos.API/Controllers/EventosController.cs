using Microsoft.AspNetCore.Mvc;
using ProEventos.Domain;
using ProEventos.Persistence.Context;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventosController : ControllerBase
{
    private readonly ProEventosContext _context;
    public EventosController(ProEventosContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _context.Eventos;
        }


    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _context.Eventos.Where(x=>x.Id == id);
    }

    [HttpPost]
    public IActionResult Post(Evento evento)
    {
        _context.Eventos.Add(evento);
        return Ok(_context.SaveChanges());
    }

}
