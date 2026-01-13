using RankingFromted.Models;
using System.Net.Http.Json;

namespace RankingFromted.Services
{
    public class JuegoApiService
    {
        private readonly HttpClient _http;

        public JuegoApiService(IHttpClientFactory factory)
        {
            _http = factory.CreateClient("Api");
        }

        public async Task<List<JuegoDto>> GetJuegosAsync()
        {
            return await _http.GetFromJsonAsync<List<JuegoDto>>("api/juego");
        }
    }
}
