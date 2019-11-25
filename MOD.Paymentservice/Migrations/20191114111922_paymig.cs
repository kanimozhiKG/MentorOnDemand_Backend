using Microsoft.EntityFrameworkCore.Migrations;

namespace MOD.Paymentservice.Migrations
{
    public partial class paymig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(nullable: false),
                    MentorId = table.Column<long>(nullable: false),
                    Amount = table.Column<double>(nullable: false),
                    MentorAmount = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentId);
                });

            migrationBuilder.InsertData(
                table: "Payment",
                columns: new[] { "PaymentId", "Amount", "MentorAmount", "MentorId", "UserId" },
                values: new object[] { 1233456L, 7675.0, 4444.0, 976454L, 75433L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");
        }
    }
}
