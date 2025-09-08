using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateDocumentЗаказНаПеремещение : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Document_ЗаказНаПеремещение",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Организация_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ОрганизацияПолучатель_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Подразделение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    СкладОтправитель_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    СкладПолучатель_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Статус = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ХозяйственнаяОперация = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ДокументОснование = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ДокументОснование_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ЗаказНаПеремещение", x => x.Ref_Key);
                });

            migrationBuilder.CreateTable(
                name: "Document_ЗаказНаПеремещение_Товары",
                columns: table => new
                {
                    Ref_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Количество = table.Column<double>(type: "float", nullable: false),
                    КоличествоУпаковок = table.Column<double>(type: "float", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Упаковка_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Отменено = table.Column<bool>(type: "bit", nullable: false),
                    КодСтроки = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЗНП_Комментарий = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    ЗНП_ПричинаОтмены_Key = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document_ЗаказНаПеремещение_Товары", x => new { x.Ref_Key, x.LineNumber });
                    table.ForeignKey(
                        name: "FK_Document_ЗаказНаПеремещение_Товары_Document_ЗаказНаПеремещение_Ref_Key",
                        column: x => x.Ref_Key,
                        principalTable: "Document_ЗаказНаПеремещение",
                        principalColumn: "Ref_Key",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Document_ЗаказНаПеремещение_Товары");

            migrationBuilder.DropTable(
                name: "Document_ЗаказНаПеремещение");
        }
    }
}
