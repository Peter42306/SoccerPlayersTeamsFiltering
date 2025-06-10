using Microsoft.EntityFrameworkCore;

namespace Soccer.Models
{   
    public class SoccerContext : DbContext
    {
        public SoccerContext(DbContextOptions<SoccerContext> options)
            : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Teams>().HasData(
                new Teams { Id = 1, Name = "Liverpool", Coach = "Arne Slot" },
                new Teams { Id = 2, Name = "Dynamo Kyiv", Coach = "Oleksandr Shovkovskyi" },
                new Teams { Id = 3, Name = "Barcelona", Coach = "Hansi Flick" },
                new Teams { Id = 4, Name = "Bayern Munich", Coach = "Vincent Kompany" },
                new Teams { Id = 5, Name = "Paris Saint-Germain", Coach = "Luis Enrique" },
                new Teams { Id = 6, Name = "Manchester City", Coach = "Pep Guardiola" },
                new Teams { Id = 7, Name = "Everton", Coach = "Sean Dyche" }, // всё ещё он
                new Teams { Id = 8, Name = "Real Madrid", Coach = "Carlo Ancelotti" },
                new Teams { Id = 9, Name = "Napoli", Coach = "Francesco Calzona" }
            );

            modelBuilder.Entity<Players>().HasData(
                // Liverpool – TeamId = 1
                new Players { Id = 1, Name = "Mohamed Salah", Age = 31, Position = "Forward", TeamId = 1 },
                new Players { Id = 2, Name = "Alisson Becker", Age = 31, Position = "Goalkeeper", TeamId = 1 },
                new Players { Id = 3, Name = "Virgil van Dijk", Age = 32, Position = "Defender", TeamId = 1 },
                new Players { Id = 4, Name = "Trent Alexander-Arnold", Age = 25, Position = "Defender", TeamId = 1 },
                new Players { Id = 5, Name = "Andrew Robertson", Age = 29, Position = "Defender", TeamId = 1 },
                new Players { Id = 6, Name = "Alexis Mac Allister", Age = 25, Position = "Midfielder", TeamId = 1 },
                new Players { Id = 7, Name = "Curtis Jones", Age = 23, Position = "Midfielder", TeamId = 1 },
                new Players { Id = 8, Name = "Darwin Núñez", Age = 25, Position = "Forward", TeamId = 1 },
                new Players { Id = 9, Name = "Luis Díaz", Age = 27, Position = "Forward", TeamId = 1 },
                new Players { Id = 10, Name = "Ibrahima Konaté", Age = 25, Position = "Defender", TeamId = 1 },
                new Players { Id = 11, Name = "Dominik Szoboszlai", Age = 23, Position = "Midfielder", TeamId = 1 },

                // Dynamo Kyiv – TeamId = 2
                new Players { Id = 12, Name = "Heorhiy Bushchan", Age = 30, Position = "Goalkeeper", TeamId = 2 },
                new Players { Id = 13, Name = "Oleksandr Karavayev", Age = 31, Position = "Defender", TeamId = 2 },
                new Players { Id = 14, Name = "Vitalii Mykolenko", Age = 24, Position = "Defender", TeamId = 2 },
                new Players { Id = 15, Name = "Sydorchuk Serhiy", Age = 33, Position = "Midfielder", TeamId = 2 },
                new Players { Id = 16, Name = "Volodymyr Brazhko", Age = 21, Position = "Midfielder", TeamId = 2 },
                new Players { Id = 17, Name = "Vladyslav Vanat", Age = 22, Position = "Forward", TeamId = 2 },
                new Players { Id = 18, Name = "Oleksandr Tymchyk", Age = 27, Position = "Defender", TeamId = 2 },
                new Players { Id = 19, Name = "Illia Zabarnyi", Age = 21, Position = "Defender", TeamId = 2 },
                new Players { Id = 20, Name = "Vitaliy Buyalskyi", Age = 30, Position = "Midfielder", TeamId = 2 },
                new Players { Id = 21, Name = "Andriy Yarmolenko", Age = 34, Position = "Forward", TeamId = 2 },
                new Players { Id = 22, Name = "Mykola Shaparenko", Age = 25, Position = "Midfielder", TeamId = 2 },

                // Barcelona – TeamId = 3
                new Players { Id = 23, Name = "Marc-André ter Stegen", Age = 32, Position = "Goalkeeper", TeamId = 3 },
                new Players { Id = 24, Name = "Ronald Araújo", Age = 25, Position = "Defender", TeamId = 3 },
                new Players { Id = 25, Name = "João Cancelo", Age = 30, Position = "Defender", TeamId = 3 },
                new Players { Id = 26, Name = "Jules Koundé", Age = 26, Position = "Defender", TeamId = 3 },
                new Players { Id = 27, Name = "Pedri", Age = 22, Position = "Midfielder", TeamId = 3 },
                new Players { Id = 28, Name = "Gavi", Age = 20, Position = "Midfielder", TeamId = 3 },
                new Players { Id = 29, Name = "Frenkie de Jong", Age = 27, Position = "Midfielder", TeamId = 3 },
                new Players { Id = 30, Name = "Robert Lewandowski", Age = 36, Position = "Forward", TeamId = 3 },
                new Players { Id = 31, Name = "Lamine Yamal", Age = 17, Position = "Forward", TeamId = 3 },
                new Players { Id = 32, Name = "Ferran Torres", Age = 24, Position = "Forward", TeamId = 3 },
                new Players { Id = 33, Name = "Oriol Romeu", Age = 32, Position = "Midfielder", TeamId = 3 },

                // Bayern Munich – TeamId = 4
                new Players { Id = 34, Name = "Manuel Neuer", Age = 38, Position = "Goalkeeper", TeamId = 4 },
                new Players { Id = 35, Name = "Benjamin Pavard", Age = 28, Position = "Defender", TeamId = 4 },
                new Players { Id = 36, Name = "Matthijs de Ligt", Age = 25, Position = "Defender", TeamId = 4 },
                new Players { Id = 37, Name = "Alphonso Davies", Age = 24, Position = "Defender", TeamId = 4 },
                new Players { Id = 38, Name = "Joshua Kimmich", Age = 30, Position = "Midfielder", TeamId = 4 },
                new Players { Id = 39, Name = "Leon Goretzka", Age = 29, Position = "Midfielder", TeamId = 4 },
                new Players { Id = 40, Name = "Jamal Musiala", Age = 22, Position = "Midfielder", TeamId = 4 },
                new Players { Id = 41, Name = "Thomas Müller", Age = 35, Position = "Forward", TeamId = 4 },
                new Players { Id = 42, Name = "Harry Kane", Age = 31, Position = "Forward", TeamId = 4 },
                new Players { Id = 43, Name = "Leroy Sané", Age = 29, Position = "Forward", TeamId = 4 },
                new Players { Id = 44, Name = "Dayot Upamecano", Age = 26, Position = "Defender", TeamId = 4 },

                // PSG – TeamId = 5
                new Players { Id = 45, Name = "Gianluigi Donnarumma", Age = 26, Position = "Goalkeeper", TeamId = 5 },
                new Players { Id = 46, Name = "Achraf Hakimi", Age = 26, Position = "Defender", TeamId = 5 },
                new Players { Id = 47, Name = "Milan Škriniar", Age = 29, Position = "Defender", TeamId = 5 },
                new Players { Id = 48, Name = "Lucas Hernández", Age = 29, Position = "Defender", TeamId = 5 },
                new Players { Id = 49, Name = "Vitinha", Age = 25, Position = "Midfielder", TeamId = 5 },
                new Players { Id = 50, Name = "Fabián Ruiz", Age = 28, Position = "Midfielder", TeamId = 5 },
                new Players { Id = 51, Name = "Ousmane Dembélé", Age = 26, Position = "Forward", TeamId = 5 },
                new Players { Id = 52, Name = "Kylian Mbappé", Age = 25, Position = "Forward", TeamId = 5 },
                new Players { Id = 53, Name = "Randal Kolo Muani", Age = 25, Position = "Forward", TeamId = 5 },
                new Players { Id = 54, Name = "Neymar", Age = 32, Position = "Forward", TeamId = 5 },
                new Players { Id = 55, Name = "Bradley Barcola", Age = 22, Position = "Forward", TeamId = 5 },

                // Man City – TeamId = 6
                new Players { Id = 56, Name = "Ederson", Age = 31, Position = "Goalkeeper", TeamId = 6 },
                new Players { Id = 57, Name = "Rúben Dias", Age = 27, Position = "Defender", TeamId = 6 },
                new Players { Id = 58, Name = "Kyle Walker", Age = 34, Position = "Defender", TeamId = 6 },
                new Players { Id = 59, Name = "Nathan Aké", Age = 30, Position = "Defender", TeamId = 6 },
                new Players { Id = 60, Name = "Rodri", Age = 29, Position = "Midfielder", TeamId = 6 },
                new Players { Id = 61, Name = "Bernardo Silva", Age = 30, Position = "Midfielder", TeamId = 6 },
                new Players { Id = 62, Name = "Kevin De Bruyne", Age = 33, Position = "Midfielder", TeamId = 6 },
                new Players { Id = 63, Name = "Phil Foden", Age = 24, Position = "Forward", TeamId = 6 },
                new Players { Id = 64, Name = "Erling Haaland", Age = 25, Position = "Forward", TeamId = 6 },
                new Players { Id = 65, Name = "Jack Grealish", Age = 29, Position = "Forward", TeamId = 6 },
                new Players { Id = 66, Name = "Julián Álvarez", Age = 25, Position = "Forward", TeamId = 6 },

                // Everton – TeamId = 7
                new Players { Id = 67, Name = "Jordan Pickford", Age = 31, Position = "Goalkeeper", TeamId = 7 },
                new Players { Id = 68, Name = "James Tarkowski", Age = 32, Position = "Defender", TeamId = 7 },
                new Players { Id = 69, Name = "Ben Godfrey", Age = 27, Position = "Defender", TeamId = 7 },
                new Players { Id = 70, Name = "Vitalii Mykolenko", Age = 25, Position = "Defender", TeamId = 7 },
                new Players { Id = 71, Name = "Idrissa Gueye", Age = 34, Position = "Midfielder", TeamId = 7 },
                new Players { Id = 72, Name = "Abdoulaye Doucouré", Age = 31, Position = "Midfielder", TeamId = 7 },
                new Players { Id = 73, Name = "Amadou Onana", Age = 23, Position = "Midfielder", TeamId = 7 },
                new Players { Id = 74, Name = "Dwight McNeil", Age = 26, Position = "Forward", TeamId = 7 },
                new Players { Id = 75, Name = "Dominic Calvert-Lewin", Age = 28, Position = "Forward", TeamId = 7 },
                new Players { Id = 76, Name = "Arnaut Danjuma", Age = 28, Position = "Forward", TeamId = 7 },
                new Players { Id = 77, Name = "Beto", Age = 27, Position = "Forward", TeamId = 7 },

                // Real Madrid – TeamId = 8
                new Players { Id = 78, Name = "Thibaut Courtois", Age = 33, Position = "Goalkeeper", TeamId = 8 },
                new Players { Id = 79, Name = "Antonio Rüdiger", Age = 32, Position = "Defender", TeamId = 8 },
                new Players { Id = 80, Name = "Éder Militão", Age = 27, Position = "Defender", TeamId = 8 },
                new Players { Id = 81, Name = "David Alaba", Age = 32, Position = "Defender", TeamId = 8 },
                new Players { Id = 82, Name = "Aurélien Tchouaméni", Age = 25, Position = "Midfielder", TeamId = 8 },
                new Players { Id = 83, Name = "Federico Valverde", Age = 27, Position = "Midfielder", TeamId = 8 },
                new Players { Id = 84, Name = "Jude Bellingham", Age = 22, Position = "Midfielder", TeamId = 8 },
                new Players { Id = 85, Name = "Luka Modrić", Age = 39, Position = "Midfielder", TeamId = 8 },
                new Players { Id = 86, Name = "Vinícius Júnior", Age = 25, Position = "Forward", TeamId = 8 },
                new Players { Id = 87, Name = "Rodrygo", Age = 24, Position = "Forward", TeamId = 8 },
                new Players { Id = 88, Name = "Joselu", Age = 35, Position = "Forward", TeamId = 8 },

                // Napoli – TeamId = 9
                new Players { Id = 89, Name = "Alex Meret", Age = 28, Position = "Goalkeeper", TeamId = 9 },
                new Players { Id = 90, Name = "Giovanni Di Lorenzo", Age = 31, Position = "Defender", TeamId = 9 },
                new Players { Id = 91, Name = "Amir Rrahmani", Age = 30, Position = "Defender", TeamId = 9 },
                new Players { Id = 92, Name = "Mário Rui", Age = 33, Position = "Defender", TeamId = 9 },
                new Players { Id = 93, Name = "Stanislav Lobotka", Age = 29, Position = "Midfielder", TeamId = 9 },
                new Players { Id = 94, Name = "Piotr Zieliński", Age = 30, Position = "Midfielder", TeamId = 9 },
                new Players { Id = 95, Name = "Khvicha Kvaratskhelia", Age = 23, Position = "Forward", TeamId = 9 },
                new Players { Id = 96, Name = "Victor Osimhen", Age = 25, Position = "Forward", TeamId = 9 },
                new Players { Id = 97, Name = "Matteo Politano", Age = 31, Position = "Forward", TeamId = 9 },
                new Players { Id = 98, Name = "Jesper Lindstrøm", Age = 24, Position = "Forward", TeamId = 9 },
                new Players { Id = 99, Name = "Diego Demme", Age = 32, Position = "Midfielder", TeamId = 9 }
            );

        }


        public DbSet<Players> Players { get; set; }
        public DbSet<Teams> Teams { get; set; }
    }
}
