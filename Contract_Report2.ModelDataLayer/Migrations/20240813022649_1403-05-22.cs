using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contract_Report2.ModelDataLayer.Migrations
{
    /// <inheritdoc />
    public partial class _14030522 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbContract-Status_tbContract_ComanyId",
                table: "tbContract-Status");

            migrationBuilder.DropIndex(
                name: "IX_tbContract-Status_ComanyId",
                table: "tbContract-Status");

            migrationBuilder.DropColumn(
                name: "ComanyId",
                table: "tbContract-Status");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ComanyId",
                table: "tbContract-Status",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_tbContract-Status_ComanyId",
                table: "tbContract-Status",
                column: "ComanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbContract-Status_tbContract_ComanyId",
                table: "tbContract-Status",
                column: "ComanyId",
                principalTable: "tbContract",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
