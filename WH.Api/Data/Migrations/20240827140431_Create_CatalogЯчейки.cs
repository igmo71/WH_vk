using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Create_CatalogЯчейки : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "wms_Catalog_Ячейки",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Parent_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    IsFolder = table.Column<bool>(type: "bit", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Вес = table.Column<double>(type: "float", nullable: true),
                    Длина = table.Column<double>(type: "float", nullable: true),
                    Ширина = table.Column<double>(type: "float", nullable: true),
                    Высота = table.Column<double>(type: "float", nullable: true),
                    Объем = table.Column<double>(type: "float", nullable: true),
                    ВместимостьПаллет = table.Column<double>(type: "float", nullable: true),
                    ДопустимаяСтепеньЗаполненности = table.Column<double>(type: "float", nullable: true),
                    КлассABC = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    КлассXYZ = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Артикул = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Поставщик_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Покупатель_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    РазмещениеПогрузчиком = table.Column<bool>(type: "bit", nullable: true),
                    СерияТовараВЯчейке_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ВидЯчейки = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Помещение = table.Column<int>(type: "int", nullable: true),
                    Ряд = table.Column<int>(type: "int", nullable: true),
                    Стойка = table.Column<int>(type: "int", nullable: true),
                    Глубина = table.Column<int>(type: "int", nullable: true),
                    Полка = table.Column<int>(type: "int", nullable: true),
                    ПриоритетВыборки = table.Column<int>(type: "int", nullable: true),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    СрокГодностиТовараВЯчейке = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Резерв = table.Column<bool>(type: "bit", nullable: true),
                    ТипЯчейки = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ТипХранения = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЗонаСклада_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Распечатан = table.Column<bool>(type: "bit", nullable: true),
                    ТестовыйРежим_МножественноеРазмещение = table.Column<bool>(type: "bit", nullable: true),
                    ПередаватьРезультатыИнвентаризации = table.Column<bool>(type: "bit", nullable: true),
                    Комментарий = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Заблокированна = table.Column<bool>(type: "bit", nullable: true),
                    ТранспортнаяКомпания_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_Catalog_Ячейки", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "wms_Catalog_Ячейки_НоменклатураЯчейки",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wms_Catalog_Ячейки_НоменклатураЯчейки", x => new { x.Ref_Key, x.LineNumber });
                    table.ForeignKey(
                        name: "FK_wms_Catalog_Ячейки_НоменклатураЯчейки_wms_Catalog_Ячейки_Ref_Key",
                        column: x => x.Ref_Key,
                        principalTable: "wms_Catalog_Ячейки",
                        principalColumn: "Ref_Key",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "wms_Catalog_Ячейки_НоменклатураЯчейки");

            migrationBuilder.DropTable(
                name: "wms_Catalog_Ячейки");
        }
    }
}
