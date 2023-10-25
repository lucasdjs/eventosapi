using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;
using Back.src.ProEventos.API.Data;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    public EventoController(ApplicationDbContext context)
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
        return _context.Eventos.Where(x=>x.EventoId == id);
    }

    [HttpPost]
    public IActionResult Post(Evento evento)
    {
        _context.Eventos.Add(evento);
        return Ok(_context.SaveChanges());
    }

}
