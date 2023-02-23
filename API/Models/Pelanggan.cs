using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    [Table("APP_CHANNEL_TEMP")]
    public class Pelanggan
    {
        public string? KodeNamaPanggilan { get; set; }
		public string? NamaDepan { get; set; }
        public string? NamaBelakang { get; set; }
        public string? AlamatKTP { get; set; }
        public string? RT { get; set; }
        public string? RW { get; set; }
        public string? Kelurahan { get; set; }
        public string? Kecamatan { get; set; }
        public string? KodePos { get; set; }
        public string? KodeLokasi { get; set; }
        public string? KodeGroup { get; set; }

        [Key]
        public string NoidentitasKTP { get; set; }
        public string? Alamat { get; set; }
        public string? Kodeposrumah { get; set; }
        public string? NoHP { get; set; }
        public string? NPWP { get; set; }
        public string? NamaIbuKandung { get; set; }
        public Agama? KodeAgama { get; set; }
        public string? TanggalLahir { get; set; }
        public string? TempatLahir { get; set; }
        public string? StatusPerkawinan { get; set; }
        public string? NamaDepanPasangan { get; set; }
        public string? NamaBelakangPasangan { get; set; }
        public string? NoIdentitasPasangan { get; set; }
        public DateTime? TanggalLahirPasangan { get; set; }
        public Kelamin? JenisKelamin { get; set; }
        public string? Pekerjaan { get; set; }
        public string? NamaPerusahaan { get; set; }
        public string? AlamatPerusahaan { get; set; }
        public string? NPWPPerusahaan { get; set; }
        public DateTime? TanggalPendirianPerusahaan { get; set; }
        public DateTime? TanggalLahirPemegangSaham { get; set; }
        public string? TeleponKantor { get; set; }
        public string? PendapatanPerbulan { get; set; }
        public string? TujuanPenggunaan { get; set; }
        public string? JumlahKredit { get; set; }
        public string? Tenor { get; set; }
        public string? NPPSales { get; set; }

    }

    public enum Agama
    {
        Islam,
        Katholik,
        Kristen_Protestan,
        Budha,
        Hindhu
    }
    
    public enum Kelamin
    {
        Male,
        Female
    }
}
