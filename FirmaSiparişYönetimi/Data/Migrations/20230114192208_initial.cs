using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Firmalar",
                columns: table => new
                {
                    FirmaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Onay = table.Column<bool>(type: "bit", nullable: false),
                    SatısBaslangicSaati = table.Column<TimeSpan>(type: "time", nullable: false),
                    SatısBitisSaati = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmalar", x => x.FirmaID);
                });

            migrationBuilder.CreateTable(
                name: "Urunler",
                columns: table => new
                {
                    UrunID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UrunAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stok = table.Column<short>(type: "smallint", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FirmaID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunler", x => x.UrunID);
                    table.ForeignKey(
                        name: "FK_Urunler_Firmalar_FirmaID",
                        column: x => x.FirmaID,
                        principalTable: "Firmalar",
                        principalColumn: "FirmaID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Siparisler",
                columns: table => new
                {
                    SiparisID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirmaID = table.Column<int>(type: "int", nullable: true),
                    UrunID = table.Column<int>(type: "int", nullable: false),
                    SiparisVeren = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiparisSaati = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparisler", x => x.SiparisID);
                    table.ForeignKey(
                        name: "FK_Siparisler_Firmalar_FirmaID",
                        column: x => x.FirmaID,
                        principalTable: "Firmalar",
                        principalColumn: "FirmaID");
                    table.ForeignKey(
                        name: "FK_Siparisler_Urunler_UrunID",
                        column: x => x.UrunID,
                        principalTable: "Urunler",
                        principalColumn: "UrunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Siparisler_FirmaID",
                table: "Siparisler",
                column: "FirmaID");

            migrationBuilder.CreateIndex(
                name: "IX_Siparisler_UrunID",
                table: "Siparisler",
                column: "UrunID");

            migrationBuilder.CreateIndex(
                name: "IX_Urunler_FirmaID",
                table: "Urunler",
                column: "FirmaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Siparisler");

            migrationBuilder.DropTable(
                name: "Urunler");

            migrationBuilder.DropTable(
                name: "Firmalar");
        }
    }
}
