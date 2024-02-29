using BATCH336B.ViewModel;
using Microsoft.AspNetCore.Mvc;
using ReactDataAccess;
using ReactDataModel;

namespace ReactAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KaryawanController : Controller
    {
        public DAKaryawan karyawan;
        public KaryawanController(DBHRContext _db)
        {
            karyawan = new DAKaryawan(_db);
        }

        [HttpGet]
        public VMResponse GetAll()
        {
            return karyawan.GetAll();
        }
    }
}
