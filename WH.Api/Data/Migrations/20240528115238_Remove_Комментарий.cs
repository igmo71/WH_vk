using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Remove_Комментарий : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ЗаданиеДляКладовщика",
                table: "WhsOrders");

            migrationBuilder.DropColumn(
                name: "Комментарий",
                table: "WhsOrders");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ЗаданиеДляКладовщика",
                table: "WhsOrders",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Комментарий",
                table: "WhsOrders",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }
    }
}
