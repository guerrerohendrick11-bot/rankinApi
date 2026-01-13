using rankinApi.DTOs;

namespace rankinApi.Services.IServices
{
    public interface IJuegoService
    {
        Task<List<JuegoDto>> GetAll();
        Task Crear(CrearJuegoDto dto);
    }

}
