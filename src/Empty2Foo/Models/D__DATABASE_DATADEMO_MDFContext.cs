using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Empty2Foo.Models
{
    public partial class D__DATABASE_DATADEMO_MDFContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //    optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Database\DataDemo.mdf;Integrated Security=True;Connect Timeout=30");
        //}

        public D__DATABASE_DATADEMO_MDFContext(DbContextOptions<D__DATABASE_DATADEMO_MDFContext>
            options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("PK__School__4616479E153C0280");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nchar(30)");

                entity.Property(e => e.Site).HasMaxLength(100);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.ObjId)
                    .HasName("PK__Student__4616479EA93740DD");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnType("nchar(20)");

                entity.Property(e => e.StudentId)
                    .IsRequired()
                    .HasColumnType("nchar(13)");

                entity.Property(e => e.TheSchool).HasColumnName("theSchool");

                entity.HasOne(d => d.TheSchoolNavigation)
                    .WithMany(p => p.Student)
                    .HasForeignKey(d => d.TheSchool)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }

        public virtual DbSet<School> School { get; set; }
        public virtual DbSet<Student> Student { get; set; }
    }
}