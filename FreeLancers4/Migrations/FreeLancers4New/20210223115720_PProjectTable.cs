using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeLancers4.Migrations.FreeLancers4New
{
    public partial class PProjectTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyHistory",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectName = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Freelancer = table.Column<string>(nullable: true),
                    Rating = table.Column<int>(nullable: false),
                    DeliveredOn = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyHistory", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyHistory");
        }
    }
}
