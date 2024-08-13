using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contract_Report2.ModelDataLayer.Migrations
{
    /// <inheritdoc />
    public partial class _1403052202 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_tbContract-Status_ContractId",
                table: "tbContract-Status",
                column: "ContractId");

            migrationBuilder.AddForeignKey(
                name: "FK_tbContract-Status_tbContract_ContractId",
                table: "tbContract-Status",
                column: "ContractId",
                principalTable: "tbContract",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbContract-Status_tbContract_ContractId",
                table: "tbContract-Status");

            migrationBuilder.DropIndex(
                name: "IX_tbContract-Status_ContractId",
                table: "tbContract-Status");
        }
    }
}
