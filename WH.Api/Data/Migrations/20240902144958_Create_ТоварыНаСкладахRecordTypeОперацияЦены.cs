using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Create_ТоварыНаСкладахRecordTypeОперацияЦены : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Awesome_ТоварыНаСкладах_RecordType_ОперацияЦены",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Recorder = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Recorder_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Операция = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    RecordType = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ВНаличии = table.Column<double>(type: "float", nullable: true),
                    Количество = table.Column<double>(type: "float", nullable: true),
                    ЦенаЗакупки = table.Column<double>(type: "float", nullable: true),
                    ЦенаПродажи = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Awesome_ТоварыНаСкладах_RecordType_ОперацияЦены", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Awesome_ТоварыНаСкладах_RecordType_ОперацияЦены");
        }
    }
}
