using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Create_Document_УстановкаЦенНоменклатуры_etc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Document_ПриобретениеТоваровУслуг",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    СуммаДокумента = table.Column<double>(type: "float", nullable: false),
                    Подразделение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Менеджер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партнер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ХозяйственнаяОперация = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ЗаказПоставщику_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ПоступлениеПоЗаказам = table.Column<bool>(type: "bit", nullable: false),
                    Валюта_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    НалогообложениеНДС = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ЦенаВключаетНДС = table.Column<bool>(type: "bit", nullable: false),
                    Согласован = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ПриобретениеТоваровУслуг", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Document_СборкаТоваров",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    ЗаказНаСборку_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Количество = table.Column<double>(type: "float", nullable: false),
                    КоличествоУпаковок = table.Column<double>(type: "float", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Ответственный_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Упаковка_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Подразделение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Статус = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    СборкаПодДеятельность = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ХозяйственнаяОперация = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВариантПриемкиТоваров = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВариантКомплектации_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    НоменклатураОсновногоКомпонента_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_СборкаТоваров", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Document_УстановкаЦенНоменклатуры",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Ответственный_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Согласован = table.Column<bool>(type: "bit", nullable: false),
                    ДокументОснование = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ДокументОснование_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Статус = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_УстановкаЦенНоменклатуры", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Document_ПриобретениеТоваровУслуг_Товары",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Упаковка_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    КоличествоУпаковок = table.Column<double>(type: "float", nullable: false),
                    Количество = table.Column<double>(type: "float", nullable: false),
                    Цена = table.Column<double>(type: "float", nullable: false),
                    Сумма = table.Column<double>(type: "float", nullable: false),
                    СтавкаНДС = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    СуммаНДС = table.Column<double>(type: "float", nullable: false),
                    СуммаСНДС = table.Column<double>(type: "float", nullable: false),
                    СуммаРучнойСкидки = table.Column<double>(type: "float", nullable: false),
                    ПроцентРучнойСкидки = table.Column<double>(type: "float", nullable: false),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЗаказПоставщику_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ПриобретениеТоваровУслуг_Товары", x => new { x.Ref_Key, x.LineNumber });
                    table.ForeignKey(
                        name: "FK_Document_ПриобретениеТоваровУслуг_Товары_Document_ПриобретениеТоваровУслуг_Ref_Key",
                        column: x => x.Ref_Key,
                        principalTable: "Document_ПриобретениеТоваровУслуг",
                        principalColumn: "Ref_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Document_СборкаТоваров_Товары",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Упаковка_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    КоличествоУпаковок = table.Column<double>(type: "float", nullable: false),
                    Количество = table.Column<double>(type: "float", nullable: false),
                    ДоляСтоимости = table.Column<double>(type: "float", nullable: false),
                    КодСтроки = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_СборкаТоваров_Товары", x => new { x.Ref_Key, x.LineNumber });
                    table.ForeignKey(
                        name: "FK_Document_СборкаТоваров_Товары_Document_СборкаТоваров_Ref_Key",
                        column: x => x.Ref_Key,
                        principalTable: "Document_СборкаТоваров",
                        principalColumn: "Ref_Key",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Document_УстановкаЦенНоменклатуры_Товары",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Упаковка_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ВидЦены_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Цена = table.Column<double>(type: "float", nullable: false),
                    ЦенаИзмененаВручную = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_УстановкаЦенНоменклатуры_Товары", x => new { x.Ref_Key, x.LineNumber });
                    table.ForeignKey(
                        name: "FK_Document_УстановкаЦенНоменклатуры_Товары_Document_УстановкаЦенНоменклатуры_Ref_Key",
                        column: x => x.Ref_Key,
                        principalTable: "Document_УстановкаЦенНоменклатуры",
                        principalColumn: "Ref_Key",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Document_ПриобретениеТоваровУслуг_Товары");

            migrationBuilder.DropTable(
                name: "Document_СборкаТоваров_Товары");

            migrationBuilder.DropTable(
                name: "Document_УстановкаЦенНоменклатуры_Товары");

            migrationBuilder.DropTable(
                name: "Document_ПриобретениеТоваровУслуг");

            migrationBuilder.DropTable(
                name: "Document_СборкаТоваров");

            migrationBuilder.DropTable(
                name: "Document_УстановкаЦенНоменклатуры");
        }
    }
}
