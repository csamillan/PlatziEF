using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlatziEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class NewDatatoWorks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Work",
                keyColumn: "WorkId",
                keyValue: new Guid("32a46c4e-e2f2-4b0c-9fc1-cf0f4cbe06c0"),
                column: "DateCreate",
                value: new DateTime(2023, 8, 24, 19, 51, 55, 661, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Work",
                keyColumn: "WorkId",
                keyValue: new Guid("32a46c4e-e2f2-4b0c-9fc1-cf0f4cbe06c1"),
                column: "DateCreate",
                value: new DateTime(2023, 8, 24, 19, 51, 55, 661, DateTimeKind.Local).AddTicks(1556));

            migrationBuilder.InsertData(
                table: "Work",
                columns: new[] { "WorkId", "CategoryId", "DateCreate", "Description", "Priority", "Title", "comentary" },
                values: new object[] { new Guid("32a46c4e-e2f2-4b0c-9fc1-cf0f4cbe06c2"), new Guid("32a46c4e-e2f2-4b0c-9fc1-cf0f4cbe06b1"), new DateTime(2023, 8, 24, 19, 51, 55, 661, DateTimeKind.Local).AddTicks(1559), null, 2, "Dar examenes de devsu antes del domingo", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Work",
                keyColumn: "WorkId",
                keyValue: new Guid("32a46c4e-e2f2-4b0c-9fc1-cf0f4cbe06c2"));

            migrationBuilder.UpdateData(
                table: "Work",
                keyColumn: "WorkId",
                keyValue: new Guid("32a46c4e-e2f2-4b0c-9fc1-cf0f4cbe06c0"),
                column: "DateCreate",
                value: new DateTime(2023, 8, 24, 19, 47, 9, 459, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "Work",
                keyColumn: "WorkId",
                keyValue: new Guid("32a46c4e-e2f2-4b0c-9fc1-cf0f4cbe06c1"),
                column: "DateCreate",
                value: new DateTime(2023, 8, 24, 19, 47, 9, 459, DateTimeKind.Local).AddTicks(6494));
        }
    }
}
