using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WH.Api.Data.Migrations
{
    /// <inheritdoc />
    public partial class Create_CallItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CallItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", maxLength: 36, nullable: false),
                    Login = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true),
                    CallStartDate = table.Column<DateTime>(type: "datetime2", maxLength: 36, nullable: false),
                    PortalUserId = table.Column<int>(type: "int", maxLength: 36, nullable: false),
                    CallDuration = table.Column<int>(type: "int", maxLength: 36, nullable: false),
                    CallType = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CallItems", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CallItems");
        }
    }
}
