﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyThienNguyen.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DataContext : DbContext
    {
        public DataContext()
            : base("name=DataContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<ChiTietUngHo> ChiTietUngHoes { get; set; }
        public virtual DbSet<DonViUngHo> DonViUngHoes { get; set; }
        public virtual DbSet<DotUngHo> DotUngHoes { get; set; }
        public virtual DbSet<HinhThucUngHo> HinhThucUngHoes { get; set; }
        public virtual DbSet<HoDan> HoDans { get; set; }
        public virtual DbSet<ThanhVienDVUH> ThanhVienDVUHs { get; set; }
        public virtual DbSet<ThongKe> ThongKes { get; set; }
    }
}
