using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class personfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Surname = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { 1, "Ahmet", "Deliyürek" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "Name", "Surname" },
                values: new object[] { 2, "Handan", "Dert" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
