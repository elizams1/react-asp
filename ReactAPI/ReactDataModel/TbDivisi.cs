using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReactDataModel
{
    [Table("tb_divisi")]
    public partial class TbDivisi
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        [Column("kd_divisi")]
        [StringLength(50)]
        [Unicode(false)]
        public string KdDivisi { get; set; } = null!;
        [Column("nama_divisi")]
        [StringLength(50)]
        [Unicode(false)]
        public string NamaDivisi { get; set; } = null!;
    }
}
