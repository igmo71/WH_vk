using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Create_InformationRegisterЦеныНоменклатурыПоставкиSliceLastLast : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InformationRegister_ЦеныНоменклатуры_Поставки_SliceLast",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    Period = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Цена = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InformationRegister_ЦеныНоменклатуры_Поставки_SliceLast", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InformationRegister_ЦеныНоменклатуры_Поставки_SliceLast");
        }
    }
}
