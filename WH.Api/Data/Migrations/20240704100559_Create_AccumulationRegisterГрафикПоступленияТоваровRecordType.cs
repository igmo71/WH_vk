using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Create_AccumulationRegisterГрафикПоступленияТоваровRecordType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccumulationRegister_ГрафикПоступленияТоваров_RecordType",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Recorder = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Recorder_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LineNumber = table.Column<int>(type: "int", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Склад_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    ДатаСобытия = table.Column<DateTime>(type: "Date", nullable: false),
                    КоличествоИзЗаказов = table.Column<double>(type: "float", nullable: false),
                    КоличествоПодЗаказ = table.Column<double>(type: "float", nullable: false),
                    КоличествоИзЗаказовСНеподтвержденными = table.Column<double>(type: "float", nullable: false),
                    КоличествоПодЗаказСНеподтвержденными = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccumulationRegister_ГрафикПоступленияТоваров_RecordType", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccumulationRegister_ГрафикПоступленияТоваров_RecordType");
        }
    }
}
