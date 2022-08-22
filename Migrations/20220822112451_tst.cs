using Microsoft.EntityFrameworkCore.Migrations;

namespace tst.Migrations
{
    public partial class tst : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WktString",
                table: "Parcelation",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WktString",
                table: "Parcelation");
        }
    }
}
