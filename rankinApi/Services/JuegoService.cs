using Microsoft.EntityFrameworkCore;
using rankinApi.DTOs;
using rankinApi.Entitis;
using rankinApi.Services.IServices;

public class JuegoService : IJuegoService
{
    private readonly AppDbContext _context;

    public JuegoService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<JuegoDto>> GetAll()
    {
        return await _context.Juegos
            .Select(x => new JuegoDto
            {
                Id = x.Id,
                Nombre = x.Nombre
            }).ToListAsync();
    }

    public async Task Crear(CrearJuegoDto dto)
    {
        var juego = new Juegos { Nombre = dto.Nombre };
        _context.Juegos.Add(juego);
        await _context.SaveChangesAsync();
    }
}
