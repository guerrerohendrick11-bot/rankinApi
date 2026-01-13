namespace rankinApi.Entitis
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Alias { get; set; }

        public int JuegosId { get; set; }
        public Juegos Juegos { get; set; }

        public ICollection<Ranking> Rankings { get; set; }
    }
}
