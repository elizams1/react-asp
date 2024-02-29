namespace ReactViewModel;
public class VMTbKaryawan
{
    public long Id { get; set; }
    public string Nip { get; set; } = null!;
    public string NamaDepan { get; set; } = null!;
    public string NamaBelakang { get; set; } = null!;
    public string JenisKelamin { get; set; } = null!;
    public string Agama { get; set; } = null!;
    public string TempatLahir { get; set; } = null!;
    public DateTime? TglLahir { get; set; }
    public string Alamat { get; set; } = null!;
    public string PendidikanTerakhir { get; set; } = null!;
    public DateTime? TglMasuk { get; set; }

    //satu
}
