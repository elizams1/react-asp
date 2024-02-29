using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReactDataModel
{
    [Table("tb_jabatan")]
    public partial class TbJabatan
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("kd_jabatan")]
        [StringLength(50)]
        [Unicode(false)]
        public string KdJabatan { get; set; } = null!;
        [Column("nama_jabatan")]
        [StringLength(50)]
        [Unicode(false)]
        public string NamaJabatan { get; set; } = null!;
        [Column("gaji_pokok", TypeName = "numeric(18, 0)")]
        public decimal? GajiPokok { get; set; }
        [Column("tunjangan_jabatan", TypeName = "numeric(18, 0)")]
        public decimal? TunjanganJabatan { get; set; }
    }
}
