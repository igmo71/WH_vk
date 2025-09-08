using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Add_ИсточникЗаявки_Должность : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ИсточникЗаявки_Key",
                table: "Document_РеализацияТоваровУслуг",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ИсточникЗаявки_Key",
                table: "Document_ЗаказКлиента",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Должность",
                table: "Catalog_Пользователи",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ИсточникЗаявки_Key",
                table: "Document_РеализацияТоваровУслуг");

            migrationBuilder.DropColumn(
                name: "ИсточникЗаявки_Key",
                table: "Document_ЗаказКлиента");

            migrationBuilder.DropColumn(
                name: "Должность",
                table: "Catalog_Пользователи");
        }
    }
}
