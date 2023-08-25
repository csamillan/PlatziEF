using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlatziEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class ColummnWeigthCategory1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Weigth",
                table: "Category",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Weigth",
                table: "Category");
        }
    }
}
