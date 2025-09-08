using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateAccumulationRegisterСебестоимостьТоваровRecordType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RecordType",
                table: "AccumulationRegister_ТоварыНаСкладах_RecordType",
                type: "nvarchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "AccumulationRegister_СебестоимостьТоваров_RecordType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Recorder = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Recorder_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    RecordType = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партнер_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    РазделУчета = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВидЗапасов_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партия = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партия_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВидДеятельностиНДС = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Количество = table.Column<double>(type: "float", nullable: false),
                    Стоимость = table.Column<double>(type: "float", nullable: false),
                    СтоимостьБезНДС = table.Column<double>(type: "float", nullable: false),
                    ДопРасходы = table.Column<double>(type: "float", nullable: false),
                    ДопРасходыБезНДС = table.Column<double>(type: "float", nullable: false),
                    ХозяйственнаяОперация = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ЗаказКлиента = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ЗаказКлиента_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Подразделение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    АналитикаРасходов = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    АналитикаРасходов_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    СтатьяРасходовСписания_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    СтатьяДоходов_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    АналитикаДоходов = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    АналитикаДоходов_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ПериодПродажи = table.Column<DateTime>(type: "Date", nullable: false),
                    СтатьяАктивовПассивов_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    АналитикаАктивовПассивов = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    АналитикаАктивовПассивов_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ДокументДвижения = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ДокументДвижения_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ГруппаПродукции_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ТипЗаписи = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ДокументИсточник = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ДокументИсточник_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    РасчетПартий = table.Column<bool>(type: "bit", nullable: false),
                    РасчетСебестоимости = table.Column<bool>(type: "bit", nullable: false),
                    РасчетНеЗавершен = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccumulationRegister_СебестоимостьТоваров_RecordType", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccumulationRegister_СебестоимостьТоваров_RecordType");

            migrationBuilder.AlterColumn<string>(
                name: "RecordType",
                table: "AccumulationRegister_ТоварыНаСкладах_RecordType",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(7)",
                oldMaxLength: 7,
                oldNullable: true);
        }
    }
}
