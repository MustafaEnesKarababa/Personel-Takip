using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class enesMig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departmanlar",
                columns: table => new
                {
                    DepartmanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmanAdi = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departmanlar", x => x.DepartmanId);
                });

            migrationBuilder.CreateTable(
                name: "Yetkililer",
                columns: table => new
                {
                    YetkiliId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HataliGiris = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    AktifDurum = table.Column<int>(type: "int", nullable: false, defaultValue: 1),
                    YetkiDurum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yetkililer", x => x.YetkiliId);
                });

            migrationBuilder.CreateTable(
                name: "Personeller",
                columns: table => new
                {
                    PersonelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TC = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Cinsiyet = table.Column<int>(type: "int", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personeller", x => x.PersonelId);
                    table.ForeignKey(
                        name: "FK_Personeller_Departmanlar_DepartmanId",
                        column: x => x.DepartmanId,
                        principalTable: "Departmanlar",
                        principalColumn: "DepartmanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loginler",
                columns: table => new
                {
                    LoginId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GirisTarihi = table.Column<DateTime>(type: "datetime2", nullable: true),
                    YetkiliId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loginler", x => x.LoginId);
                    table.ForeignKey(
                        name: "FK_Loginler_Yetkililer_YetkiliId",
                        column: x => x.YetkiliId,
                        principalTable: "Yetkililer",
                        principalColumn: "YetkiliId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departmanlar",
                columns: new[] { "DepartmanId", "DepartmanAdi" },
                values: new object[,]
                {
                    { 1, "Muhasebe" },
                    { 2, "İnsan Kaynakları" },
                    { 3, "Finans" }
                });

            migrationBuilder.InsertData(
                table: "Yetkililer",
                columns: new[] { "YetkiliId", "KullaniciAdi", "Sifre", "YetkiDurum" },
                values: new object[,]
                {
                    { 1, "muhasebe@123", "1234", 2 },
                    { 2, "admin@admin", "admin@123", 1 }
                });

            migrationBuilder.InsertData(
                table: "Loginler",
                columns: new[] { "LoginId", "GirisTarihi", "YetkiliId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(2023, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "Personeller",
                columns: new[] { "PersonelId", "Ad", "Adres", "Cinsiyet", "DepartmanId", "DogumTarihi", "Mail", "Soyad", "TC", "Telefon" },
                values: new object[,]
                {
                    { 1, "Ahmet", "Kadıköy, İstanbul", 2, 1, new DateTime(1993, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "ahmet@gmail.com", "Güler", "11111111111", "05554443322" },
                    { 2, "Ayşe", null, 1, 3, new DateTime(1996, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Yılmaz", "22222222222", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loginler_YetkiliId",
                table: "Loginler",
                column: "YetkiliId");

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_DepartmanId",
                table: "Personeller",
                column: "DepartmanId");

            migrationBuilder.CreateIndex(
                name: "IX_Personeller_TC",
                table: "Personeller",
                column: "TC",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loginler");

            migrationBuilder.DropTable(
                name: "Personeller");

            migrationBuilder.DropTable(
                name: "Yetkililer");

            migrationBuilder.DropTable(
                name: "Departmanlar");
        }
    }
}
