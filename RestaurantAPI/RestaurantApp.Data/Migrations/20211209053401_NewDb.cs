using Microsoft.EntityFrameworkCore.Migrations;

namespace RestaurantApp.Data.Migrations
{
    public partial class NewDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MyProperty",
                table: "FoodItems",
                newName: "FoodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FoodId",
                table: "FoodItems",
                newName: "MyProperty");
        }
    }
}
