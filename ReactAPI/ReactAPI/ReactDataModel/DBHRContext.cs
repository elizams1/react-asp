using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ReactDataModel
{
    public partial class DBHRContext : DbContext
    {
        public DBHRContext()
        {
        }

        public DBHRContext(DbContextOptions<DBHRContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbDivisi> TbDivisis { get; set; } = null!;
        public virtual DbSet<TbJabatan> TbJabatans { get; set; } = null!;
        public virtual DbSet<TbKaryawan> TbKaryawans { get; set; } = null!;
        public virtual DbSet<TbPekerjaan> TbPekerjaans { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Initial Catalog=DBHR;user id=sa;Password=P@ssw0rd");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbJabatan>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TbPekerjaan>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
