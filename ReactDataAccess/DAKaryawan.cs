using BATCH336B.ViewModel;
using ReactDataModel;
using ReactViewModel;
using System.Net;

namespace ReactDataAccess;
public class DAKaryawan
{
    private VMResponse response = new VMResponse();

    private readonly DBHRContext db;

    public DAKaryawan(DBHRContext _db) { db = _db; }

    public VMResponse GetAll()
    {
        try
        {
            List<VMTbKaryawan> data = (
                from k in db.TbKaryawans
                select new VMTbKaryawan
                {
                    Id = k.Id,
                    Nip = k.Nip,
                    NamaDepan = k.NamaDepan,
                    NamaBelakang = k.NamaBelakang,
                    JenisKelamin = k.JenisKelamin,
                    Agama = k.Agama,
                    TempatLahir = k.TempatLahir,
                    TglLahir = k.TglLahir,
                    Alamat = k.Alamat,
                    PendidikanTerakhir = k.PendidikanTerakhir,
                    TglMasuk =  k.TglMasuk
                }
                ).ToList();

            response.data = data;
            response.message = (data.Count > 0) ? $"{data.Count} Karyawan data successfully fetched!" : "Karyawan has no data!";
            response.StatusCode = (data.Count > 0) ? HttpStatusCode.OK : HttpStatusCode.NoContent;
        

        }
        catch(Exception ex)
        {
            response.message = ex.Message;
            response.StatusCode = HttpStatusCode.NotFound;
        }
        return response;
    }
}
