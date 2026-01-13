namespace rankinApi.Entitis
{
    public class Ranking
    {
        public int Id { get; set; }
        public int JugadorId { get; set; } 
        public Jugador Jugador { get; set; }

        public int Puntaje { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
