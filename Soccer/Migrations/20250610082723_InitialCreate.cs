using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Soccer.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Coach = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    Position = table.Column<string>(type: "TEXT", nullable: true),
                    TeamId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Coach", "Name" },
                values: new object[,]
                {
                    { 1, "Arne Slot", "Liverpool" },
                    { 2, "Oleksandr Shovkovskyi", "Dynamo Kyiv" },
                    { 3, "Hansi Flick", "Barcelona" },
                    { 4, "Vincent Kompany", "Bayern Munich" },
                    { 5, "Luis Enrique", "Paris Saint-Germain" },
                    { 6, "Pep Guardiola", "Manchester City" },
                    { 7, "Sean Dyche", "Everton" },
                    { 8, "Carlo Ancelotti", "Real Madrid" },
                    { 9, "Francesco Calzona", "Napoli" }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Age", "Name", "Position", "TeamId" },
                values: new object[,]
                {
                    { 1, 31, "Mohamed Salah", "Forward", 1 },
                    { 2, 31, "Alisson Becker", "Goalkeeper", 1 },
                    { 3, 32, "Virgil van Dijk", "Defender", 1 },
                    { 4, 25, "Trent Alexander-Arnold", "Defender", 1 },
                    { 5, 29, "Andrew Robertson", "Defender", 1 },
                    { 6, 25, "Alexis Mac Allister", "Midfielder", 1 },
                    { 7, 23, "Curtis Jones", "Midfielder", 1 },
                    { 8, 25, "Darwin Núñez", "Forward", 1 },
                    { 9, 27, "Luis Díaz", "Forward", 1 },
                    { 10, 25, "Ibrahima Konaté", "Defender", 1 },
                    { 11, 23, "Dominik Szoboszlai", "Midfielder", 1 },
                    { 12, 30, "Heorhiy Bushchan", "Goalkeeper", 2 },
                    { 13, 31, "Oleksandr Karavayev", "Defender", 2 },
                    { 14, 24, "Vitalii Mykolenko", "Defender", 2 },
                    { 15, 33, "Sydorchuk Serhiy", "Midfielder", 2 },
                    { 16, 21, "Volodymyr Brazhko", "Midfielder", 2 },
                    { 17, 22, "Vladyslav Vanat", "Forward", 2 },
                    { 18, 27, "Oleksandr Tymchyk", "Defender", 2 },
                    { 19, 21, "Illia Zabarnyi", "Defender", 2 },
                    { 20, 30, "Vitaliy Buyalskyi", "Midfielder", 2 },
                    { 21, 34, "Andriy Yarmolenko", "Forward", 2 },
                    { 22, 25, "Mykola Shaparenko", "Midfielder", 2 },
                    { 23, 32, "Marc-André ter Stegen", "Goalkeeper", 3 },
                    { 24, 25, "Ronald Araújo", "Defender", 3 },
                    { 25, 30, "João Cancelo", "Defender", 3 },
                    { 26, 26, "Jules Koundé", "Defender", 3 },
                    { 27, 22, "Pedri", "Midfielder", 3 },
                    { 28, 20, "Gavi", "Midfielder", 3 },
                    { 29, 27, "Frenkie de Jong", "Midfielder", 3 },
                    { 30, 36, "Robert Lewandowski", "Forward", 3 },
                    { 31, 17, "Lamine Yamal", "Forward", 3 },
                    { 32, 24, "Ferran Torres", "Forward", 3 },
                    { 33, 32, "Oriol Romeu", "Midfielder", 3 },
                    { 34, 38, "Manuel Neuer", "Goalkeeper", 4 },
                    { 35, 28, "Benjamin Pavard", "Defender", 4 },
                    { 36, 25, "Matthijs de Ligt", "Defender", 4 },
                    { 37, 24, "Alphonso Davies", "Defender", 4 },
                    { 38, 30, "Joshua Kimmich", "Midfielder", 4 },
                    { 39, 29, "Leon Goretzka", "Midfielder", 4 },
                    { 40, 22, "Jamal Musiala", "Midfielder", 4 },
                    { 41, 35, "Thomas Müller", "Forward", 4 },
                    { 42, 31, "Harry Kane", "Forward", 4 },
                    { 43, 29, "Leroy Sané", "Forward", 4 },
                    { 44, 26, "Dayot Upamecano", "Defender", 4 },
                    { 45, 26, "Gianluigi Donnarumma", "Goalkeeper", 5 },
                    { 46, 26, "Achraf Hakimi", "Defender", 5 },
                    { 47, 29, "Milan Škriniar", "Defender", 5 },
                    { 48, 29, "Lucas Hernández", "Defender", 5 },
                    { 49, 25, "Vitinha", "Midfielder", 5 },
                    { 50, 28, "Fabián Ruiz", "Midfielder", 5 },
                    { 51, 26, "Ousmane Dembélé", "Forward", 5 },
                    { 52, 25, "Kylian Mbappé", "Forward", 5 },
                    { 53, 25, "Randal Kolo Muani", "Forward", 5 },
                    { 54, 32, "Neymar", "Forward", 5 },
                    { 55, 22, "Bradley Barcola", "Forward", 5 },
                    { 56, 31, "Ederson", "Goalkeeper", 6 },
                    { 57, 27, "Rúben Dias", "Defender", 6 },
                    { 58, 34, "Kyle Walker", "Defender", 6 },
                    { 59, 30, "Nathan Aké", "Defender", 6 },
                    { 60, 29, "Rodri", "Midfielder", 6 },
                    { 61, 30, "Bernardo Silva", "Midfielder", 6 },
                    { 62, 33, "Kevin De Bruyne", "Midfielder", 6 },
                    { 63, 24, "Phil Foden", "Forward", 6 },
                    { 64, 25, "Erling Haaland", "Forward", 6 },
                    { 65, 29, "Jack Grealish", "Forward", 6 },
                    { 66, 25, "Julián Álvarez", "Forward", 6 },
                    { 67, 31, "Jordan Pickford", "Goalkeeper", 7 },
                    { 68, 32, "James Tarkowski", "Defender", 7 },
                    { 69, 27, "Ben Godfrey", "Defender", 7 },
                    { 70, 25, "Vitalii Mykolenko", "Defender", 7 },
                    { 71, 34, "Idrissa Gueye", "Midfielder", 7 },
                    { 72, 31, "Abdoulaye Doucouré", "Midfielder", 7 },
                    { 73, 23, "Amadou Onana", "Midfielder", 7 },
                    { 74, 26, "Dwight McNeil", "Forward", 7 },
                    { 75, 28, "Dominic Calvert-Lewin", "Forward", 7 },
                    { 76, 28, "Arnaut Danjuma", "Forward", 7 },
                    { 77, 27, "Beto", "Forward", 7 },
                    { 78, 33, "Thibaut Courtois", "Goalkeeper", 8 },
                    { 79, 32, "Antonio Rüdiger", "Defender", 8 },
                    { 80, 27, "Éder Militão", "Defender", 8 },
                    { 81, 32, "David Alaba", "Defender", 8 },
                    { 82, 25, "Aurélien Tchouaméni", "Midfielder", 8 },
                    { 83, 27, "Federico Valverde", "Midfielder", 8 },
                    { 84, 22, "Jude Bellingham", "Midfielder", 8 },
                    { 85, 39, "Luka Modrić", "Midfielder", 8 },
                    { 86, 25, "Vinícius Júnior", "Forward", 8 },
                    { 87, 24, "Rodrygo", "Forward", 8 },
                    { 88, 35, "Joselu", "Forward", 8 },
                    { 89, 28, "Alex Meret", "Goalkeeper", 9 },
                    { 90, 31, "Giovanni Di Lorenzo", "Defender", 9 },
                    { 91, 30, "Amir Rrahmani", "Defender", 9 },
                    { 92, 33, "Mário Rui", "Defender", 9 },
                    { 93, 29, "Stanislav Lobotka", "Midfielder", 9 },
                    { 94, 30, "Piotr Zieliński", "Midfielder", 9 },
                    { 95, 23, "Khvicha Kvaratskhelia", "Forward", 9 },
                    { 96, 25, "Victor Osimhen", "Forward", 9 },
                    { 97, 31, "Matteo Politano", "Forward", 9 },
                    { 98, 24, "Jesper Lindstrøm", "Forward", 9 },
                    { 99, 32, "Diego Demme", "Midfielder", 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
