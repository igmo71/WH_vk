using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Create_AccumulationRegisterСебестоимостьТоваровBalance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccumulationRegister_СебестоимостьТоваров_Balance",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    Номенклатура_Key = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партия = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    Партия_Type = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    КоличествоBalance = table.Column<double>(type: "float", nullable: false),
                    СтоимостьBalance = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccumulationRegister_СебестоимостьТоваров_Balance", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccumulationRegister_СебестоимостьТоваров_Balance");
        }
    }
}
