using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Alter_DocumentПриходныйОрдерНаТовары : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Распоряжение",
                table: "Document_ПриходныйОрдерНаТовары",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Распоряжение_Type",
                table: "Document_ПриходныйОрдерНаТовары",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Распоряжение",
                table: "Document_ПриходныйОрдерНаТовары");

            migrationBuilder.DropColumn(
                name: "Распоряжение_Type",
                table: "Document_ПриходныйОрдерНаТовары");
        }
    }
}
