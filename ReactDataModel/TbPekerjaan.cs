using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReactDataModel
{
    [Table("tb_pekerjaan")]
    public partial class TbPekerjaan
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("nip")]
        [StringLength(50)]
        [Unicode(false)]
        public string Nip { get; set; } = null!;
        [Column("kode_jabatan")]
        [StringLength(50)]
        [Unicode(false)]
        public string KodeJabatan { get; set; } = null!;
        [Column("kode_divisi")]
        [StringLength(50)]
        [Unicode(false)]
        public string KodeDivisi { get; set; } = null!;
        [Column("tunjangan_kinerja", TypeName = "numeric(18, 0)")]
        public decimal? TunjanganKinerja { get; set; }
        [Column("kota_penempatan")]
        [StringLength(50)]
        [Unicode(false)]
        public string? KotaPenempatan { get; set; }
    }
}
