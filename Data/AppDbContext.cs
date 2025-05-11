using CineMaisTurbo.Models;
using CineTurbo.Models;
using Microsoft.EntityFrameworkCore;

namespace CineTurbo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) {}

        public DbSet<Filme> FilmesDB { get; set; }
        public DbSet<Serie> SeriesDB { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Filme>().HasData(
                new Filme
                {
                    Id = 1,
                    Nome = "Matrix",
                    Sinopse = "Um hacker descobre a verdade sobre sua realidade.",
                    AvaliacaoImdb = 87,
                    AvaliacaoTomates = 88,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/1aadn0aD7h1VKq4yap2uKl7cTSL.jpg",
                    Genero = "FiccaoCientifica",
                    Avaliacao = 5,
                    Duracao = "2h 16min",
                    Lancamento = new DateTime(1999, 3, 31)
                },
                new Filme
                {
                    Id = 2,
                    Nome = "Matrix",
                    Sinopse = "Um hacker descobre a verdade sobre sua realidade.",
                    AvaliacaoImdb = 87,
                    AvaliacaoTomates = 88,
                    Foto = "https://www.themoviedb.org/t/p/w1280/9e3Dz7aCANy5aRUQF745IlNloJ1.jpg",
                    Genero = "FiccaoCientifica",
                    Avaliacao = 5,
                    Duracao = "2h 16min",
                    Lancamento = new DateTime(1999, 3, 31)
                },
                new Filme
                {
                    Id = 3,
                    Nome = "Matrix",
                    Sinopse = "Um hacker descobre a verdade sobre sua realidade.",
                    AvaliacaoImdb = 87,
                    AvaliacaoTomates = 88,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/4lj1ikfsSmMZNyfdi8R8Tv5tsgb.jpg",
                    Genero = "FiccaoCientifica",
                    Avaliacao = 5,
                    Duracao = "2h 16min",
                    Lancamento = new DateTime(1999, 3, 31)
                },
                new Filme
                {
                    Id = 4,
                    Nome = "O Senhor dos Anéis: A Sociedade do Anel",
                    Sinopse = "Um hobbit embarca em uma jornada épica para destruir um anel maligno.",
                    AvaliacaoImdb = 88,
                    AvaliacaoTomates = 91,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/qVf6lTFzDsBZUbYbk8m9dk9SipX.jpg",
                    Genero = "Fantasia",
                    Avaliacao = 5,
                    Duracao = "2h 58min",
                    Lancamento = new DateTime(2001, 12, 19)
                },
                new Filme
                {
                    Id = 5,
                    Nome = "O Senhor dos Anéis: A Sociedade do Anel",
                    Sinopse = "Um hobbit embarca em uma jornada épica para destruir um anel maligno.",
                    AvaliacaoImdb = 88,
                    AvaliacaoTomates = 91,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/x5hsAHiwLQrM7jlSZzR7AdWZquk.jpg",
                    Genero = "Fantasia",
                    Avaliacao = 5,
                    Duracao = "2h 58min",
                    Lancamento = new DateTime(2001, 12, 19)
                },
                new Filme
                {
                    Id = 6,
                    Nome = "O Senhor dos Anéis: A Sociedade do Anel",
                    Sinopse = "Um hobbit embarca em uma jornada épica para destruir um anel maligno.",
                    AvaliacaoImdb = 88,
                    AvaliacaoTomates = 91,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/TpcNor0WkmD1SBO3n3tlkQqmOf.jpg",
                    Genero = "Fantasia",
                    Avaliacao = 5,
                    Duracao = "2h 58min",
                    Lancamento = new DateTime(2001, 12, 19)
                },
                new Filme
                {
                    Id = 7,
                    Nome = "O Senhor dos Anéis: A Sociedade do Anel",
                    Sinopse = "Um hobbit embarca em uma jornada épica para destruir um anel maligno.",
                    AvaliacaoImdb = 88,
                    AvaliacaoTomates = 91,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/wd9fppMrD3KbH8jAMTqCF28QejD.jpg",
                    Genero = "Fantasia",
                    Avaliacao = 5,
                    Duracao = "2h 58min",
                    Lancamento = new DateTime(2001, 12, 19)
                },
                new Filme
                {
                    Id = 8,
                    Nome = "O Senhor dos Anéis: A Sociedade do Anel",
                    Sinopse = "Um hobbit embarca em uma jornada épica para destruir um anel maligno.",
                    AvaliacaoImdb = 88,
                    AvaliacaoTomates = 91,
                    Foto = "https://media.themoviedb.org/t/p/w600_and_h900_bestv2/9e0Yftt4svEI268iogQQdMXvng6.jpg",
                    Genero = "Fantasia",
                    Avaliacao = 5,
                    Duracao = "2h 58min",
                    Lancamento = new DateTime(2001, 12, 19)
                }
            );
        }
    }
}
