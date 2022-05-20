using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class CrearBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    RolID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.RolID);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RolID = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Person_Rol_RolID",
                        column: x => x.RolID,
                        principalTable: "Rol",
                        principalColumn: "RolID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "RolID", "CreatedAt", "CreatedBy", "Name", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2022, 5, 19, 22, 15, 47, 109, DateTimeKind.Local).AddTicks(5697), "Juan Leon", "Administrador", null });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "RolID", "CreatedAt", "CreatedBy", "Name", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2022, 5, 19, 22, 15, 47, 110, DateTimeKind.Local).AddTicks(2821), "Juan Leon", "Cliente", null });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "RolID", "CreatedAt", "CreatedBy", "Name", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2022, 5, 19, 22, 15, 47, 110, DateTimeKind.Local).AddTicks(2834), "Juan Leon", "Vendedor", null });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "EmployeeID", "CreatedAt", "CreatedBy", "Document", "Name", "RolID", "Telephone", "UpdatedAt" },
                values: new object[,]
                {
                    { 2, new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894), "Juan Leon", "528960794", "Spencer Will", 1, "1-676-316-8667", null },
                    { 5, new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894), "Juan Leon", "857636783", "Perry Cassin", 1, "578-433-9242", null },
                    { 1, new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894), "Juan Leon", "303379521", "Keith Watsica", 2, "1-637-888-3606", null },
                    { 3, new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894), "Juan Leon", "720016250", "Annie Connelly", 2, "1-760-234-2738 x098", null },
                    { 6, new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894), "Juan Leon", "514187084", "Edith Littel", 2, "(284) 264-4756 x242", null },
                    { 7, new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894), "Juan Leon", "467016540", "Ronnie Barrows", 2, "1-242-502-6670 x6954", null },
                    { 11, new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894), "Juan Leon", "271485975", "John Reichel", 2, "676-833-2377", null },
                    { 12, new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894), "Juan Leon", "268520322", "Sadie Conroy", 2, "(923) 792-2488 x636", null },
                    { 13, new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894), "Juan Leon", "200967478", "Clifford Gerhold", 2, "1-279-478-1425 x828", null },
                    { 14, new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894), "Juan Leon", "786509210", "Nicole Fay", 2, "1-761-987-9137 x882", null },
                    { 15, new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894), "Juan Leon", "724509940", "Theodore MacGyver", 2, "1-670-696-5153 x351", null },
                    { 4, new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894), "Juan Leon", "774549390", "Bradford Russel", 3, "1-824-279-3344 x3846", null },
                    { 8, new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894), "Juan Leon", "598954724", "Jackie Sporer", 3, "(357) 957-1607 x17071", null },
                    { 9, new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894), "Juan Leon", "161805592", "Noah Stanton", 3, "467.506.4093 x8986", null },
                    { 10, new DateTime(2022, 5, 19, 22, 15, 47, 144, DateTimeKind.Local).AddTicks(3894), "Juan Leon", "126692134", "Edmond Mohr", 3, "(580) 761-6883 x5221", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_RolID",
                table: "Person",
                column: "RolID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "Rol");
        }
    }
}
