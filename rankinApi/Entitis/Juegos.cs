namespace rankinApi.Entitis
{
    public class Juegos
    {
        public int Id { get; set; }
       
        public string Nombre { get; set; }

        public ICollection<Jugador> Jugadores { get; set; }
    }
}
