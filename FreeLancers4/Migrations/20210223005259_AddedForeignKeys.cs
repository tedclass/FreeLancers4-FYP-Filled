using Microsoft.EntityFrameworkCore.Migrations;

namespace FreeLancers4.Migrations
{
    public partial class AddedForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Work_AspNetUsers_AssignedId",
                table: "Work");

            migrationBuilder.DropForeignKey(
                name: "FK_Work_AspNetUsers_OwnerId",
                table: "Work");

            migrationBuilder.DropIndex(
                name: "IX_Work_AssignedId",
                table: "Work");

            migrationBuilder.DropIndex(
                name: "IX_Work_OwnerId",
                table: "Work");

            migrationBuilder.DropColumn(
                name: "AssignedId",
                table: "Work");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Work");

            migrationBuilder.AddColumn<string>(
                name: "AssignedTo",
                table: "Work",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnedBy",
                table: "Work",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Work_AssignedTo",
                table: "Work",
                column: "AssignedTo");

            migrationBuilder.CreateIndex(
                name: "IX_Work_OwnedBy",
                table: "Work",
                column: "OwnedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Work_AspNetUsers_AssignedTo",
                table: "Work",
                column: "AssignedTo",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Work_AspNetUsers_OwnedBy",
                table: "Work",
                column: "OwnedBy",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Work_AspNetUsers_AssignedTo",
                table: "Work");

            migrationBuilder.DropForeignKey(
                name: "FK_Work_AspNetUsers_OwnedBy",
                table: "Work");

            migrationBuilder.DropIndex(
                name: "IX_Work_AssignedTo",
                table: "Work");

            migrationBuilder.DropIndex(
                name: "IX_Work_OwnedBy",
                table: "Work");

            migrationBuilder.DropColumn(
                name: "AssignedTo",
                table: "Work");

            migrationBuilder.DropColumn(
                name: "OwnedBy",
                table: "Work");

            migrationBuilder.AddColumn<string>(
                name: "AssignedId",
                table: "Work",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Work",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Work_AssignedId",
                table: "Work",
                column: "AssignedId");

            migrationBuilder.CreateIndex(
                name: "IX_Work_OwnerId",
                table: "Work",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Work_AspNetUsers_AssignedId",
                table: "Work",
                column: "AssignedId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Work_AspNetUsers_OwnerId",
                table: "Work",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
