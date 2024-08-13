using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contract_Report2.ModelDataLayer.Migrations
{
    /// <inheritdoc />
    public partial class Initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbContract",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ContractDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EstimatedCost = table.Column<float>(type: "real", nullable: false),
                    ReviewAndEditting = table.Column<bool>(type: "bit", nullable: false),
                    Committee = table.Column<bool>(type: "bit", nullable: false),
                    CommitteeApproval = table.Column<bool>(type: "bit", nullable: false),
                    BudgetRequestDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BudgetApprovalDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HowToAssign = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RateDeadline = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OpeningDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FixedAmount = table.Column<float>(type: "real", nullable: true),
                    BankGurantee = table.Column<bool>(type: "bit", nullable: true),
                    ContractType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StratWorkDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndWorkDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeExtension = table.Column<int>(type: "int", nullable: true),
                    RealFinishDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApplicantUnit = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbContract", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbSattus",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbSattus", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "tbCompany",
                columns: table => new
                {
                    CompanyID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EconomyCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ManagerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ManagerId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ContractId = table.Column<int>(type: "int", nullable: true),
                    IsWin = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbCompany", x => x.CompanyID);
                    table.ForeignKey(
                        name: "FK_tbCompany_tbContract_ContractId",
                        column: x => x.ContractId,
                        principalTable: "tbContract",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "tbContract-Status",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    ContractId = table.Column<int>(type: "int", nullable: false),
                    ComanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbContract-Status", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbContract-Status_tbContract_ComanyId",
                        column: x => x.ComanyId,
                        principalTable: "tbContract",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tbContract-Status_tbSattus_StatusId",
                        column: x => x.StatusId,
                        principalTable: "tbSattus",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbCompany_ContractId",
                table: "tbCompany",
                column: "ContractId");

            migrationBuilder.CreateIndex(
                name: "IX_tbContract-Status_ComanyId",
                table: "tbContract-Status",
                column: "ComanyId");

            migrationBuilder.CreateIndex(
                name: "IX_tbContract-Status_StatusId",
                table: "tbContract-Status",
                column: "StatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbCompany");

            migrationBuilder.DropTable(
                name: "tbContract-Status");

            migrationBuilder.DropTable(
                name: "tbContract");

            migrationBuilder.DropTable(
                name: "tbSattus");
        }
    }
}
