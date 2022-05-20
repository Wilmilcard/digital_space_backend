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
                    PersonID = table.Column<int>(type: "int", nullable: false)
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
                    table.PrimaryKey("PK_Person", x => x.PersonID);
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
                values: new object[] { 1, new DateTime(2022, 5, 19, 22, 53, 21, 445, DateTimeKind.Local).AddTicks(3949), "Juan Leon", "Administrador", null });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "RolID", "CreatedAt", "CreatedBy", "Name", "UpdatedAt" },
                values: new object[] { 2, new DateTime(2022, 5, 19, 22, 53, 21, 446, DateTimeKind.Local).AddTicks(1109), "Juan Leon", "Cliente", null });

            migrationBuilder.InsertData(
                table: "Rol",
                columns: new[] { "RolID", "CreatedAt", "CreatedBy", "Name", "UpdatedAt" },
                values: new object[] { 3, new DateTime(2022, 5, 19, 22, 53, 21, 446, DateTimeKind.Local).AddTicks(1121), "Juan Leon", "Vendedor", null });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "PersonID", "CreatedAt", "CreatedBy", "Document", "Name", "RolID", "Telephone", "UpdatedAt" },
                values: new object[,]
                {
                    { 3, new DateTime(2022, 5, 19, 22, 53, 21, 480, DateTimeKind.Local).AddTicks(1779), "Juan Leon", "911402224", "Edna Paucek", 1, "1-695-876-4567 x08538", null },
                    { 4, new DateTime(2022, 5, 19, 22, 53, 21, 480, DateTimeKind.Local).AddTicks(1779), "Juan Leon", "458363221", "Samuel Schneider", 1, "269.422.4476 x07987", null },
                    { 5, new DateTime(2022, 5, 19, 22, 53, 21, 480, DateTimeKind.Local).AddTicks(1779), "Juan Leon", "104135530", "Salvador Steuber", 1, "1-811-332-4240", null },
                    { 11, new DateTime(2022, 5, 19, 22, 53, 21, 480, DateTimeKind.Local).AddTicks(1779), "Juan Leon", "245124844", "Alicia Windler", 1, "(609) 465-2129 x9827", null },
                    { 12, new DateTime(2022, 5, 19, 22, 53, 21, 480, DateTimeKind.Local).AddTicks(1779), "Juan Leon", "879848412", "Jackie Kozey", 1, "546-518-3136 x74628", null },
                    { 13, new DateTime(2022, 5, 19, 22, 53, 21, 480, DateTimeKind.Local).AddTicks(1779), "Juan Leon", "813150247", "Kristi Legros", 1, "715.445.0688", null },
                    { 14, new DateTime(2022, 5, 19, 22, 53, 21, 480, DateTimeKind.Local).AddTicks(1779), "Juan Leon", "381689866", "Sidney Klocko", 1, "(880) 734-2588", null },
                    { 1, new DateTime(2022, 5, 19, 22, 53, 21, 480, DateTimeKind.Local).AddTicks(1779), "Juan Leon", "128013937", "Kay Zboncak", 2, "1-872-308-0179 x87057", null },
                    { 7, new DateTime(2022, 5, 19, 22, 53, 21, 480, DateTimeKind.Local).AddTicks(1779), "Juan Leon", "443774834", "Clara Hudson", 2, "(795) 801-1588", null },
                    { 9, new DateTime(2022, 5, 19, 22, 53, 21, 480, DateTimeKind.Local).AddTicks(1779), "Juan Leon", "988760798", "Larry Keebler", 2, "(588) 914-7439 x63416", null },
                    { 10, new DateTime(2022, 5, 19, 22, 53, 21, 480, DateTimeKind.Local).AddTicks(1779), "Juan Leon", "876653512", "Ivan Smith", 2, "1-828-583-5344", null },
                    { 2, new DateTime(2022, 5, 19, 22, 53, 21, 480, DateTimeKind.Local).AddTicks(1779), "Juan Leon", "970156869", "Tom Koepp", 3, "241-828-9693", null },
                    { 6, new DateTime(2022, 5, 19, 22, 53, 21, 480, DateTimeKind.Local).AddTicks(1779), "Juan Leon", "856721513", "Elbert Macejkovic", 3, "(804) 888-5992 x866", null },
                    { 8, new DateTime(2022, 5, 19, 22, 53, 21, 480, DateTimeKind.Local).AddTicks(1779), "Juan Leon", "993313376", "Candice Wintheiser", 3, "854.889.3583 x34869", null },
                    { 15, new DateTime(2022, 5, 19, 22, 53, 21, 480, DateTimeKind.Local).AddTicks(1779), "Juan Leon", "752046397", "Glen Wintheiser", 3, "1-616-589-3351", null }
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
