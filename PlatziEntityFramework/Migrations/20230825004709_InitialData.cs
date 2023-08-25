using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlatziEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class InitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "comentary",
                table: "Work",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Work",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryID", "Description", "Name", "Weigth" },
                values: new object[,]
                {
                    { new Guid("32a46c4e-e2f2-4b0c-9fc1-cf0f4cbe06b0"), null, "Actividades Pendientes", 20 },
                    { new Guid("32a46c4e-e2f2-4b0c-9fc1-cf0f4cbe06b1"), null, "Actividades Personales", 50 }
                });

            migrationBuilder.InsertData(
                table: "Work",
                columns: new[] { "WorkId", "CategoryId", "DateCreate", "Description", "Priority", "Title", "comentary" },
                values: new object[,]
                {
                    { new Guid("32a46c4e-e2f2-4b0c-9fc1-cf0f4cbe06c0"), new Guid("32a46c4e-e2f2-4b0c-9fc1-cf0f4cbe06b0"), new DateTime(2023, 8, 24, 19, 47, 9, 459, DateTimeKind.Local).AddTicks(6483), null, 1, "Pago de Servicios Publicos", null },
                    { new Guid("32a46c4e-e2f2-4b0c-9fc1-cf0f4cbe06c1"), new Guid("32a46c4e-e2f2-4b0c-9fc1-cf0f4cbe06b1"), new DateTime(2023, 8, 24, 19, 47, 9, 459, DateTimeKind.Local).AddTicks(6494), null, 0, "terminar de ver pelicula en netflix", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Work",
                keyColumn: "WorkId",
                keyValue: new Guid("32a46c4e-e2f2-4b0c-9fc1-cf0f4cbe06c0"));

            migrationBuilder.DeleteData(
                table: "Work",
                keyColumn: "WorkId",
                keyValue: new Guid("32a46c4e-e2f2-4b0c-9fc1-cf0f4cbe06c1"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: new Guid("32a46c4e-e2f2-4b0c-9fc1-cf0f4cbe06b0"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryID",
                keyValue: new Guid("32a46c4e-e2f2-4b0c-9fc1-cf0f4cbe06b1"));

            migrationBuilder.AlterColumn<string>(
                name: "comentary",
                table: "Work",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Work",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
