using Microsoft.EntityFrameworkCore.Migrations;

namespace PaymentGatewayApp.Migrations
{
    public partial class Transaction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Transactions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    TransactionMethod = table.Column<string>(nullable: true),
                    BankName = table.Column<string>(nullable: true),
                    Cardnumber = table.Column<string>(nullable: true),
                    CVV = table.Column<int>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    Reference = table.Column<string>(nullable: true),
                    MerchantId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transactions", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "Transactions");
        }
    }
}
