using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Remove_AccumulationRegisterСебестоимостьТоваров : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccumulationRegister_СебестоимостьТоваров_Balance");

            migrationBuilder.DropTable(
                name: "AccumulationRegister_СебестоимостьТоваров_BalanceAndTurnovers");

            migrationBuilder.DropTable(
                name: "AccumulationRegister_СебестоимостьТоваров_RecordType");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccumulationRegister_СебестоимостьТоваров_Balance",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    КоличествоBalance = table.Column<double>(type: "float", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партия = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партия_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    СтоимостьBalance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccumulationRegister_СебестоимостьТоваров_Balance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccumulationRegister_СебестоимостьТоваров_BalanceAndTurnovers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    КоличествоClosingBalance = table.Column<double>(type: "float", nullable: false),
                    КоличествоExpense = table.Column<double>(type: "float", nullable: false),
                    КоличествоOpeningBalance = table.Column<double>(type: "float", nullable: false),
                    КоличествоReceipt = table.Column<double>(type: "float", nullable: false),
                    КоличествоTurnover = table.Column<double>(type: "float", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партия = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партия_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    СтоимостьClosingBalance = table.Column<double>(type: "float", nullable: false),
                    СтоимостьExpense = table.Column<double>(type: "float", nullable: false),
                    СтоимостьOpeningBalance = table.Column<double>(type: "float", nullable: false),
                    СтоимостьReceipt = table.Column<double>(type: "float", nullable: false),
                    СтоимостьTurnover = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccumulationRegister_СебестоимостьТоваров_BalanceAndTurnovers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccumulationRegister_СебестоимостьТоваров_RecordType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    RecordType = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    Recorder = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Recorder_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    АналитикаАктивовПассивов = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    АналитикаАктивовПассивов_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    АналитикаДоходов = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    АналитикаДоходов_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    АналитикаРасходов = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    АналитикаРасходов_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВидДеятельностиНДС = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВидЗапасов_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ГруппаПродукции_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ДокументДвижения = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ДокументДвижения_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ДокументИсточник = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ДокументИсточник_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ДопРасходы = table.Column<double>(type: "float", nullable: false),
                    ДопРасходыБезНДС = table.Column<double>(type: "float", nullable: false),
                    ЗаказКлиента = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЗаказКлиента_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Количество = table.Column<double>(type: "float", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партия = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партия_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Партнер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ПериодПродажи = table.Column<DateTime>(type: "Date", nullable: false),
                    Подразделение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    РазделУчета = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    РасчетНеЗавершен = table.Column<bool>(type: "bit", nullable: false),
                    РасчетПартий = table.Column<bool>(type: "bit", nullable: false),
                    РасчетСебестоимости = table.Column<bool>(type: "bit", nullable: false),
                    СтатьяАктивовПассивов_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    СтатьяДоходов_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    СтатьяРасходовСписания_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Стоимость = table.Column<double>(type: "float", nullable: false),
                    СтоимостьБезНДС = table.Column<double>(type: "float", nullable: false),
                    ТипЗаписи = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ХозяйственнаяОперация = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccumulationRegister_СебестоимостьТоваров_RecordType", x => x.Id);
                });
        }
    }
}
