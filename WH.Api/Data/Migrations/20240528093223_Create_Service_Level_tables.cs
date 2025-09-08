using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Create_Service_Level_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Document_АктОРасхожденияхПослеОтгрузки",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Партнер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Менеджер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    МассаБруттоПоФакту = table.Column<double>(type: "float", nullable: false),
                    МассаНеттоПоФакту = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_АктОРасхожденияхПослеОтгрузки", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Document_ВозвратТоваровОтКлиента",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Партнер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Менеджер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ДокументРеализации = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ДокументРеализации_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ПричинаВозврата = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    СуммаДокумента = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ВозвратТоваровОтКлиента", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "WhsOrders",
                columns: table => new
                {
                    Документ_Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Документ_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Номер = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Дата = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Проведен = table.Column<bool>(type: "bit", nullable: false),
                    Статус = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    КоличествоСтрок = table.Column<int>(type: "int", nullable: false),
                    Вес = table.Column<float>(type: "real", nullable: false),
                    СрокВыполнения = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ТипОчереди = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВесовойКоэффициент = table.Column<int>(type: "int", nullable: false),
                    Комментарий = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ЗаданиеДляКладовщика = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ЭтоПеремещение = table.Column<bool>(type: "bit", nullable: false),
                    Склад_Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Ответственный_Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Ответственный_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ОтправительПолучатель_Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ОтправительПолучатель_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhsOrders", x => x.Документ_Id);
                });

            migrationBuilder.CreateTable(
                name: "Document_АктОРасхожденияхПослеОтгрузки_Товары",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Реализация = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Реализация_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ЗаказКлиента = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЗаказКлиента_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Упаковка_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    КоличествоУпаковок = table.Column<double>(type: "float", nullable: false),
                    Количество = table.Column<double>(type: "float", nullable: false),
                    Цена = table.Column<double>(type: "float", nullable: false),
                    Сумма = table.Column<double>(type: "float", nullable: false),
                    КоличествоУпаковокПоДокументу = table.Column<double>(type: "float", nullable: false),
                    КоличествоПоДокументу = table.Column<double>(type: "float", nullable: false),
                    СуммаПоДокументу = table.Column<double>(type: "float", nullable: false),
                    ЗаполненоПоРеализации = table.Column<bool>(type: "bit", nullable: false),
                    ПричинаРасхожденияKey = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_АктОРасхожденияхПослеОтгрузки_Товары", x => new { x.Ref_Key, x.LineNumber });
                    table.ForeignKey(
                        name: "FK_Document_АктОРасхожденияхПослеОтгрузки_Товары_Document_АктОРасхожденияхПослеОтгрузки_Ref_Key",
                        column: x => x.Ref_Key,
                        principalTable: "Document_АктОРасхожденияхПослеОтгрузки",
                        principalColumn: "Ref_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Document_ВозвратТоваровОтКлиента_Товары",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ДокументРеализации = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ДокументРеализации_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Упаковка_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    КоличествоУпаковок = table.Column<double>(type: "float", nullable: false),
                    Количество = table.Column<double>(type: "float", nullable: false),
                    Цена = table.Column<double>(type: "float", nullable: false),
                    Сумма = table.Column<double>(type: "float", nullable: false),
                    ПричинаВозвратаKey = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ВозвратТоваровОтКлиента_Товары", x => new { x.Ref_Key, x.LineNumber });
                    table.ForeignKey(
                        name: "FK_Document_ВозвратТоваровОтКлиента_Товары_Document_ВозвратТоваровОтКлиента_Ref_Key",
                        column: x => x.Ref_Key,
                        principalTable: "Document_ВозвратТоваровОтКлиента",
                        principalColumn: "Ref_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WhsProductData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Документ_Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    НомерСтроки = table.Column<int>(type: "int", nullable: false),
                    Документ_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Номенклатура_Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Номенклатура_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Артикул = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    КоличествоФакт = table.Column<float>(type: "real", nullable: false),
                    КоличествоПлан = table.Column<float>(type: "real", nullable: false),
                    Вес = table.Column<float>(type: "real", nullable: false),
                    Упаковка_Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Упаковка_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ТипУпаковки = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Отгрузить = table.Column<bool>(type: "bit", nullable: false),
                    EditingCauseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WhsProductData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WhsProductData_WhsOrders_Документ_Id",
                        column: x => x.Документ_Id,
                        principalTable: "WhsOrders",
                        principalColumn: "Документ_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WhsProductData_Документ_Id",
                table: "WhsProductData",
                column: "Документ_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Document_АктОРасхожденияхПослеОтгрузки_Товары");

            migrationBuilder.DropTable(
                name: "Document_ВозвратТоваровОтКлиента_Товары");

            migrationBuilder.DropTable(
                name: "WhsProductData");

            migrationBuilder.DropTable(
                name: "Document_АктОРасхожденияхПослеОтгрузки");

            migrationBuilder.DropTable(
                name: "Document_ВозвратТоваровОтКлиента");

            migrationBuilder.DropTable(
                name: "WhsOrders");
        }
    }
}
