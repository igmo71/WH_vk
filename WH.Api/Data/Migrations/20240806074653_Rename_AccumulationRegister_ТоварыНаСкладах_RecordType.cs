using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Rename_AccumulationRegister_ТоварыНаСкладах_RecordType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AccumulationRegisterТоварыНаСкладахRecordType",
                table: "AccumulationRegisterТоварыНаСкладахRecordType");

            migrationBuilder.RenameTable(
                name: "AccumulationRegisterТоварыНаСкладахRecordType",
                newName: "AccumulationRegister_ТоварыНаСкладах_RecordType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccumulationRegister_ТоварыНаСкладах_RecordType",
                table: "AccumulationRegister_ТоварыНаСкладах_RecordType",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AccumulationRegister_ТоварыНаСкладах_RecordType",
                table: "AccumulationRegister_ТоварыНаСкладах_RecordType");

            migrationBuilder.RenameTable(
                name: "AccumulationRegister_ТоварыНаСкладах_RecordType",
                newName: "AccumulationRegisterТоварыНаСкладахRecordType");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AccumulationRegisterТоварыНаСкладахRecordType",
                table: "AccumulationRegisterТоварыНаСкладахRecordType",
                column: "Id");
        }
    }
}
