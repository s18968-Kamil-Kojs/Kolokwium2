using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Kolokwium2.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    IdArtist = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nickname = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.IdArtist);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    IdEvent = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.IdEvent);
                });

            migrationBuilder.CreateTable(
                name: "Organiser",
                columns: table => new
                {
                    IdOrganiser = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organiser", x => x.IdOrganiser);
                });

            migrationBuilder.CreateTable(
                name: "Artist_Event",
                columns: table => new
                {
                    IdArtist = table.Column<int>(nullable: false),
                    IdEvent = table.Column<int>(nullable: false),
                    PerformanceDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist_Event", x => x.IdArtist);
                    table.ForeignKey(
                        name: "FK_Artist_Event_Artist_IdArtist",
                        column: x => x.IdArtist,
                        principalTable: "Artist",
                        principalColumn: "IdArtist",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Artist_Event_Event_IdEvent",
                        column: x => x.IdEvent,
                        principalTable: "Event",
                        principalColumn: "IdEvent",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Event_Organiser",
                columns: table => new
                {
                    IdOrganiser = table.Column<int>(nullable: false),
                    IdEvent = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event_Organiser", x => x.IdOrganiser);
                    table.ForeignKey(
                        name: "FK_Event_Organiser_Event_IdEvent",
                        column: x => x.IdEvent,
                        principalTable: "Event",
                        principalColumn: "IdEvent",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Event_Organiser_Organiser_IdOrganiser",
                        column: x => x.IdOrganiser,
                        principalTable: "Organiser",
                        principalColumn: "IdOrganiser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "IdArtist", "Nickname" },
                values: new object[,]
                {
                    { 1, "Skala" },
                    { 2, "Orka" },
                    { 3, "Flet" },
                    { 4, "Brak" },
                    { 5, "Trabka" }
                });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "IdEvent", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 19, 13, 55, 51, 364, DateTimeKind.Local).AddTicks(8030), "Juwenalia", new DateTime(2020, 6, 19, 13, 55, 51, 364, DateTimeKind.Local).AddTicks(7470) },
                    { 2, new DateTime(2020, 6, 19, 13, 55, 51, 364, DateTimeKind.Local).AddTicks(8600), "Dni robotyka", new DateTime(2020, 6, 19, 13, 55, 51, 364, DateTimeKind.Local).AddTicks(8580) },
                    { 3, new DateTime(2020, 6, 19, 13, 55, 51, 364, DateTimeKind.Local).AddTicks(8620), "Dni Warszawy", new DateTime(2020, 6, 19, 13, 55, 51, 364, DateTimeKind.Local).AddTicks(8620) },
                    { 4, new DateTime(2020, 6, 19, 13, 55, 51, 364, DateTimeKind.Local).AddTicks(8630), "Dni Lublina", new DateTime(2020, 6, 19, 13, 55, 51, 364, DateTimeKind.Local).AddTicks(8620) },
                    { 5, new DateTime(2020, 6, 19, 13, 55, 51, 364, DateTimeKind.Local).AddTicks(8630), "Dni Wolowa", new DateTime(2020, 6, 19, 13, 55, 51, 364, DateTimeKind.Local).AddTicks(8630) }
                });

            migrationBuilder.InsertData(
                table: "Organiser",
                columns: new[] { "IdOrganiser", "Name" },
                values: new object[,]
                {
                    { 1, "Urzad miasta" },
                    { 2, "Gmina" },
                    { 3, "Urzad miasta" },
                    { 4, "Urzad miasta" },
                    { 5, "Gmina" }
                });

            migrationBuilder.InsertData(
                table: "Artist_Event",
                columns: new[] { "IdArtist", "IdEvent", "PerformanceDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2020, 6, 19, 13, 55, 51, 357, DateTimeKind.Local).AddTicks(6060) },
                    { 2, 2, new DateTime(2020, 6, 19, 13, 55, 51, 361, DateTimeKind.Local).AddTicks(1660) },
                    { 3, 3, new DateTime(2020, 6, 19, 13, 55, 51, 361, DateTimeKind.Local).AddTicks(1720) },
                    { 4, 4, new DateTime(2020, 6, 19, 13, 55, 51, 361, DateTimeKind.Local).AddTicks(1720) },
                    { 5, 5, new DateTime(2020, 6, 19, 13, 55, 51, 361, DateTimeKind.Local).AddTicks(1730) }
                });

            migrationBuilder.InsertData(
                table: "Event_Organiser",
                columns: new[] { "IdOrganiser", "IdEvent" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artist_Event_IdEvent",
                table: "Artist_Event",
                column: "IdEvent");

            migrationBuilder.CreateIndex(
                name: "IX_Event_Organiser_IdEvent",
                table: "Event_Organiser",
                column: "IdEvent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artist_Event");

            migrationBuilder.DropTable(
                name: "Event_Organiser");

            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Organiser");
        }
    }
}
