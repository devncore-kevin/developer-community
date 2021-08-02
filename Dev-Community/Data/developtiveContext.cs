using System;
using Dev_Community.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Dev_Community.Data
{
    public partial class developtiveContext : DbContext
    {
        public developtiveContext()
        {
        }

        public developtiveContext(DbContextOptions<developtiveContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Board> Boards { get; set; }
        public virtual DbSet<UserAccount> UserAccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=.;Trusted_Connection=true; Database=developtive;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Korean_Wansung_CI_AS");

            modelBuilder.Entity<Board>(entity =>
            {
                entity.HasKey(e => e.Seq)
                    .HasName("PK__BOARD__CA1938C0E0151B2F");

                entity.ToTable("BOARD");

                entity.Property(e => e.Seq).HasColumnName("SEQ");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnType("ntext")
                    .HasColumnName("CONTENT");

                entity.Property(e => e.Created)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CREATED");

                entity.Property(e => e.FkUserSeq).HasColumnName("FK_USER_SEQ");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(300)
                    .HasColumnName("TITLE");

                entity.Property(e => e.Updated)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("UPDATED");

                entity.Property(e => e.ViewCount).HasColumnName("VIEW_COUNT");
            });

            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.HasKey(e => e.Seq)
                    .HasName("PK__USER_TAB__CA1938C07C446054");

                entity.ToTable("USER_ACCOUNT");

                entity.Property(e => e.Seq).HasColumnName("SEQ");

                entity.Property(e => e.Created)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("CREATED");

                entity.Property(e => e.UsrName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("USR_NAME");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
