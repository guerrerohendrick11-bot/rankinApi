using Microsoft.EntityFrameworkCore;
using rankinApi.Entitis;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Juegos> Juegos { get; set; }
    public DbSet<Jugador> Jugadores { get; set; }
    public DbSet<Ranking> Rankings { get; set; }
}
