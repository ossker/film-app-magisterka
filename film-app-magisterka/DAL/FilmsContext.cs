using film_app_magisterka.Models;
using Microsoft.EntityFrameworkCore;

namespace film_app_magisterka.DAL
{
    public class FilmsContext : DbContext
    {
        public DbSet<Film> Films { get; set; }

        public DbSet<Category> Categories { get; set; }

        public FilmsContext(DbContextOptions<FilmsContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var categories = new List<Category>()
             {
                  new Category { CategoryId = 1, Name = "Akcja", Desc = "Filmy pełne dynamicznych scen i efektów specjalnych." },
                 new Category { CategoryId = 2, Name = "Komedia", Desc = "Filmy dostarczające dużą dawkę humoru i rozrywki." },
                 new Category { CategoryId = 3, Name = "Dramat", Desc = "Filmy o poważnej tematyce, często poruszające trudne tematy." },
                 new Category { CategoryId = 4, Name = "Horror", Desc = "Filmy mające na celu wywołanie strachu i napięcia." },
                 new Category { CategoryId = 5, Name = "Sci-Fi", Desc = "Filmy opowiadające o przyszłości, technologii i kosmosie." },
                 new Category { CategoryId = 6, Name = "Fantasy", Desc = "Filmy osadzone w magicznych światach, pełne nadprzyrodzonych zjawisk." },
                 new Category { CategoryId = 7, Name = "Thriller", Desc = "Filmy pełne napięcia, zagadek i zwrotów akcji." },
                 new Category { CategoryId = 8, Name = "Animacja", Desc = "Filmy animowane, często skierowane do dzieci i rodzin." },
                 new Category { CategoryId = 9, Name = "Dokument", Desc = "Filmy przedstawiające prawdziwe wydarzenia i historie." },
                 new Category { CategoryId = 10, Name = "Musical", Desc = "Filmy, w których ważnym elementem są piosenki i taniec." }
             };

            var films = new List<Film>()
             {
                 new Film { FilmId = 1, Poster="poster_1.jpg", Title = "Mad Max: Na drodze gniewu", Director = "George Miller", Description = "Postapokaliptyczna walka o przetrwanie.", Price = 29.99m, CategoryId = 1 },
             new Film { FilmId = 2, Poster="poster_2.jpg", Title = "Deadpool", Director = "Tim Miller", Description = "Niepoprawny komediowy antybohater.", Price = 24.99m, CategoryId = 2 },
             new Film { FilmId = 3, Poster="poster_3.jpg", Title = "Forrest Gump", Director = "Robert Zemeckis", Description = "Historia niezwykłego człowieka o wielkim sercu.", Price = 19.99m, CategoryId = 3 },
             new Film { FilmId = 4, Poster="poster_4.jpg", Title = "Lśnienie", Director = "Stanley Kubrick", Description = "Przerażająca historia hotelu i jego mieszkańców.", Price = 22.99m, CategoryId = 4 },
             new Film { FilmId = 5, Poster="poster_5.jpg", Title = "Interstellar", Director = "Christopher Nolan", Description = "Podróż w nieznane w poszukiwaniu nowego domu.", Price = 34.99m, CategoryId = 5 },
             new Film { FilmId = 6, Poster="poster_6.jpg", Title = "Władca Pierścieni: Drużyna Pierścienia", Director = "Peter Jackson", Description = "Początek epickiej przygody w Śródziemiu.", Price = 39.99m, CategoryId = 6 },
             new Film { FilmId = 7, Poster="poster_7.jpg", Title = "Zaginiona dziewczyna", Director = "David Fincher", Description = "Mroczny thriller pełen zwrotów akcji.", Price = 26.99m, CategoryId = 7 },
             new Film { FilmId = 8, Poster="poster_8.jpg", Title = "Kraina Lodu", Director = "Chris Buck, Jennifer Lee", Description = "Magiczna opowieść o sile siostrzanej miłości.", Price = 19.99m, CategoryId = 8 },
             new Film { FilmId = 9, Poster="poster_9.jpg", Title = "13th", Director = "Ava DuVernay", Description = "Dokument o systemowym rasizmie w USA.", Price = 14.99m, CategoryId = 9 },
             new Film { FilmId = 10, Poster="poster_10.jpg", Title = "La La Land", Director = "Damien Chazelle", Description = "Muzyczna opowieść o miłości i marzeniach.", Price = 29.99m, CategoryId = 10 },
             new Film { FilmId = 11, Poster="poster_11.jpg", Title = "John Wick", Director = "Chad Stahelski", Description = "Zemsta na najwyższym poziomie.", Price = 27.99m, CategoryId = 1 },
             new Film { FilmId = 12, Poster="poster_12.jpg", Title = "Kac Vegas", Director = "Todd Phillips", Description = "Zwariowana komedia o nieprzewidywalnej imprezie.", Price = 21.99m, CategoryId = 2 },
             new Film { FilmId = 13, Poster="poster_13.jpg", Title = "Gladiator", Director = "Ridley Scott", Description = "Epicka historia honoru i zemsty.", Price = 31.99m, CategoryId = 3 },
             new Film { FilmId = 14, Poster="poster_14.jpg", Title = "Obecność", Director = "James Wan", Description = "Paranormalne śledztwo na farmie.", Price = 18.99m, CategoryId = 4 },
             new Film { FilmId = 15, Poster="poster_15.jpg", Title = "Blade Runner 2049", Director = "Denis Villeneuve", Description = "Kultowy cyberpunkowy świat.", Price = 32.99m, CategoryId = 5 },
             new Film { FilmId = 16, Poster="poster_16.jpg", Title = "Harry Potter i Kamień Filozoficzny", Director = "Chris Columbus", Description = "Początek przygód młodego czarodzieja.", Price = 24.99m, CategoryId = 6 },
             new Film { FilmId = 17, Poster="poster_17.jpg", Title = "Siedem", Director = "David Fincher", Description = "Psychopatyczny morderca i jego makabryczna gra.", Price = 28.99m, CategoryId = 7 },
             new Film { FilmId = 18, Poster="poster_18.jpg", Title = "Toy Story", Director = "John Lasseter", Description = "Przygody zabawek, które żyją własnym życiem.", Price = 20.99m, CategoryId = 8 },
             new Film { FilmId = 19, Poster="poster_19.jpg", Title = "Człowiek na Księżycu", Director = "Todd Douglas Miller", Description = "Dokument o pierwszym lądowaniu na Księżycu.", Price = 17.99m, CategoryId = 9 },
             new Film { FilmId = 20, Poster="poster_20.jpg", Title = "Mamma Mia!", Director = "Phyllida Lloyd", Description = "Musical pełen hitów ABBY.", Price = 23.99m, CategoryId = 10 }
             };

            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Film>().HasData(films);
        }

    }
}
