﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Urun_Takip_Entity_
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbUrunEntities : DbContext
    {
        public DbUrunEntities()
            : base("name=DbUrunEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TblKategori> TblKategoris { get; set; }
        public virtual DbSet<TblMusteriler> TblMusterilers { get; set; }
        public virtual DbSet<TblSatislar> TblSatislars { get; set; }
        public virtual DbSet<TblUrunler> TblUrunlers { get; set; }
    }
}
