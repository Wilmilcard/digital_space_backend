using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Domain.Migrations
{
    public partial class CrearBD : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.EmployeeID);
                });

            migrationBuilder.InsertData(
                table: "Persons",
                columns: new[] { "EmployeeID", "CreatedAt", "CreatedBy", "Document", "Name", "Telephone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 5, 19, 21, 52, 7, 313, DateTimeKind.Local).AddTicks(921), "Juan Leon", "948426325", "Casey Heller", "(819) 961-9732", null },
                    { 2, new DateTime(2022, 5, 19, 21, 52, 7, 313, DateTimeKind.Local).AddTicks(921), "Juan Leon", "141139918", "Kristi Runte", "881-829-7031 x15056", null },
                    { 3, new DateTime(2022, 5, 19, 21, 52, 7, 313, DateTimeKind.Local).AddTicks(921), "Juan Leon", "152008784", "Angel Ondricka", "213-357-1280 x9524", null },
                    { 4, new DateTime(2022, 5, 19, 21, 52, 7, 313, DateTimeKind.Local).AddTicks(921), "Juan Leon", "599894278", "Tommie Rosenbaum", "650-412-7858", null },
                    { 5, new DateTime(2022, 5, 19, 21, 52, 7, 313, DateTimeKind.Local).AddTicks(921), "Juan Leon", "216959548", "Heather Bins", "1-297-426-5374", null },
                    { 6, new DateTime(2022, 5, 19, 21, 52, 7, 313, DateTimeKind.Local).AddTicks(921), "Juan Leon", "396820505", "Willis Thiel", "449-331-9036 x283", null },
                    { 7, new DateTime(2022, 5, 19, 21, 52, 7, 313, DateTimeKind.Local).AddTicks(921), "Juan Leon", "691765718", "Alma Lockman", "(750) 722-8709 x7380", null },
                    { 8, new DateTime(2022, 5, 19, 21, 52, 7, 313, DateTimeKind.Local).AddTicks(921), "Juan Leon", "548745407", "Ann Corwin", "(495) 835-5005", null },
                    { 9, new DateTime(2022, 5, 19, 21, 52, 7, 313, DateTimeKind.Local).AddTicks(921), "Juan Leon", "676104089", "Danny Balistreri", "890-452-1986", null },
                    { 10, new DateTime(2022, 5, 19, 21, 52, 7, 313, DateTimeKind.Local).AddTicks(921), "Juan Leon", "747362185", "Melanie Jaskolski", "(232) 927-1015", null },
                    { 11, new DateTime(2022, 5, 19, 21, 52, 7, 313, DateTimeKind.Local).AddTicks(921), "Juan Leon", "988460931", "Gwen Blick", "838-747-7842 x148", null },
                    { 12, new DateTime(2022, 5, 19, 21, 52, 7, 313, DateTimeKind.Local).AddTicks(921), "Juan Leon", "247969364", "Maria Fritsch", "1-397-602-0946", null },
                    { 13, new DateTime(2022, 5, 19, 21, 52, 7, 313, DateTimeKind.Local).AddTicks(921), "Juan Leon", "249755410", "Charlene King", "832-440-2751", null },
                    { 14, new DateTime(2022, 5, 19, 21, 52, 7, 313, DateTimeKind.Local).AddTicks(921), "Juan Leon", "471782504", "Grady Schmidt", "1-546-676-3045 x50103", null },
                    { 15, new DateTime(2022, 5, 19, 21, 52, 7, 313, DateTimeKind.Local).AddTicks(921), "Juan Leon", "207903521", "Allan Rowe", "(330) 744-8105 x170", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Persons");
        }
    }
}
