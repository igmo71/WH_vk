using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateCatalogКонтрагенты : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catalog_Контрагенты",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    ГоловнойКонтрагент_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партнер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ИНН = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_Контрагенты", x => x.Ref_Key);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalog_Контрагенты");
        }
    }
}
