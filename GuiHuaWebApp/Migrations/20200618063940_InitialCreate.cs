using Microsoft.EntityFrameworkCore.Migrations;

namespace GuiHuaWebApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GuiHuaJianDu",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PrjName = table.Column<string>(nullable: true),
                    JSDanWei = table.Column<string>(nullable: true),
                    JSWeiZhi = table.Column<string>(nullable: true),
                    GongGuiNum = table.Column<string>(nullable: true),
                    JSGuiMo = table.Column<double>(nullable: false),
                    SFYanXian = table.Column<bool>(nullable: false),
                    IsChecked1 = table.Column<bool>(nullable: false),
                    IsChecked2 = table.Column<bool>(nullable: false),
                    checkItem1 = table.Column<bool>(nullable: false),
                    checkItem2 = table.Column<bool>(nullable: false),
                    checkItem3 = table.Column<bool>(nullable: false),
                    checkItem4 = table.Column<bool>(nullable: false),
                    checkItem5 = table.Column<bool>(nullable: false),
                    checkItem6 = table.Column<bool>(nullable: false),
                    checkItem7 = table.Column<bool>(nullable: false),
                    Photos = table.Column<string>(nullable: true),
                    SFFaWenXinTiShiKa = table.Column<bool>(nullable: false),
                    SFJunGongHeShi = table.Column<bool>(nullable: false),
                    BeiZhu = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuiHuaJianDu", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GuiHuaJianDu");
        }
    }
}
