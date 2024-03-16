using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SD19305_Bai4_DAL.DomainClass;

namespace SD19305_Bai4_DAL.Context;

public partial class MyContext : DbContext
{
    public MyContext()
    {
    }

    public MyContext(DbContextOptions<MyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Nhanvien> Nhanviens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source= LAPTOP-S8183VSG\\SQLEXPRESS ;Initial Catalog= NET102_DEMO;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
