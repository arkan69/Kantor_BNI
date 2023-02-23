using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class new_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "APP_CHANNEL_TEMP",
                columns: table => new
                {
                    NoidentitasKTP = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    KodeNamaPanggilan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamaDepan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamaBelakang = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlamatKTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RW = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kelurahan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kecamatan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KodePos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KodeLokasi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KodeGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Alamat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kodeposrumah = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoHP = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NPWP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamaIbuKandung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KodeAgama = table.Column<int>(type: "int", nullable: true),
                    TanggalLahir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TempatLahir = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusPerkawinan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamaDepanPasangan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamaBelakangPasangan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoIdentitasPasangan = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TanggalLahirPasangan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    JenisKelamin = table.Column<int>(type: "int", nullable: true),
                    Pekerjaan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NamaPerusahaan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AlamatPerusahaan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NPWPPerusahaan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TanggalPendirianPerusahaan = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TanggalLahirPemegangSaham = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TeleponKantor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PendapatanPerbulan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TujuanPenggunaan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JumlahKredit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tenor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NPPSales = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APP_CHANNEL_TEMP", x => x.NoidentitasKTP);
                    table.UniqueConstraint("AK_APP_CHANNEL_TEMP_NoHP", x => x.NoHP);
                    table.UniqueConstraint("AK_APP_CHANNEL_TEMP_NoIdentitasPasangan", x => x.NoIdentitasPasangan);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "APP_CHANNEL_TEMP");
        }
    }
}
