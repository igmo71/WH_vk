using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Create_CatalogСоглашенияСКлиентами_БизнесРегионы : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Соглашение_Key",
                table: "AccumulationRegister_ВыручкаИСебестоимостьПродаж_Turnovers",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Соглашение_Key",
                table: "AccumulationRegister_ВыручкаИСебестоимостьПродаж_RecordType",
                type: "nvarchar(36)",
                maxLength: 36,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Catalog_БизнесРегионы",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Parent_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_БизнесРегионы", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_СоглашенияСКлиентами",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    DeletionMark = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Номер = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Партнер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Соглашение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Статус = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_СоглашенияСКлиентами", x => x.Ref_Key);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catalog_БизнесРегионы");

            migrationBuilder.DropTable(
                name: "Catalog_СоглашенияСКлиентами");

            migrationBuilder.DropColumn(
                name: "Соглашение_Key",
                table: "AccumulationRegister_ВыручкаИСебестоимостьПродаж_Turnovers");

            migrationBuilder.DropColumn(
                name: "Соглашение_Key",
                table: "AccumulationRegister_ВыручкаИСебестоимостьПродаж_RecordType");
        }
    }
}
