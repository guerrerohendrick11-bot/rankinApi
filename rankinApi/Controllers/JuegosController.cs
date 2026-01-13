using Microsoft.AspNetCore.Mvc;
using rankinApi.DTOs;
using rankinApi.Services.IServices;

[ApiController]
[Route("api/juegos")]
public class JuegoController : ControllerBase
{
    private readonly IJuegoService _service;

    public JuegoController(IJuegoService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
        => Ok(await _service.GetAll());

    [HttpPost]
    public async Task<IActionResult> Post(CrearJuegoDto dto)
    {
        await _service.Crear(dto);
        return Ok();
    }
}
