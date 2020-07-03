using Microsoft.EntityFrameworkCore.Migrations;

namespace GuiHuaWebApp.Migrations
{
    public partial class u2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "BiaoJi",
                table: "GuiHuaJianDu",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BiaoJi",
                table: "GuiHuaJianDu");
        }
    }
}
