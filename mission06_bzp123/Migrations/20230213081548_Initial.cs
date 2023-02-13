using Microsoft.EntityFrameworkCore.Migrations;

namespace mission06_bzp123.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NewMovies",
                columns: table => new
                {
                    FormID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    DirectorFirstName = table.Column<string>(nullable: false),
                    DirectorLastName = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewMovies", x => x.FormID);
                });

            migrationBuilder.InsertData(
                table: "NewMovies",
                columns: new[] { "FormID", "Category", "DirectorFirstName", "DirectorLastName", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Musical/Romance", "Phyllida", "Lloyd", false, "My parents", "Fun Musical", "PG-13", "Mamma Mia!", 2008 });

            migrationBuilder.InsertData(
                table: "NewMovies",
                columns: new[] { "FormID", "Category", "DirectorFirstName", "DirectorLastName", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Sci-fi", "Phillip", "Noyce", false, "", "Good Vibes", "PG-13", "The Giver", 2014 });

            migrationBuilder.InsertData(
                table: "NewMovies",
                columns: new[] { "FormID", "Category", "DirectorFirstName", "DirectorLastName", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Comedy", "Maclain", "Nelson", false, "My roommate", "subversive", "PG", "Once I Was Engaged", 2021 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewMovies");
        }
    }
}
