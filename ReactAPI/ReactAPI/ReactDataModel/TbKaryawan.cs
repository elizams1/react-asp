using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReactDataModel
{
    [Table("tb_karyawan")]
    [Index("Nip", Name = "U_tb_karyawan_nip", IsUnique = true)]
    public partial class TbKaryawan
    {
        [Column("id")]
        public long Id { get; set; }
        [Key]
        [Column("nip")]
        [StringLength(50)]
        [Unicode(false)]
        public string Nip { get; set; } = null!;
        [Column("nama_depan")]
        [StringLength(50)]
        [Unicode(false)]
        public string NamaDepan { get; set; } = null!;
        [Column("nama_belakang")]
        [StringLength(50)]
        [Unicode(false)]
        public string NamaBelakang { get; set; } = null!;
        [Column("jenis_kelamin")]
        [StringLength(50)]
        [Unicode(false)]
        public string JenisKelamin { get; set; } = null!;
        [Column("agama")]
        [StringLength(50)]
        [Unicode(false)]
        public string Agama { get; set; } = null!;
        [Column("tempat_lahir")]
        [StringLength(50)]
        [Unicode(false)]
        public string TempatLahir { get; set; } = null!;
        [Column("tgl_lahir", TypeName = "date")]
        public DateTime? TglLahir { get; set; }
        [Column("alamat")]
        [StringLength(50)]
        [Unicode(false)]
        public string Alamat { get; set; } = null!;
        [Column("pendidikan_terakhir")]
        [StringLength(50)]
        [Unicode(false)]
        public string PendidikanTerakhir { get; set; } = null!;
        [Column("tgl_masuk", TypeName = "date")]
        public DateTime? TglMasuk { get; set; }
    }
}
