using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Remove_AccumulationRegisterТоварыНаСкладахRecordType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccumulationRegister_ТоварыНаСкладах_RecordType");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccumulationRegister_ТоварыНаСкладах_RecordType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    RecordType = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    Recorder = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Recorder_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ВНаличии = table.Column<double>(type: "float", nullable: false),
                    КОтгрузке = table.Column<double>(type: "float", nullable: false),
                    КонтролироватьОстатки = table.Column<bool>(type: "bit", nullable: false),
                    Назначение_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccumulationRegister_ТоварыНаСкладах_RecordType", x => x.Id);
                });
        }
    }
}
